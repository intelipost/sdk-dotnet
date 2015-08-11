using System;
using Intelipost.API.Utilities;
using Newtonsoft.Json;
using System.Collections.Generic;
using Intelipost.API.Infrastructure.TimestampToDateTime;
using Newtonsoft.Json.Converters;
namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade respectiva ao volume da encomenda.
    /// </summary>
    
    public class ShipmentOrder
    {
        /// <summary>
        /// Largura da caixa ou envelope.
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Largura da caixa ou envelope.
        /// </summary>
        [JsonProperty("client_id")]
        public int ClientId { get; set; }

        /// <summary>
        /// Largura da caixa ou envelope.
        /// </summary>
        [JsonProperty("quote_id")]
        public int QuoteId { get; set; }

        /// <summary>
        /// Altura da caixa ou envelope.
        /// </summary>
        [JsonProperty("delivery_method_id")]
        public int DeliveryMethodId { get; set; }

        /// <summary>
        /// Largura da caixa ou envelope.
        /// </summary>
        [JsonProperty("provider_shipping_costs")]
        public double ProviderShippingCosts { get; set; }

        /// <summary>
        /// Largura da caixa ou envelope.
        /// </summary>
        [JsonProperty("customer_shipping_costs")]
        public double CustomerShippingCosts { get; set; }

        /// <summary>
        /// Comprimento da caixa (não é necessária para volumes do tipo ENVELOPE).
        /// </summary>
        [JsonProperty("order_number")]
        public string OrderNumber { get; set; }

        /// <summary>
        /// Comprimento da caixa (não é necessária para volumes do tipo ENVELOPE).
        /// </summary>
        [JsonProperty("estimated_delivery_date")]
        public DateTime? EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// Comprimento da caixa (não é necessária para volumes do tipo ENVELOPE).
        /// </summary>
        [JsonProperty("estimated_delivery_date_iso")]
        public string EstimatedDeliveryDateIso { get; set; }

        /// <summary>
        /// Comprimento da caixa (não é necessária para volumes do tipo ENVELOPE).
        /// </summary>
        [JsonProperty("estimated_delivery_date_lp")]
        public string EstimatedDeliveryDateLp { get; set; }

        /// <summary>
        /// Comprimento da caixa (não é necessária para volumes do tipo ENVELOPE).
        /// </summary>
        [JsonProperty("shipped_date")]
        public string ShippedDate { get; set; }

        /// <summary>
        /// Comprimento da caixa (não é necessária para volumes do tipo ENVELOPE).
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime Created { get; set; }

        /// <summary>
        /// Comprimento da caixa (não é necessária para volumes do tipo ENVELOPE).
        /// </summary>
        [JsonProperty("created_iso")]
        public DateTime CreatedIso { get; set; }
        

        /// <summary>
        /// Comprimento da caixa (não é necessária para volumes do tipo ENVELOPE).
        /// </summary>
        [JsonProperty("modified")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime Modified { get; set; }
        

        /// <summary>
        /// Comprimento da caixa (não é necessária para volumes do tipo ENVELOPE).
        /// </summary>
        [JsonProperty("modified_iso")]
        public string ModifiedIso { get; set; }

        /// <summary>
        /// Informações do consumidor
        /// </summary>
        [JsonProperty("end_customer")]
        public EndCustomer EndCustomer { get; set; }

        /// <summary>
        /// Comprimento da caixa (não é necessária para volumes do tipo ENVELOPE).
        /// </summary>
        [JsonProperty("shipment_order_volume_state")]
        public string ShipmentOrderVolumeState { get; set; }
        
        /// <summary>
        /// Comprimento da caixa (não é necessária para volumes do tipo ENVELOPE).
        /// </summary>
        [JsonProperty("delivered_date")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? DeliveredDate { get; set; }

        /// <summary>
        /// Comprimento da caixa (não é necessária para volumes do tipo ENVELOPE).
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
        public bool ShouldSerializeCreatedIso()
        {
            return (CreatedIso != new DateTime());
        }
        public bool ShouldSerializeDeliveredDate()
        {
            return (DeliveredDate != new DateTime());
        }
    }
}