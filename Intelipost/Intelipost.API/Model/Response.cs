using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intelipost.API.Model
{
    public class Response
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
        public string Content { get; set; }
        /// <summary>
        /// O tempo da requisição por parte da InteliPost.
        /// </summary>
        [JsonProperty("time")]
        public string RequestTime { get; set; }

        /// <summary>
        /// O tempo da requisição completa.
        /// </summary>
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