using Elasticsearch.Net;
using System;

namespace ElastichSearch1
{
    class Program
    {
        public class Customer
        {
          static async System.Threading.Tasks.Task Main(string[] args)
            {
                var setting = new ConnectionConfiguration(new Uri("http://localhost:9200")).RequestTimeout(TimeSpan.FromMinutes(2));

                var client = new ElasticLowLevelClient(setting);
                var car = new car("Ford", 20000);
                var response = await client.IndexAsync<StringResponse>("car", "1", PostData.Serializable(car));
                string responseString = response.Body;
                Console.WriteLine(response);


            }
        }
        
    }
}
