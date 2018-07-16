using CL_RabbitConnection;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Text;

namespace CA_Topic.Producer
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
                    channel.ExchangeDeclare(CL_ConstModel.ExchangeName, ExchangeType.Topic, true, false, null);

                    channel.QueueDeclare(CL_ConstModel.queue1Name, true, false, false, null);
                    channel.QueueDeclare(CL_ConstModel.queue2Name, true, false, false, null);

                    channel.QueueBind(CL_ConstModel.queue1Name, CL_ConstModel.ExchangeName, "*.bmw");
                    channel.QueueBind(CL_ConstModel.queue1Name, CL_ConstModel.ExchangeName, "serif.*");

                    channel.QueueBind(CL_ConstModel.queue2Name, CL_ConstModel.ExchangeName, "merc.*");

                    var publicationAddress = new PublicationAddress(ExchangeType.Headers, CL_ConstModel.ExchangeName, "merc");

                    string message = JsonConvert.SerializeObject(UserService.Load());

                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(publicationAddress, null, body);
                }
            }

            Console.WriteLine("Mesaj publish edildi, Topic Exchange' e bağlı tüm Route Key lere mesaj iletildi.");
            Console.ReadLine();
        }
    }
}