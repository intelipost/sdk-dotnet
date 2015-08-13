using System;
using Intelipost.API.Utilities;
using Newtonsoft.Json;
using Intelipost.API.Model;
using Intelipost.API.Infrastructure;
using Intelipost.API.Infrastructure.TimestampToDateTime;
using System.Collections.Generic;

namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade respectiva ao volume da encomenda.
    /// </summary>
    public class ShipmentOrderVolumeArray
    {
        /// <summary>
        /// Numero do volume
        /// </summary>
        [JsonProperty("shipment_order_volume_number")]
        public string ShipmentOrderVolumeNumber { get; set; }

        /// <summary>
        /// ID do pedido.
        /// </summary>
        [JsonProperty("shipment_order_id")]
        public int ShipmentOrderId { get; set; }

        /// <summary>
        /// Estado do volume.
        /// </summary>
        [JsonProperty("shipment_order_volume_state")]
        public string ShipmentOrderVolumeState { get; set; }

        /// <summary>
        /// Largura da caixa ou envelope.
        /// </summary>
        [JsonProperty("width")]
        public double Width { get; set; }

        /// <summary>
        /// Peso da caixa ou envelope.
        /// </summary>
        [JsonProperty("weight")]
        public double Weight { get; set; }

        /// <summary>
        /// Altura da caixa ou envelope.
        /// </summary>
        [JsonProperty("height")]
        public double Height { get; set; }

        /// <summary>
        /// Comprimento da caixa ou envelope.
        /// </summary>
        [JsonProperty("length")]
        public double Length { get; set; }

        /// <summary>
        /// Tipo de produto.
        /// </summary>
        [JsonProperty("products_nature")]
        public string ProductsNature { get; set; }

        /// <summary>
        /// Quantidade de produtos.
        /// </summary>
        [JsonProperty("products_quantity")]
        public int ProductsQuantity { get; set; }

        /// <summary>
        /// ICMS
        /// </summary>
        [JsonProperty("is_icms_exempt")]
        public bool IsIcmsExempt { get; set; }

        /// <summary>
        /// Comprimento da caixa (não é necessária para volumes do tipo ENVELOPE).
        /// </summary>
        [JsonProperty("volume_type_code")]
        public string VolumeTypeCode { get; set; }

        /// <summary>
        /// Data de criação do Volume (UTC)
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Data de modificação do Volume (UTC)
        /// </summary>
        [JsonProperty("modified")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? Modified { get; set; }

        /// <summary>
        /// Code de rastreamento da transportadora.
        /// </summary>
        [JsonProperty("logistic_provider_tracking_code")]
        public string LogisticProviderTrackingCode { get; set; }

        /// <summary>
        /// Data de entrega estimada. (Consumidor)
        /// </summary>
        [JsonProperty("estimated_delivery_date")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? EstimatedDeliveryDate { get; set; }

        /// <summary>
        /// Data de entrega estimada. (Transportadora)
        /// </summary>
        [JsonProperty("estimated_delivery_date_lp")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? EstimatedDeliveryDateLp { get; set; }

        /// <summary>
        /// Estado da pré listade postagem.
        /// </summary>
        [JsonProperty("pre_shipment_list_state")]
        public string PreShipmentListState { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("has_clarify_delivery_fail")]
        public bool HasClarifyDeliveryFail { get; set; }

        /// <summary>
        /// Flag ppara identificar se o volume foi entregue com atraso ou não. (Consumidor)
        /// </summary>
        [JsonProperty("delivered_late")]
        public bool DeliveredLate { get; set; }

        /// <summary>
        /// Flag ppara identificar se o volume foi entregue com atraso ou não. (Transportadora)
        /// </summary>
        [JsonProperty("delivered_late_lp")]
        public bool DeliveredLateLp { get; set; }

        /// <summary>
        /// Flag ppara identificar se o volume foi entregue.
        /// </summary>
        [JsonProperty("delivered")]
        public bool Delivered { get; set; }

        /// <summary>
        /// ID da PLP
        /// </summary>
        [JsonProperty("pre_shipment_list_id")]
        public int? PreShipmentListId { get; set; }

        /// <summary>
        /// 
        /// </summary>
        [JsonProperty("logistic_provider_pre_shipment_list_id")]
        public int? LogisticProviderPreShipmentListId { get; set; }

        /// <summary>
        /// Nome do volume.
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Data de despacho do volume.
        /// </summary>
        [JsonProperty("shipped_date")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? ShippedDate { get; set; }

        /// <summary>
        /// Nome do volume.
        /// </summary>
        [JsonProperty("shipment_order_volume_state_localized")]
        public string ShipmentOrderVolumeStateLocalized { get; set; }

        /// <summary>
        /// Data de despacho do volume.
        /// </summary>
        [JsonProperty("delivered_date")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? DeliveredDate { get; set; }

        /// <summary>
        /// Id do volume.
        /// </summary>
        [JsonProperty("shipment_order_volume_id")]
        public int ShipmentOrderVolumeId { get; set; }

        /// <summary>
        /// Id do volume.
        /// </summary>
        [JsonProperty("shipment_order_volume_state_history_array")]
        public List<ShipmentOrderVolumeStateHistoryArray> ShipmentOrderVolumeStateHistoryArray { get; set; }

        /// <summary>
        /// Código de rastreamento.
        /// </summary>
        [JsonProperty("tracking_code")]
        public string TrackingCode { get; set; }

        /// <summary>
        /// Dados da nota fiscal.
        /// </summary>
        [JsonProperty("shipment_order_volume_invoice")]
        public ShipmentOrderVolumeInvoice ShipmentOrderVolumeInvoice { get; set; }

        public ShipmentOrderVolumeArray()
        {
            ShipmentOrderVolumeInvoice = new ShipmentOrderVolumeInvoice();
            ShipmentOrderVolumeStateHistoryArray = new List<ShipmentOrderVolumeStateHistoryArray>();
        }
        public bool ShouldSerializeModified()
        {
            return (Modified != new DateTime());
        }
        public bool ShouldSerializeCreated()
        {
            return (Created != new DateTime());
        }
        public bool ShouldSerializeShippedDate()
        {
            return (ShippedDate != new DateTime());
        }
        public bool ShouldSerializeDeliveredDate()
        {
            return (DeliveredDate != new DateTime());
        }
        public bool ShouldSerializeShipmentOrderVolumeStateHistoryArray()
        {
            return (ShipmentOrderVolumeStateHistoryArray.Count > 0);
        }
        public bool ShouldSerializeShipmentOrderVolumeInvoice()
        {
            return (ShipmentOrderVolumeInvoice != new ShipmentOrderVolumeInvoice());
        }

    }
}