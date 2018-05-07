using System;
using Intelipost.API.Utilities;
using Newtonsoft.Json;
using Intelipost.API.Infrastructure.TimestampToDateTime;

namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade respectiva ao volume da encomenda.
    /// </summary>
    public class ShipmentOrderVolumeStateHistoryArray
    {
        /// <summary>
        /// Id do volume.
        /// </summary>
        [JsonProperty("shipment_order_volume_id")]
        public int? ShipmentOrderVolumeId { get; set; }

        /// <summary>
        /// Estado do volume.
        /// </summary>
        [JsonProperty("shipment_order_volume_state")]
        public string ShipmentOrderVolumeState { get; set; }

        /// <summary>
        /// Data de criação do volume.
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Mensagem da transportadora.
        /// </summary>
        [JsonProperty("provider_message")]
        public string ProviderMessage { get; set; }

        /// <summary>
        /// Estado do volume (transportadora).
        /// </summary>
        [JsonProperty("provider_state")]
        public string ProviderState { get; set; }

        /// <summary>
        /// Mensagem do esprinter.
        /// </summary>
        [JsonProperty("esprinter_message")]
        public string EsprinterMessage { get; set; }

        /// <summary>
        /// Estado do volume.
        /// </summary>
        [JsonProperty("shipment_order_volume_state_localized")]
        public string ShipmentOrderVolumeStateLocalized { get; set; }

        /// <summary>
        /// Estado do volume (transportadora).
        /// </summary>
        [JsonProperty("shipment_order_volume_state_history")]
        public int? ShipmentOrderVolumeStateHistory { get; set; }

        /// <summary>
        /// Data do evento.
        /// </summary>
        [JsonProperty("event_date")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? EventDate { get; set; }

        /// <summary>
        /// Descrição do micro status de rastreamento
        /// </summary>
        [JsonProperty("shipment_volume_micro_state")]
        public ShipmentOrderVolumeMicroState ShipmentVolumeMicroState { get; set; }

        public ShipmentOrderVolumeStateHistoryArray()
        {
            ShipmentVolumeMicroState = new Model.ShipmentOrderVolumeMicroState();
        }
    }
}