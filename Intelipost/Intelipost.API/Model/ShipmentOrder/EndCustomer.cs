using System;
using Intelipost.API.Utilities;
using Newtonsoft.Json;

namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade respectiva ao volume da encomenda.
    /// </summary>
    public class EndCustomer
    {
        /// <summary>
        /// Primeiro nome.
        /// </summary>
        [JsonProperty("first_name")]
        public string FirstName { get; set; }

        /// <summary>
        /// Ultimo nome.
        /// </summary>
        [JsonProperty("last_name")]
        public string LastName { get; set; }

        /// <summary>
        /// Email.
        /// </summary>
        [JsonProperty("email")]
        public string Email { get; set; }

        /// <summary>
        /// Telefone.
        /// </summary>
        [JsonProperty("phone")]
        public string Phone { get; set; }

        /// <summary>
        /// Celular.
        /// </summary>
        [JsonProperty("cellphone")]
        public string Cellphone { get; set; }

        /// <summary>
        /// Flag para identificar se o cliente final é uma empresa ou não.
        /// </summary>
        [JsonProperty("is_company")]
        public bool IsCompany { get; set; }

        /// <summary>
        /// Altura da caixa ou envelope.
        /// </summary>
        [JsonProperty("federal_tax_payer_id")]
        public string FederalTaxPayerId { get; set; }

        /// <summary>
        /// Altura da caixa ou envelope.
        /// </summary>
        [JsonProperty("state_tax_payer_id")]
        public string StateTaxPayerId { get; set; }

        
        /// <summary>
        /// Endereço de entrega.
        /// </summary>
        [JsonProperty("shipping_address")]
        public string ShippingAddress { get; set; }

        /// <summary>
        /// Numero do endereço de entrega.
        /// </summary>
        [JsonProperty("shipping_number")]
        public string ShippingNumber { get; set; }


        /// <summary>
        /// Informações adicionais.
        /// </summary>
        [JsonProperty("shipping_additional")]
        public string ShippingAdditional { get; set; }

        /// <summary>
        /// Ponto de referencia.
        /// </summary>
        [JsonProperty("shipping_reference")]
        public string ShippingReference { get; set; }

        /// <summary>
        /// Comprimento da caixa (não é necessária para volumes do tipo ENVELOPE).
        /// </summary>
        [JsonProperty("shipping_quarter")]
        public string ShippingQuarter { get; set; }

        /// <summary>
        /// Cidade de entrega.
        /// </summary>
        [JsonProperty("shipping_city")]
        public string ShippingCity { get; set; }

        /// <summary>
        /// Estado de entrega.
        /// </summary>
        [JsonProperty("shipping_state")]
        public string ShippingState { get; set; }

        /// <summary>
        /// CEP de entrega.
        /// </summary>
        [JsonProperty("shipping_zip_code")]
        public string ShippingZipCode { get; set; }

        /// <summary>
        /// Pais de entrega.
        /// </summary>
        [JsonProperty("shipping_country")]
        public string ShippingCountry { get; set; }
        
    }
}