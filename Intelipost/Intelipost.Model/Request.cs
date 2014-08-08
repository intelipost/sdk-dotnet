using System.Collections.Generic;

namespace Intelipost.Model
{
    /// <summary>
    /// Entidade responsável por qualquer requisição feita.
    /// </summary>
    public class Request
    {
        /// <summary>
        /// O CEP de origem da encomenda (CEP de postagem).
        /// </summary>
        public string OriginZipCode { get; set; }
        /// <summary>
        /// O CEP de destino da encomenda.
        /// </summary>
        public string DestinationZipCode { get; set; }
        /// <summary>
        /// Conjunto de volumes desta encomenda.
        /// </summary>
        public List<Volume> Volumes { get; set; }

        public Request()
        {
            this.Volumes = new List<Volume>();
        }
    }
}