using System;
using Dapr.Client;
using System.Net.Http;

namespace configure
{
    class Program
    {
        private static readonly string CONFIG_STORE_NAME = "azureconfig"; //"configstore";

        [Obsolete]
        //[Obsolete("Configuration API is an Alpha API. Obsolete will be removed when the API is no longer Alpha")]
        public static async Task Main(string[] args)
        {
            using var client = new DaprClientBuilder().Build();
            
            var configuration = await client.GetConfiguration(CONFIG_STORE_NAME, new List<string>() { "orderId1", "orderId2" });
            //Console.WriteLine($"Got key=\n{configuration[0].Key} -> {configuration[0].Value}\n{configuration[1].Key} -> {configuration[1].Value}");
            Console.WriteLine($"Got key=\n Success"); //{configuration}");
        }
    }
}
