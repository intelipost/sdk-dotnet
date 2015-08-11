using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade responsável por alterar o status do pedido para "Pronto Para Envio"
    /// </summary>
    public class ReadyForShipment
    {
        /// <summary>
        /// Numero do pedido.
        /// </summary>
        [JsonProperty("order_number")]
        public string OrderNumber { get; set; }
        public ReadyForShipment()
        {
           
        }
    }
}