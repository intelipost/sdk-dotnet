﻿using System;
using Intelipost.API.Utilities;
using Newtonsoft.Json;
using Intelipost.API.Model;
using Intelipost.API.Infrastructure;
using Intelipost.API.Infrastructure.TimestampToDateTime;
using System.Collections.Generic;

namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade respectiva ao volume da encomenda.
    /// </summary>
    public class History
    {
        /// <summary>
        /// Data de criação do Volume (UTC)
        /// </summary>
        [JsonProperty("created")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? Created { get; set; }

        /// <summary>
        /// Data do evento. (UTC)
        /// </summary>
        [JsonProperty("event_date")]
        [JsonConverter(typeof(TimestampToDateTime))]
        public DateTime? EventDate { get; set; }

        /// <summary>
        /// Mensagem da transportadora.
        /// </summary>
        [JsonProperty("provider_message")]
        public string ProviderMessage { get; set; }

        /// <summary>
        /// Estado do volume para a transportadora.
        /// </summary>
        [JsonProperty("provider_state")]
        public string ProviderState { get; set; }

        /// <summary>
        /// Id do volume.
        /// </summary>
        [JsonProperty("shipment_order_volume_id")]
        public int ShipmentOrderVolumeId { get; set; }

        /// <summary>
        /// Estado do volume.
        /// </summary>
        [JsonProperty("shipment_order_volume_state")]
        public string ShipmentOrderVolumeState { get; set; }

        /// <summary>
        /// ID do history.
        /// </summary>
        [JsonProperty("shipment_order_volume_state_history")]
        public int ShipmentOrderVolumeStateHistory { get; set; }        

        /// <summary>
        /// Estado atual do volume.
        /// </summary>
        [JsonProperty("shipment_order_volume_state_localized")]
        public string ShipmentOrderVolumeStateLocalized { get; set; }
        
        /// <summary>
        /// Status do rastreamento
        /// </summary>
        [JsonProperty("tracking_state")]
        public string TrackingState { get; set; }

        /// <summary>
        /// Mensagem traduzida no modelo Intelipost
        /// </summary>
        [JsonProperty("esprinter_message")]
        public string EsprinterMessage { get; set; }

        /// <summary>
        /// Micro status do volume do pedido de envio
        /// </summary>
        [JsonProperty("shipment_volume_micro_state")]
        public ShipmentOrderVolumeMicroState ShipmentVolumeMicroState { get; set; }

        /// <summary>
        /// Dados dos anexos
        /// </summary>
        public List<Attachments> Attachments { get; set; }

        public History()
        {
            ShipmentVolumeMicroState = new ShipmentOrderVolumeMicroState();
            Attachments = new List<Attachments>();
        }
    }
}