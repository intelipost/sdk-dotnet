using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Intelipost.API
{
    public class Quote
    {
        public void Request(Model.Request modelRequest)
        {
            new Business.Quote().RequestNewQuote(modelRequest);
        }
    }
}
