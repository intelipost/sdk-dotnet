using System;
using Intelipost.API.Utilities;
using Newtonsoft.Json;
using Intelipost.API.Infrastructure.TimestampToDateTime;

namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade respectiva ao volume da encomenda.
    /// </summary>
    public class ChangeDeliveryMethodVolumes
    {
        /// <summary>
        /// Número do volume
        /// </summary>
        [JsonProperty("volume_number")]
        public String VolumeNumber { get; set; }

        /// <summary>
        /// Código de Rastreamento
        /// </summary>
        [JsonProperty("tracking_code")]
        public String TrackingCode { get; set; }

    }
}