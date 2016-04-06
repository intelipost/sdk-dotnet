using System;
using Intelipost.API.Utilities;
using Newtonsoft.Json;
using System.Collections.Generic;
using Intelipost.API.Infrastructure.TimestampToDateTime;
using Newtonsoft.Json.Converters;
namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade respectiva a mudança do metódo de entrega de um pedido.
    /// </summary>
    public class ChangeDeliveryMethod
    {
        /// <summary>
        /// ID do cliente.
        /// </summary>
        [JsonProperty("client_id")]
        public int? ClientId { get; set; }

        /// <summary>
        /// ID da cotação.
        /// </summary>
        [JsonProperty("quote_id")]
        public int? QuoteId { get; set; }

        /// <summary>
        /// ID do método de envio escolhido.
        /// </summary>
        [JsonProperty("delivery_method_id")]
        public int? DeliveryMethodId { get; set; }

        /// <summary>
        /// Número do pedido
        /// </summary>
        [JsonProperty("order_number")]
        public String OrderNumber { get; set; }

        /// <summary>
        /// Data estimada para entrega (UTC).
        /// </summary>
        [JsonProperty("estimated_delivery_date")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? EstimatedDeliveryDate { get; set; }


        /// <summary>
        /// Volumes
        /// </summary>
        [JsonProperty("volumes")]
        public List<ChangeDeliveryMethodVolumes> Volumes { get; set; }
    }
}