using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade respectiva ao micro status do pedido
    /// </summary>
    public class ShipmentOrderVolumeMicroState
    {
        /// <summary>
        /// ID do micro status
        /// </summary>
        [JsonProperty("id")]
        public int Id { get; set; }

        /// <summary>
        /// Código do micro status
        /// </summary>
        [JsonProperty("code")]
        public int Code { get; set; }

        /// <summary>
        /// Descrição padrão do micro status
        /// </summary>
        [JsonProperty("default_name")]
        public string DefaultName { get; set; }

        /// <summary>
        /// Descrição multilanguage do micro status
        /// </summary>
        [JsonProperty("i18n_name")]
        public string I18nName { get; set; }

        /// <summary>
        /// Descrição completa do micro status
        /// </summary>
        [JsonProperty("description")]
        public string Description { get; set; }

        /// <summary>
        /// ID do estado do volume do pedido
        /// </summary>
        [JsonProperty("shipment_order_volume_state_id")]
        public int ShipmentOrderVolumeStateId { get; set; }

        /// <summary>
        /// ID da fonte do volume
        /// </summary>
        [JsonProperty("shipment_volume_state_source_id")]
        public int ShipmentOrderVolumeStateSourceId { get; set; }

        /// <summary>
        /// Descrição para quando volume localizado
        /// </summary>
        [JsonProperty("shipment_volume_state_localized")]
        public string ShipmentOrderVolumeStateLocalized { get; set; }

        /// <summary>
        /// Descrição do estado do volume
        /// </summary>
        [JsonProperty("shipment_volume_state")]
        public string ShipmentVolumeState { get; set; }

        /// <summary>
        /// Nome do micro status
        /// </summary>
        [JsonProperty("name")]
        public string Name { get; set; }
    }
}
