using Newtonsoft.Json;
using System;
using System.IO;
using System.Net;

namespace Intelipost.API.Infrastructure.JsonRequest
{
    public class Request
    {
        public HttpWebRequest HttpWebRequest { get; internal set; }
        public HttpWebResponse HttpWebResponse { get; internal set; }

        internal void CreateRequest(string url, string apiKey, string requestMethod)
        {
            HttpWebRequest = (HttpWebRequest)WebRequest.Create(url);
            HttpWebRequest.ContentType = "application/json";
            HttpWebRequest.Accept = "application/json";
            HttpWebRequest.Headers.Add("api_key", apiKey);
            HttpWebRequest.Method = requestMethod;
        }

        internal void WriteStream(Model.Request request)
        {
            using (var streamWriter = new StreamWriter(HttpWebRequest.GetRequestStream()))
            {
                streamWriter.Write(JsonConvert.SerializeObject(request));
            }
        }

        internal String ReadResponse()
        {
            if (HttpWebResponse == null) return string.Empty;

            using (var streamReader = new StreamReader(HttpWebResponse.GetResponseStream()))
            {
                return streamReader.ReadToEnd();
            }
        }

        internal String ReadResponseFromError(WebException error)
        {
            if (error == null) return string.Empty;

            using (var streamReader = new StreamReader(error.Response.GetResponseStream()))
            {
                return streamReader.ReadToEnd();
            }
        }

        public object Execute<T>(string url, string apiKey)
        {
            CreateRequest(url, apiKey, "GET");

            try
            {
                HttpWebResponse = (HttpWebResponse)HttpWebRequest.GetResponse();
            }
            catch (WebException error)
            {
                HttpWebResponse = (HttpWebResponse)error.Response;
                return ReadResponseFromError(error);
            }

            return JsonConvert.DeserializeObject<T>(ReadResponse());
        }

        public object Execute<T>(string url, string apiKey, Model.Request request)
        {
            CreateRequest(url, apiKey, "POST");

            WriteStream(request);

            try
            {
                HttpWebResponse = (HttpWebResponse)HttpWebRequest.GetResponse();
            }
            catch (WebException error)
            {
                HttpWebResponse = (HttpWebResponse)error.Response;
                return ReadResponseFromError(error);
            }

            return ReadResponse();
        }
    }
}