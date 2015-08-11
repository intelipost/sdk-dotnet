using System;
using Intelipost.API.Utilities;
using Newtonsoft.Json;

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
        public int ShipmentOrderVolumeNumber { get; set; }

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
        /// Código de rastreamento.
        /// </summary>
        [JsonProperty("tracking_code")]
        public string trackingCode { get; set; }

        /// <summary>
        /// Comprimento da caixa (não é necessária para volumes do tipo ENVELOPE).
        /// </summary>
        [JsonProperty("volume_type_code")]
        public string VolumeTypeCode { get; set; }

        /// <summary>
        /// Dados da nota fiscal.
        /// </summary>
        [JsonProperty("shipment_order_volume_invoice")]
        public ShipmentOrderVolumeInvoice ShipmentOrderVolumeInvoice { get; set; }

        public ShipmentOrderVolumeArray()
        {
            ShipmentOrderVolumeInvoice = new ShipmentOrderVolumeInvoice();
        }
        
        
    }
}