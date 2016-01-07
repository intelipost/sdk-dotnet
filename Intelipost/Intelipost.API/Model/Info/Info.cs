using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade responsável por alterar o status do pedido para "Pronto Para Envio"
    /// </summary>
    public class Info
    {
        /// <summary>
        /// ID do cliente.
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Nome
        /// </summary>
        [JsonProperty("common_name")]
        public string CommonName { get; set; }

        /// <summary>
        /// Métodos de envio.
        /// </summary>
        [JsonProperty("delivery_methods")]
        public List<DeliveryMethods> DeliveryMethods { get; set; }

        public Info()
        {
            DeliveryMethods = new List<DeliveryMethods>();
        }
        public bool ShouldSerializeTrackingDataArray()
        {
            return (DeliveryMethods.Count > 0);
        }
    }
}