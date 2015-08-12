using Newtonsoft.Json;
using System.Collections.Generic;
using System;

namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade responsável por alterar o status do pedido para "Pronto Para Envio"
    /// </summary>
    public class TrackingDataArray
    {
        /// <summary>
        /// Numero do pedido.
        /// </summary>
        [JsonProperty("shipment_order_number")]
        public string ShipmentOrdernumber { get; set; }

        /// <summary>
        /// Numero do pedido.
        /// </summary>
        [JsonProperty("tracking_code")]
        public string TrackingCode { get; set; }
    }
}