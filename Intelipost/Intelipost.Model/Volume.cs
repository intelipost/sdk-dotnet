using Intelipost.Util.Enum;

namespace Intelipost.Model
{
    /// <summary>
    /// Entidade respectiva ao volume da encomenda.
    /// </summary>
    public class Volume
    {
        /// <summary>
        /// Largura da caixa ou envelope.
        /// </summary>
        public double Width { get; set; }
        /// <summary>
        /// Altura da caixa ou envelope.
        /// </summary>
        public double Height { get; set; }
        /// <summary>
        /// Comprimento da caixa (não é necessária para volumes do tipo ENVELOPE).
        /// </summary>
        public double Length { get; set; }
        /// <summary>
        /// Peso do volume em gramas.
        /// </summary>
        public double Weight { get; set; }
        /// <summary>
        /// Tipo de volume.
        /// </summary>
        public VolumeType VolumeType { get; set; }
        /// <summary>
        /// Preço dos produtos presentes neste volume.
        /// </summary>
        public double CostOfGoods { get; set; }
    }
}