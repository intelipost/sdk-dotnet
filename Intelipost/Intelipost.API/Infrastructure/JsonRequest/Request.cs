﻿using System.Net;
using Intelipost.API.Infrastructure.Log;
using Intelipost.API.Model;
using Newtonsoft.Json;
using System;
using System.Diagnostics;
using System.IO;
using System.Reflection;

namespace Intelipost.API.Infrastructure.JsonRequest
{
    /// <summary>
    /// Classe interna que trata, de forma genérica, as requisições feitas no CUrl.
    /// </summary>
    internal class Request<T> where T : class
    {
        internal HttpWebRequest HttpWebRequest { get; set; }
        internal HttpWebResponse HttpWebResponse { get; set; }

        /// <summary>
        /// Cria a requisição para o envio.
        /// </summary>
        /// <param name="apiKey">Chave da aplicação.</param>
        /// <param name="url">URL para a requisição.</param>
        /// <param name="action">Ação a ser enviada.</param>
        /// <param name="method">Método de envio.</param>
        /// <param name="debug_hash">Hash para utilização do modo debug</param>
        /// <param name="platform">Plataforma requisitante</param>
        /// <param name="platformVersion">Versão da plataforma requisitante</param>
        /// <param name="plugin">Plugin requisitante</param>
        /// <param name="pluginVersion">Versão do plugin requisitante</param>
        internal void CreateRequest(string apiKey, string url, string action, string method, string debug_hash = null, string platform = null, string platformVersion = null, string plugin = null, string pluginVersion = null)
        {
            HttpWebRequest = (HttpWebRequest)WebRequest.Create(String.Format("{0}/{1}", url, action).Replace("//", "/").Replace(":/","://"));
            HttpWebRequest.Accept = "application/json";
            HttpWebRequest.ContentType = "application/json";
            HttpWebRequest.Headers.Add("api_key", apiKey);
            HttpWebRequest.Headers.Add("platform", platform);
            HttpWebRequest.Headers.Add("charset", "UTF-8");
            HttpWebRequest.Headers.Add(".NetVersion", Environment.Version.ToString());
            HttpWebRequest.Headers.Add("APIVersion", FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion);
            HttpWebRequest.AutomaticDecompression = DecompressionMethods.GZip;
            HttpWebRequest.Method = method;
            if(debug_hash != null)
                HttpWebRequest.Headers.Add("debug", debug_hash);

            if (platformVersion != null)
                HttpWebRequest.Headers.Add("platform-version", platformVersion);

            if (plugin != null)
                HttpWebRequest.Headers.Add("plugin", plugin);

            if (pluginVersion != null)
                HttpWebRequest.Headers.Add("plugin-version", pluginVersion);
        }

        /// <summary>
        /// Prepara o conteúdo da requisição para envio.
        /// </summary>
        /// <param name="request">Entidade devidamente preenchida.</param>
        internal void WriteStream(Model.Request<T> request)
        {
            using (var streamWriter = new StreamWriter(HttpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(JsonConvert.SerializeObject(request.Content));
            }
        }

        /// <summary>
        /// Faz a leitura da resposta enviada pelo servidor da InteliPost.
        /// </summary>
        /// <returns></returns>
        internal String ReadResponse()
        {
            if (HttpWebResponse == null) return string.Empty;

            using (var streamReader = new StreamReader(HttpWebResponse.GetResponseStream()))
            {   
                return streamReader.ReadToEnd();
            }
        }

        /// <summary>
        /// Faz a leitura da resposta enviada pelo servidor da InteliPost.
        /// </summary>
        /// <returns></returns>
        internal String ReadResponse(WebException wex)
        {
            if (wex.Response != null)
            {
                using (var errorResponse = (HttpWebResponse)wex.Response)
                {
                    using (var reader = new StreamReader(errorResponse.GetResponseStream()))
                    {
                        String error = reader.ReadToEnd();
                        return error;
                    }
                }
            }
            return null;
        }

        /// <summary>
        /// Faz toda a criação, execução, captura e log de retorno do servidor da InteliPost.
        /// </summary>
        /// <param name="apiKey">Chave da aplicação.</param>
        /// <param name="url">URL para a requisição.</param>
        /// <param name="action">Ação a ser enviada.</param>
        /// <param name="method">Método de envio.</param>
        /// <param name="request">Entidade devidamente preenchida.</param>
        /// <param name="platform">Plataforma da requisição</param>
        /// <param name="platformVersion">Versão da plataforma requisitante</param>
        /// <param name="plugin">Plugin requisitante</param>
        /// <param name="pluginVersion">Versão do plugin requisitante</param>
        /// <returns>Retorna uma Entidade padrão de resposta da InteliPost.</returns>
        internal Response<T> Execute(string apiKey, string url, string action, string method, Model.Request<T> request, string debug_hash = null, string platform = null, string platformVersion = null, string plugin = null, string pluginVersion = null)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var responseData = new Response<T>();

            try
            {
                CreateRequest(apiKey, url, action, method,debug_hash, platform, platformVersion, plugin, pluginVersion);
                if(method.ToUpper() == "POST")
                    WriteStream(request);

                if (Business.Configure.PublicInstance.Logging)
                {
                    new Logger().Insert(String.Format("{0} > FULL REQUEST: {1}", DateTime.Now,((method.ToUpper() == "POST") ? JsonConvert.SerializeObject(request) : url  + action)));
                }

                HttpWebResponse = (HttpWebResponse)HttpWebRequest.GetResponse();
                
                responseData = JsonConvert.DeserializeObject<Response<T>>(ReadResponse());
            }
            catch (WebException ex)
            {
                responseData = JsonConvert.DeserializeObject<Response<T>>(ReadResponse(ex));
                if (Business.Configure.PublicInstance.Logging)
                {
                    new Logger().Insert(String.Format("{0} > RESPONSE ERROR MESSAGE: {1}", DateTime.Now,ex.Message + " >> " + responseData.Messages[0].Text));
                }
                throw ex;
            }

            stopwatch.Stop();

            responseData.OperationTime = Math.Round(stopwatch.Elapsed.TotalMilliseconds) + "ms";

            if (Business.Configure.PublicInstance.Logging)
            {
                new Logger().Insert(String.Format("{0} > RESPONSE: {1}", DateTime.Now, JsonConvert.SerializeObject(responseData)));
            }
            return responseData;
        }
    }
}