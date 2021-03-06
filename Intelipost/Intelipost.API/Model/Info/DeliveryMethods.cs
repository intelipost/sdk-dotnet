﻿using Newtonsoft.Json;
using System.Collections.Generic;

namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade responsável por alterar o status do pedido para "Pronto Para Envio"
    /// </summary>
    public class DeliveryMethods
    { 
        /// <summary>
        /// ID do método de envio
        /// </summary>
        [JsonProperty("id")]
        public int? Id { get; set; }

        /// <summary>
        /// Nome do método de envio
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }

        /// <summary>
        /// Código de serviço
        /// </summary>
        [JsonProperty("service_code")]
        public string ServiceCode { get; set; }

        /// <summary>
        /// Nome da transportadora.
        /// </summary>
        [JsonProperty("logistics_provider_name")]
        public string LogisticProviderName { get; set; }

        /// <summary>
        /// Id da taxa da transportadora
        /// </summary>
        [JsonProperty("logistics_provider_tax_id")]
        public string LogisticsProviderTaxId { get; set; }

        /// <summary>
        /// Código da Transportadora
        /// </summary>
        [JsonProperty("logistics_provider_code")]
        public string LogisticsProviderCode { get; set; }

        /// <summary>
        /// ID da Transportadora
        /// </summary>
        [JsonProperty("logistics_provider_id")]
        public int LogisticsProviderId { get; set; }

        /// <summary>
        /// Código de Licença Transportadora
        /// </summary>
        [JsonProperty("logistics_provider_license_code")]
        public string LogisticsProviderLicenseCode { get; set; }
    }
}