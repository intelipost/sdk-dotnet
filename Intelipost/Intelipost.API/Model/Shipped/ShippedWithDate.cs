using Newtonsoft.Json;

namespace Intelipost.API.Model
{
    /// <summary>
    /// Classe responsável por marcar diversos pedidos como enviados
    /// </summary>
    public class ShippedWithDate
    {
        /// <summary>
        /// Número do Pedido
        /// </summary>
        [JsonProperty("order_number")]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Data do evento
        /// </summary>
        [JsonProperty("event_date")]
        public string EventDate { get; set; }
    }
}
