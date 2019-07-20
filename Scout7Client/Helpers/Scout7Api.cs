using System.Net;

namespace Scout7Client.Helpers
{
    public class Scout7Api
    {
        private WebClient client;

        public WebClient InitializeClient()
        {
            client = new WebClient();
            client.Headers["Content-Type"] = "application/json";

            return client;
        }
    }
}
