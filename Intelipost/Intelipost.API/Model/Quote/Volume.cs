using System;
using Intelipost.API.Utilities;
using Newtonsoft.Json;

namespace Intelipost.API.Model
{
    /// <summary>
    /// Entidade respectiva ao volume da encomenda.
    /// </summary>
    public class Volume
    {
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
        /// Peso do volume em gramas.
        /// </summary>
        [JsonProperty("weight")]
        public double Weight { get; set; }

        /// <summary>
        /// Tipo de volume.
        /// </summary>
        [JsonIgnore]
        public VolumeType VolumeType
        {
            get { return (VolumeType)Enum.Parse(typeof(VolumeType), String.Format("{0}{1}", volume_type.Substring(0, 1), volume_type.Substring(1, volume_type.Length - 1).ToLower())); }
            set { volume_type = Enum.GetName(typeof(VolumeType), value).ToUpper(); }
        }

        /// <summary>
        /// Tipo de volume.
        /// </summary>
        [JsonProperty("volume_type")]
        internal string volume_type { get; set; }

        /// <summary>
        /// Preço dos produtos presentes neste volume.
        /// </summary>
        [JsonProperty("cost_of_goods")]
        public double CostOfGoods { get; set; }
    }
}