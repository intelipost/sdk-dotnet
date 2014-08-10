using Newtonsoft.Json;

namespace Intelipost.API.Model
{
    public class ResponseError
    {
        /// <summary>
        /// Tipo de erro retornado.
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }
        /// <summary>
        /// Texto do erro.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }
        /// <summary>
        /// Chave do erro.
        /// </summary>
        [JsonProperty("key")]
        public string Key { get; set; }
    }
}