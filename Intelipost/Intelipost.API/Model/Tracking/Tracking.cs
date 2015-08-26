using System;
using Intelipost.API.Utilities;
using Newtonsoft.Json;
using System.Collections.Generic;
using Intelipost.API.Infrastructure.TimestampToDateTime;
using Newtonsoft.Json.Converters;
namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade respectiva ao Pedido.
    /// </summary>
    
    public class Tracking
    {        
        /// <summary>
        /// Numero do Pedido.
        /// </summary>
        [JsonProperty("order_number")]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Código de rastreio.
        /// </summary>
        [JsonProperty("tracking_code")]
        public string TrackingCode { get; set; }

        /// <summary>
        /// Número do volume.
        /// </summary>
        [JsonProperty("volume_number")]
        public string VolumeNumber { get; set; }

        /// <summary>
        /// Informações da nota fiscal
        /// </summary>
        [JsonProperty("invoice")]
        public ShipmentOrderVolumeInvoice Invoice { get; set; }

        /// <summary>
        /// Informações da nota fiscal
        /// </summary>
        [JsonProperty("history")]
        public History History { get; set; }

        public Tracking()
        {
            History = new History();
            Invoice = new ShipmentOrderVolumeInvoice();
        }
    }
}