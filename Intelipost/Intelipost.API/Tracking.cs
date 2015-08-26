using Intelipost.API.Model;
using System;
using System.IO;
using System.Net;
using System.Text;
using System.Threading;
using Newtonsoft.Json;

namespace Intelipost.API
{
    /// <summary>
    /// Classe destinada a expor as informações da etiqueta.
    /// </summary>
    public class Tracking
    {
        private HttpListener listener;

        /// <summary>
        /// Método que ativará um listener para receber as requisições do webhook
        /// </summary>
        /// <param name="url">Url definida para receber as requisições do webhook.</param>
        /// <returns>Retorna um objeto com as informações da requisição.</returns>

        public Tracking(string url)
        {
            ThreadPool.SetMaxThreads(50, 1000);
            ThreadPool.SetMinThreads(50, 50);
            listener = new HttpListener();
            listener.Prefixes.Add(url);
            listener.Start();
            while (true)
                try
                {
                    HttpListenerContext request = listener.GetContext();
                    ThreadPool.QueueUserWorkItem(ProcessRequest, request);
                }
                catch (HttpListenerException)
                {
                    break;
                }
                catch (InvalidOperationException)
                {
                    break;
                }
        }
       

        public void Stop() { listener.Stop(); }

        void ProcessRequest(object listenerContext)
        {
            try
            {
                //Reading request
                var context = (HttpListenerContext)listenerContext;
                var postContent = new StreamReader(context.Request.InputStream).ReadToEnd();
                context.Response.KeepAlive = false;

                //Response
                byte[] response = Encoding.UTF8.GetBytes(postContent);
                var output = context.Response.OutputStream;                

                var objTrck = new Model.Tracking();
                //Deserealizing request to object
                objTrck = JsonConvert.DeserializeObject<Model.Tracking>(postContent);

                if (objTrck != new Model.Tracking() && objTrck != null)
                {
                    output.Write(Encoding.UTF8.GetBytes("OK"), 0, Encoding.UTF8.GetBytes("OK").Length);
                    context.Response.StatusCode = 200;
                }
                else
                {
                    output.Write(Encoding.UTF8.GetBytes("BAD REQUEST"), 0, Encoding.UTF8.GetBytes("BAD REQUEST").Length);
                    context.Response.StatusCode = 400;
                }                    

                context.Response.Close();
            }
            catch (Exception ex)
            {
                Console.WriteLine("Request error: " + ex);
            }
        }
    }
}