using System.Resources;
using System.Windows;
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
    internal class Request
    {
        /// <summary>
        /// Cria os argumentos que serão enviados ao CUrl.
        /// </summary>
        /// <param name="apiKey">Chave da aplicação.</param>
        /// <param name="url">URL para a requisição.</param>
        /// <param name="action">Ação a ser enviada.</param>
        /// <param name="method">Método de envio.</param>
        /// <param name="requestData">Entidade devidamente preenchida.</param>
        /// <returns>Retorna uma string para ser executada no CUrl.</returns>
        private string CreateRequest(string apiKey, string url, string action, string method, object requestData)
        {
            return String.Format(@"curl -k -H ""api_key: {0}; Content-Type: application/json; charset=UTF-8"" -X {1} -d ""{2}"" {3}/{4}", apiKey, method, requestData, url, action);
        }

        /// <summary>
        /// Inicia o processo de execução e resposta contra o CUrl da InteliPost.
        /// </summary>
        /// <param name="cUrlAgurments">Argumentos necessários para enviar a requisição.</param>
        /// <returns>Retorna a resposta da InteliPost.</returns>
        private string StartCUrlProcess(string cUrlAgurments)
        {
            string tempExeName = Path.GetDirectoryName(Assembly.GetExecutingAssembly().Location) + "\\Resources\\curl.exe";

            using (var fileStream = new FileStream(tempExeName, FileMode.CreateNew, FileAccess.Write))
            {
                byte[] bytes = Resources.GetCUrlExe();
                fileStream.Write(bytes, 0, bytes.Length);
            }

            var cUrlProcess = new Process
            {
                EnableRaisingEvents = false,
                StartInfo =
                {
                    FileName = tempExeName,
                    Arguments = cUrlAgurments,
                    RedirectStandardOutput = true,
                    UseShellExecute = false,
                    CreateNoWindow = true
                }
            };

            cUrlProcess.Start();

            var response = "";

            while (!cUrlProcess.StandardOutput.EndOfStream)
            {
                response += cUrlProcess.StandardOutput.ReadLine();
            }

            cUrlProcess.WaitForExit();

            new FileInfo(tempExeName).Delete();

            return response;
        }

        /// <summary>
        /// Faz toda a criação, execução, captura e log de retorno do servidor da InteliPost.
        /// </summary>
        /// <param name="apiKey">Chave da aplicação.</param>
        /// <param name="url">URL para a requisição.</param>
        /// <param name="action">Ação a ser enviada.</param>
        /// <param name="method">Método de envio.</param>
        /// <param name="requestData">Entidade devidamente preenchida.</param>
        /// <returns>Retorna uma Entidade padrão de resposta da InteliPost.</returns>
        internal Response Execute(string apiKey, string url, string action, string method, Model.Request requestData)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            var responseData = new Response();

            var cUrlArguments = CreateRequest(apiKey, url, action, method, JsonConvert.SerializeObject(requestData));

            try
            {
                if (Business.Configure.PublicInstance.Logging)
                {
                    new Logger().Insert(String.Format("{0} > FULL REQUEST: {1}", DateTime.Now, cUrlArguments));
                }

                responseData = JsonConvert.DeserializeObject<Response>(StartCUrlProcess(cUrlArguments));
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