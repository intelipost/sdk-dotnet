using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade responsável por alterar o status do pedido para "Pronto Para Envio"
    /// </summary>
    public class Shipped
    {
        /// <summary>
        /// Numero do pedido.
        /// </summary>
        [JsonProperty("order_number")]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Numero do pedido.
        /// </summary>
        [JsonProperty("tracking_data_array")]
        public List<TrackingDataArray> TrackingDataArray { get; set; }

        public Shipped()
        {
            TrackingDataArray = new List<TrackingDataArray>();
        }
        public bool ShouldSerializeTrackingDataArray()
        {
            return (TrackingDataArray.Count > 0);
        }
    }
}