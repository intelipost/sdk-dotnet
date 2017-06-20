using Intelipost.API.Infrastructure.TimestampToDateTime;
using Newtonsoft.Json;
using System.Collections.Generic;

using System;

namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade responsável por pelas requisições de cotação.
    /// </summary>
    public class Quote
    {
        /// <summary>
        /// ID da Ordem de Pedido.
        /// </summary>
        [JsonProperty("id")]
        public long Id { get; set; }

        /// <summary>
        /// ID do cliente.
        /// </summary>
        [JsonProperty("client_id")]
        public int ClientId { get; set; }

        /// <summary>
        /// O CEP de origem da encomenda (CEP de postagem).
        /// </summary>
        [JsonProperty("origin_zip_code")]
        public string OriginZipCode { get; set; }

        /// <summary>
        /// O CEP de destino da encomenda.
        /// </summary>
        [JsonProperty("destination_zip_code")]
        public string DestinationZipCode { get; set; }

        /// <summary>
        /// Data de criação da cotação (UTC).
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Conjunto de volumes desta encomenda.
        /// </summary>
        [JsonProperty("volumes")]
        public List<Volume> Volumes { get; set; }

        /// <summary>
        /// Conjunto de de opções de envio.
        /// </summary>
        [JsonProperty("delivery_options")]
        public List<DeliveryOption> DeliveryOptions { get; set; }

        /// <summary>
        /// Informações adicionais.
        /// </summary>
        [JsonProperty("additional_information")]
        public AddtionalInformation AddtionalInformation { get; set; }

        /// <summary>
        /// Produtos
        /// </summary>
        [JsonProperty("products")]
        public List<Products> Products { get; set; }

        /// <summary>
        /// Produtos
        /// </summary>
        [JsonProperty("identification")]
        public Identification Identification { get; set; }

        public Quote()
        {
            Volumes = new List<Volume>();
            DeliveryOptions = new List<DeliveryOption>();
            AddtionalInformation = new AddtionalInformation();
            Products = new List<Products>();
            Identification = new Identification();
        }

        public bool ShouldSerializeProducts()
        {
            return (Products.Count > 0);
        }
        public bool ShouldSerializeAdditionalInformation()
        {
            return (AddtionalInformation != new AddtionalInformation());
        }
        public bool ShouldSerializeCreated()
        {
            return (Created != new DateTime());
        }
    }
}