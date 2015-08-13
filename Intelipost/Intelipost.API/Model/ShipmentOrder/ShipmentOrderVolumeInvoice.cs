using System;
using Intelipost.API.Utilities;
using Newtonsoft.Json;
using Intelipost.API.Infrastructure.TimestampToDateTime;

namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade respectiva ao volume da encomenda.
    /// </summary>
    public class ShipmentOrderVolumeInvoice
    {
        /// <summary>
        /// Numero do volume.
        /// </summary>
        [JsonProperty("shipment_order_volume_number")]
        public string ShipmentOrderVolumeNumber { get; set; }

        /// <summary>
        /// ID do volume.
        /// </summary>
        [JsonProperty("shipment_order_volume_id")]
        public int ShipmentOrderVolumeId { get; set; }

        /// <summary>
        /// Serie da nota fiscal.
        /// </summary>
        [JsonProperty("invoice_series")]
        public string InvoiceSeries { get; set; }

        /// <summary>
        /// Numero da nota fiscal.
        /// </summary>
        [JsonProperty("invoice_number")]
        public string InvoiveNumber { get; set; }

        /// <summary>
        /// Chave.
        /// </summary>
        [JsonProperty("invoice_key")]
        public string InvoiceKey { get; set; }

        /// <summary>
        /// Data da nota fiscal.
        /// </summary>
        [JsonProperty("invoice_date")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? InvoiceDate { get; set; }


        /// <summary>
        /// Valor total da nota fiscal.
        /// </summary>
        [JsonProperty("invoice_total_value")]
        public string InvoiceTotalValue { get; set; }

        /// <summary>
        /// Valor do produto.
        /// </summary>
        [JsonProperty("invoice_products_value")]
        public string InvoiceProductsValue { get; set; }

        /// <summary>
        /// CFOP
        /// </summary>
        [JsonProperty("invoice_cfop")]
        public string InvoiceCfop { get; set; }

        public bool ShouldSerializeInvoiceDate()
        {
            return (InvoiceDate != new DateTime());
        }
    }
}