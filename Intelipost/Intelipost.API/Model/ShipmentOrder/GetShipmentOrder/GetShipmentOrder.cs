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
    
    public class GetShipmentOrder
    {
        /// <summary>
        /// Informações do consumidor
        /// </summary>
        [JsonProperty("end_customer")]
        public EndCustomer EndCustomer { get; set; }

        /// <summary>
        /// Numero do Pedido
        /// </summary>
        [JsonProperty("order_number")]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Data em que o despacho do pedido foi realizada (UTC)
        /// </summary>
        [JsonProperty("shipped_date")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? ShippedDate { get; set; }

        /// <summary>
        /// Data estimada para entrega (UTC)
        /// </summary>
        [JsonProperty("estimated_delivery_date")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// Custo de envio para o cliente final.
        /// </summary>
        [JsonProperty("customer_shipping_costs")]
        public double CustomerShippingCosts { get; set; }

        /// <summary>
        /// Informações do pedido.
        /// </summary>
        [JsonProperty("shipment_order")]
        public ShipmentOrder ShipmentOrder { get; set; }

        /// <summary>
        /// Data de modificação do pedido (UTC)
        /// </summary>
        [JsonProperty("modified")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? Modified { get; set; }

        /// <summary>
        /// Nome do método de envio.
        /// </summary>
        [JsonProperty("delivery_method_name")]
        public string DeliveryMethodName { get; set; }

        /// <summary>
        /// Data de criação do pedido (UTC)
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Nome da transportadora.
        /// </summary>
        [JsonProperty("logistic_provider_name")]
        public string LogisticProviderName { get; set; }

        /// <summary>
        /// Custo de envio. (Despachante)
        /// </summary>
        [JsonProperty("provider_shipping_costs")]
        public double ProviderShippingCosts{ get; set; }

        /// <summary>
        /// ID da Ordem de Pedido
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Lista de volumes.
        /// </summary>
        [JsonProperty("shipment_order_volume_array")]
        public List<ShipmentOrderVolumeArray> ShipmentOrderVolumeArray { get; set; }        

        public GetShipmentOrder()
        {
            EndCustomer = new Model.EndCustomer();
            ShipmentOrderVolumeArray = new List<Model.ShipmentOrderVolumeArray>();
            ShipmentOrder = new ShipmentOrder();
        }
        public bool ShouldSerializeCreated()
        {
            return (Created != new DateTime());
        }
       
        public bool ShouldSerializeEstimatedDeliveryDate()
        {
            return (EstimatedDeliveryDate != new DateTime());
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