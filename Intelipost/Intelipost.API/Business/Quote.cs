using System;
using Intelipost.API.Infrastructure.JsonRequest;

namespace Intelipost.API.Business
{
    public class Quote
    {
        public void RequestNewQuote(Model.Request modelRequest)
        {
            if (String.IsNullOrWhiteSpace(Configure.PublicInstance.ApiKey)) throw new Exception("Você precisa configurar sua chave de acesso para utilizar esta API.");

            var url = String.Format("{0}/{1}", Configure.PublicInstance.ApiUrl, "quote");

            var a = new Request().Execute<Model.Request>(url, Configure.PublicInstance.ApiKey, modelRequest);
        }
    }
}
