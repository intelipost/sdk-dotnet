using System.Net;
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
    internal class GetRequest<T> where T : class
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
        internal void CreateRequest(string apiKey, string url, string action, string method)
        {
            HttpWebRequest = (HttpWebRequest)WebRequest.Create(String.Format("{0}{1}", url, action));
            HttpWebRequest.Headers.Add("api_key", apiKey);
            HttpWebRequest.Headers.Add("charset", "UTF-8");
            HttpWebRequest.Headers.Add(".NetVersion", Environment.Version.ToString());
            HttpWebRequest.Headers.Add("APIVersion", FileVersionInfo.GetVersionInfo(Assembly.GetExecutingAssembly().Location).FileVersion);
            HttpWebRequest.AutomaticDecompression = DecompressionMethods.GZip;
            HttpWebRequest.Method = method;
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
        /// Faz toda a criação, execução, captura e log de retorno do servidor da InteliPost.
        /// </summary>
        /// <param name="apiKey">Chave da aplicação.</param>
        /// <param name="url">URL para a requisição.</param>
        /// <param name="action">Ação a ser enviada.</param>
        /// <param name="method">Método de envio.</param>
        /// <param name="request">Entidade devidamente preenchida.</param>
        /// <returns>Retorna uma Entidade padrão de resposta da InteliPost.</returns>
        internal Response<T> Execute(string apiKey, string url, string action, string method)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var responseData = new Response<T>();

            try
            {
                CreateRequest(apiKey, url, action, method);

                if (Business.Configure.PublicInstance.Logging)
                {
                    new Logger().Insert(String.Format("{0} > FULL REQUEST: {1}", DateTime.Now, url+"/"+action ));
                }

                HttpWebResponse = (HttpWebResponse)HttpWebRequest.GetResponse();

                responseData = JsonConvert.DeserializeObject<Response<T>>(ReadResponse());
            }
            catch (Exception ex)
            {
                if (Business.Configure.PublicInstance.Logging)
                {
                    new Logger().Insert(String.Format("{0} > RESPONSE ERROR MESSAGE: {1}", DateTime.Now, ex.Message));
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