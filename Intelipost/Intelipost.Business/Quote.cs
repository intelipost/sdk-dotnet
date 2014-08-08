using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using Intelipost.Infrastructure.JsonRequest;

namespace Intelipost.Business
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
