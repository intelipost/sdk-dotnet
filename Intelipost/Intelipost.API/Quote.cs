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