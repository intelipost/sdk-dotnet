using System;
using Intelipost.API.Utilities;
using Newtonsoft.Json;

namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade respectiva ao volume da encomenda.
    /// </summary>
    public class Products
    {
        /// <summary>
        /// Peso do volume em gramas.
        /// </summary>
        [JsonProperty("weight")]
        public double Weight { get; set; }

        /// <summary>
        /// Preço dos produtos presentes neste volume.
        /// </summary>
        [JsonProperty("cost_of_goods")]
        public double CostOfGoods { get; set; }

        /// <summary>
        /// Largura da caixa ou envelope.
        /// </summary>
        [JsonProperty("width")]
        public double Width { get; set; }

        /// <summary>
        /// Altura da caixa ou envelope.
        /// </summary>
        [JsonProperty("height")]
        public double Height { get; set; }

        /// <summary>
        /// Comprimento da caixa (não é necessária para volumes do tipo ENVELOPE).
        /// </summary>
        [JsonProperty("length")]
        public double Length { get; set; }   

        /// <summary>
        /// Quantidade de volumes.
        /// </summary>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// ID do SKU.
        /// </summary>
        [JsonProperty("sku_id")]
        public string SkuId { get; set; }

        /// <summary>
        /// Descrição do produto.
        /// </summary>
        [JsonProperty("description")]
        public string description { get; set; }

        /// <summary>
        /// Flag para identificar se o produto pode ser agrupado ou não.
        /// </summary>
        [JsonProperty("can_group")]
        public bool CanGroup { get; set; }

        /// <summary>
        /// Categoria do produto.
        /// </summary>
        [JsonProperty("product_category")]
        public string ProductCategory { get; set; }

    }
}