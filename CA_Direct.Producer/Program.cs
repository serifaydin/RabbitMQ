using CL_RabbitConnection;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Text;

namespace CA_Direct.Producer
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
                    channel.ExchangeDeclare(CL_ConstModel.ExchangeName, ExchangeType.Direct, true, false, null);

                    //QUEUE CREATED
                    channel.QueueDeclare(CL_ConstModel.queue1Name, true, false, false, null);
                    channel.QueueDeclare(CL_ConstModel.queue2Name, true, false, false, null);
                    channel.QueueBind(CL_ConstModel.queue1Name, CL_ConstModel.ExchangeName, CL_ConstModel.queue1RouteKey);
                    channel.QueueBind(CL_ConstModel.queue2Name, CL_ConstModel.ExchangeName, CL_ConstModel.queue2RouteKey);

                    //QUEUE MESSAGE SEND
                    var publicationAddress = new PublicationAddress(ExchangeType.Direct, CL_ConstModel.ExchangeName, CL_ConstModel.queue1RouteKey);

                    string message = JsonConvert.SerializeObject(UserService.Load());

                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(publicationAddress, null, body);
                }
            }

            Console.WriteLine("Mesaj publish edildi, Direct Exchange' e bağlı Route Key' e göre mesaj iletildi 2999.");
            Console.ReadLine();
        }
    }
}