using CL_RabbitConnection;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Collections.Generic;
using System.Text;

namespace CA_Header.Producer
{
    class Program
    {
        static void Main(string[] args)
        {
            var rabbitMQService = new RabbitMQService();

            using (var connection = rabbitMQService.GetRabbitMQConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    channel.ExchangeDeclare(CL_ConstModel.ExchangeName, ExchangeType.Headers, true, false, null);
                    channel.QueueDeclare(CL_ConstModel.queue1Name, true, false, false, null);

                    Dictionary<string, object> headerOptionsWithAll = new Dictionary<string, object>();
                    headerOptionsWithAll.Add("x-match", "all");
                    headerOptionsWithAll.Add("category", "animal");
                    headerOptionsWithAll.Add("type", "mammal");
                    channel.QueueBind(CL_ConstModel.queue1Name, CL_ConstModel.ExchangeName, "", headerOptionsWithAll);

                    //Dictionary<string, object> headerOptionsWithAny = new Dictionary<string, object>();
                    //headerOptionsWithAny.Add("x-match", "any");
                    //headerOptionsWithAny.Add("category", "plant");
                    //headerOptionsWithAny.Add("type", "tree");
                    //channel.QueueBind(CL_ConstModel.queue1Name, CL_ConstModel.ExchangeName, "", headerOptionsWithAny);

                    Dictionary<string, object> messageHeaders = new Dictionary<string, object>();

                    IBasicProperties properties = channel.CreateBasicProperties();
                    messageHeaders = new Dictionary<string, object>();
                    messageHeaders.Add("category", "animal");
                    messageHeaders.Add("type", "mammal");
                    messageHeaders.Add("x-match", "all");
                    properties.Headers = messageHeaders;

                    var publicationAddress = new PublicationAddress(ExchangeType.Headers, CL_ConstModel.ExchangeName, "");
                    string message = JsonConvert.SerializeObject(UserService.Load());
                    var body = Encoding.UTF8.GetBytes(message);
                    channel.BasicPublish(publicationAddress, properties, body);
                }
            }

            Console.ReadKey();
        }
    }
}