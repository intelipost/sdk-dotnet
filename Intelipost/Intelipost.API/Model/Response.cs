using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intelipost.API.Model
{
    public class Response<T> where T : class
    {
        /// <summary>
        /// Status da requisição.
        /// </summary>
        [JsonProperty("status")]
        public string Status { get; set; }

        /// <summary>
        /// O conteúdo da requisição.
        /// </summary>
        [JsonProperty("content")]
        public T Content { get; set; }

        /// <summary>
        /// O tempo da requisição por parte da InteliPost.
        /// </summary>
        [JsonProperty("time")]
        public string Time { get; set; }       

        /// <summary>
        /// O tempo da requisição completa.
        /// </summary>
        [JsonProperty("operation_time")]
        public string OperationTime { get; set; }

        /// <summary>
        /// Mensagens de erro, se houver.
        /// </summary>
        [JsonProperty("messages")]
        public List<ResponseError> Messages { get; set; }

        public Response()
        {
            Messages = new List<ResponseError>();
        }
    }
}