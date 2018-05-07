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
        /// CEP de origem
        /// </summary>
        [JsonProperty("origin_zip_code")]
        public string OriginZipCode { get; set; }

        /// <summary>
        /// ID da cotação.
        /// </summary>
        [JsonProperty("quote_id")]
        public long? QuoteId { get; set; }

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
        /// Numero do Pedido
        /// </summary>
        [JsonProperty("sales_order_number")]
        public string SalesOrderNumber { get; set; }

        /// <summary>
        /// Canal de vendas
        /// </summary>
        [JsonProperty("sales_channel")]
        public string SalesChannel { get; set; }

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
        /// Nome do depósito/embarcador de origem
        /// </summary>
        [JsonProperty("origin_name")]
        public string OriginName { get; set; }

        /// <summary>
        /// CNPJ ou CPF do deposito/embarcador de origem
        /// </summary>
        [JsonProperty("origin_federal_tax_payer_id")]
        public string OriginFederalTaxPayerId { get; set; }

        /// <summary>
        /// Telefone do embarcador para cenarios de multi remetentes.
        /// </summary>
        [JsonProperty("origin_customer_phone")]
        public string OriginCustomerPhone { get; set; }

        /// <summary>
        /// Email do embarcador para cenarios de multi remetentes.
        /// </summary>
        [JsonProperty("origin_customer_email")]
        public string OriginCustomerEmail { get; set; }

        /// <summary>
        /// Logradouro do deposito/embarcador de origem
        /// </summary>
        [JsonProperty("origin_street")]
        public string OriginStreet { get; set; }

        /// <summary>
        /// Número do deposito/embarcador de origem
        /// </summary>
        [JsonProperty("origin_number")]
        public string OriginNumber { get; set; }

        /// <summary>
        /// Informações adicionais do deposito/embarcador de origem
        /// </summary>
        [JsonProperty("origin_additional")]
        public string OriginAdditional { get; set; }

        /// <summary>
        /// Referencia do deposito/embarcador de origem
        /// </summary>
        [JsonProperty("origin_reference")]
        public string OriginReference { get; set; }

        /// <summary>
        /// Bairro do deposito/embarcador de origem
        /// </summary>
        [JsonProperty("origin_quarter")]
        public string OriginQuarter { get; set; }

        /// <summary>
        /// UF do estado do deposito/embarcador de origem
        /// </summary>
        [JsonProperty("origin_state_code")]
        public string OriginStateCode { get; set; }

        /// <summary>
        /// Código do deposito de origem
        /// </summary>
        [JsonProperty("origin_warehouse_code")]
        public string OriginWarehouseCode { get; set; }

        /// <summary>
        /// Tipo de entrega
        /// </summary>
        [JsonProperty("shipment_order_type")]
        public string ShipmentOrderType { get; set; }

        /// <summary>
        /// Em caso de Logística Reversa, tipo da Reversa. Utilizar "dropoff" em caso de pedido depositado na Agência dos Correios ou "pickup" em caso de coleta em casa.
        /// </summary>
        [JsonProperty("shipment_order_sub_type")]
        public string ShipmentOrderSubType { get; set; }

        /// <summary>
        /// Data estimada de entrega da transportadora
        /// </summary>
        [JsonProperty("estimated_delivery_days_lp")]
        public string EstimatedDeliveryDaysLp { get; set; }

        /// <summary>
        /// Indica se é um re-envio
        /// </summary>
        [JsonProperty("parent_shipment_order_number")]
        public string ParentShipmentOrderNumber { get; set; }

        /// <summary>
        /// Horário inicial da entrega agendada
        /// </summary>
        [JsonProperty("scheduling_window_start")]
        public string SchedulingWindowStart { get; set; }

        /// <summary>
        /// Horário final da entrega agendada
        /// </summary>
        [JsonProperty("scheduling_window_end")]
        public string SchedulingWindowEnd { get; set; }

        /// <summary>
        /// Indica se é uma entrega agendada
        /// </summary>
        [JsonProperty("scheduled")]
        public bool Scheduled { get; set; }

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

        /// <summary>
        /// Informações adicionais do pedido de envio. Este objeto suporta N campos chave => valor
        /// </summary>
        [JsonProperty("additional_information")]
        public Dictionary<string,string> AdditionalInformation { get; set; }

        /// <summary>
        /// Números adicionais para identificação do pedido em integrações
        /// </summary>
        [JsonProperty("external_order_numbers")]
        public Dictionary<string, string> ExternalOrderNumbers { get; set; }

        public ShipmentOrder()
        {
            EndCustomer = new Model.EndCustomer();
            ShipmentOrderVolumeArray = new List<Model.ShipmentOrderVolumeArray>();
            AdditionalInformation = new Dictionary<string, string>();
            ExternalOrderNumbers = new Dictionary<string, string>();
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