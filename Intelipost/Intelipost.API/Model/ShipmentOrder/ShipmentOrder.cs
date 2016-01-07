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
    
    public class ShipmentOrder
    {
        /// <summary>
        /// ID da Ordem de Pedido.
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

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
        /// Custo de envio para o despachante.
        /// </summary>
        [JsonProperty("provider_shipping_costs")]
        public double? ProviderShippingCosts { get; set; }

        /// <summary>
        /// Custo de envio para o cliente final.
        /// </summary>
        [JsonProperty("customer_shipping_costs")]
        public double? CustomerShippingCosts { get; set; }

        /// <summary>
        /// Numero do Pedido
        /// </summary>
        [JsonProperty("order_number")]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Data estimada para entrega (UTC).
        /// </summary>
        [JsonProperty("estimated_delivery_date")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// Data de entrega estimada para a transportadora (UTC).
        /// </summary>
        [JsonProperty("estimated_delivery_date_lp")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? EstimatedDeliveryDateLp { get; set; }

        /// <summary>
        /// Data em que o despacho do pedido foi realizada (UTC).
        /// </summary>
        [JsonProperty("shipped_date")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? ShippedDate { get; set; }

        /// <summary>
        /// Data de criação do pedido (UTC).
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Data de modificação do pedido (UTC).
        /// </summary>
        [JsonProperty("modified")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? Modified { get; set; }

        /// <summary>
        /// Informações do consumidor.
        /// </summary>
        [JsonProperty("end_customer")]
        public EndCustomer EndCustomer { get; set; }

        /// <summary>
        /// Status do volume.
        /// </summary>
        [JsonProperty("shipment_order_volume_state")]
        public string ShipmentOrderVolumeState { get; set; }
        
        /// <summary>
        /// Data em que a entrega do pedido foi realizada (UTC).
        /// </summary>
        [JsonProperty("delivered_date")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? DeliveredDate { get; set; }

        /// <summary>
        /// Volumes
        /// </summary>
        [JsonProperty("shipment_order_volume_array")]
        public List<ShipmentOrderVolumeArray> ShipmentOrderVolumeArray { get; set; }

        public ShipmentOrder()
        {
            EndCustomer = new Model.EndCustomer();
            ShipmentOrderVolumeArray = new List<Model.ShipmentOrderVolumeArray>();
        }
        public bool ShouldSerializeCreated()
        {
            return (Created != new DateTime());
        }
        public bool ShouldSerializeDeliveredDate()
        {
            return (DeliveredDate != new DateTime());
        }
        public bool ShouldSerializeEstimatedDeliveryDate()
        {
            return (EstimatedDeliveryDate != new DateTime());
        }
        public bool ShouldSerializeEstimatedDeliveryDateLp()
        {
            return (EstimatedDeliveryDateLp != new DateTime());
        }
        public bool ShouldSerializeShippedDate()
        {
            return (ShippedDate != new DateTime());
        }
        public bool ShouldSerializeModified()
        {
            return (Modified != new DateTime());
        }
    }
}