using Intelipost.API.Infrastructure.TimestampToDateTime;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade referente aos dados dos anexos 
    /// </summary>
    public class Attachments
    {
        /// <summary>
        /// Nome do arquivo
        /// </summary>
        [JsonProperty("file_name")]
        public string FileName { get; set; }

        /// <summary>
        /// Identificação da extensão dos anexos
        /// </summary>
        [JsonProperty("mime_type")]
        public string MimeType { get; set; }

        /// <summary>
        /// Tipo do arquivo
        /// </summary>
        [JsonProperty("type")]
        public string Type { get; set; }

        /// <summary>
        /// Status de processamento
        /// </summary>
        [JsonProperty("processing_status")]
        public string ProcessingStatus { get; set; }

        /// <summary>
        /// Informações adicionais do anexo
        /// </summary>
        [JsonProperty("additional_information")]
        public Dictionary<string,string> AdditionalInformation { get; set; }

        /// <summary>
        /// URL do anexo
        /// </summary>
        [JsonProperty("url")]
        public string Url { get; set; }

        /// <summary>
        /// Data de criação
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Data de modificação
        /// </summary>
        [JsonProperty("modified")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? Modified { get; set; }

        public Attachments()
        {
            AdditionalInformation = new Dictionary<string, string>();
        }
    }
}
