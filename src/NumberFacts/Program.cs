using Newtonsoft.Json;
using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace NumberFacts
{
    class Program
    {
        static async Task Main(string[] args)
        {
            string number = Console.ReadLine();

            HttpClient httpClient = new HttpClient();
            HttpResponseMessage response = await httpClient.GetAsync($"http://numbersapi.com/%7Bnumber%7D?json%22");
            string content = await response.Content.ReadAsStringAsync();
            NumberFact fact = JsonConvert.DeserializeObject<NumberFact>(content);

            if (!fact.Found)
            {
                Console.WriteLine("Pick a better number!");
                return;
            }

            Console.WriteLine(fact.Fact);
        }
    }
}