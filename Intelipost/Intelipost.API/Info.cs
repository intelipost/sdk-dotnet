﻿using Intelipost.API.Model;

namespace Intelipost.API
{
    /// <summary>
    /// Classe destinada a expor os métodos de envio ativos para o cliente.
    /// </summary>
    public class Info
    {
        /// <summary>
        /// Retorna os métodos de envio ativos para o cliente.
        /// </summary>
        /// <returns>Retorna os métodos de envio ativos para o cliente.</returns>
        public Response<Model.Info> RequestInfo()
        {
            return new Business.Info().RequestInfo();
        }
    }
}