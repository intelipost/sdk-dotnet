using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade responsável por alterar o status do pedido para "Pronto Para Envio"
    /// </summary>
    public class GetLabel
    {
        /// <summary>
        /// Numero do pedido.
        /// </summary>
        [JsonProperty("order_number")]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Numero do pedido.
        /// </summary>
        [JsonProperty("shipment_order_volume_number")]
        public string ShipmentOrderVolumeNumber { get; set; }

        /// <summary>
        /// Numero do pedido.
        /// </summary>
        [JsonProperty("label_url")]
        public string labelUrl { get; set; }

        public GetLabel()
        {
           
        }
    }
}