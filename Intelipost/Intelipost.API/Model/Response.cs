namespace Intelipost.API.Model
{
    class Response
    {
        public string Status { get; set; }
        public string Messages { get; set; }
        public object Content { get; set; }
        public string Time { get; set; }
    }
}