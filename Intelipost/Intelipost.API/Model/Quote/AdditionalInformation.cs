using System;
using Intelipost.API.Utilities;
using Newtonsoft.Json;

namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade respectiva ao volume da encomenda.
    /// </summary>
    public class AddtionalInformation
    {
        /// <summary>
        /// Flag para determinar se haverá frete grátis ou não.
        /// </summary>
        [JsonProperty("free_shipping")]
        public bool FreeShipping { get; set; }

        /// <summary>
        /// Custo extra.
        /// </summary>
        [JsonProperty("extra_costs_absolute")]
        public double ExtraCostsAbsolute { get; set; }

        /// <summary>
        /// Custo extra(%)
        /// </summary>
        [JsonProperty("extra_costs_percentage")]
        public double ExtraCostsPercentage { get; set; }

        /// <summary>
        /// Prazo adicional em dias uteis.
        /// </summary>
        [JsonProperty("lead_time_bussiness_days")]
        public int LeadTimeBussinessDays { get; set; }

        /// <summary>
        /// Metodos de envio a serem apresentados.
        /// </summary>
        [JsonProperty("delivery_method_ids")]
        public int[] DeliveryMethodIds { get; set; }

        /// <summary>
        /// CPF/CNPJ
        /// </summary>
        [JsonProperty("tax_id")]
        public string TaxID { get; set; }

        /// <summary>
        /// Tipo do cliente.
        /// </summary>
        [JsonProperty("client_type")]
        public string ClientType { get; set; }

        /// <summary>
        /// Canal de vendas.
        /// </summary>
        [JsonProperty("sales_channel")]
        public string SalesChannel { get; set; }
    }
}