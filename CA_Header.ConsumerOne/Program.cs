﻿using CL_RabbitConnection;
using Newtonsoft.Json;
using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;

namespace CA_Header.ConsumerOne
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Header Consumer 1");
            var rabbitMQService = new RabbitMQService();

            using (var connection = rabbitMQService.GetRabbitMQConnection())
            {
                using (var channel = connection.CreateModel())
                {
                    var consumer = new EventingBasicConsumer(channel);

                    consumer.Received += (model, ea) =>
                    {
                        var body = ea.Body;
                        var message = Encoding.UTF8.GetString(body);
                        User user = JsonConvert.DeserializeObject<User>(message);

                        Console.WriteLine("Queue1 üzerinden mesaj alındı: {0} , {1} , {2}", user.Id, user.Name, user.Surname);
                    };

                    channel.BasicConsume(CL_ConstModel.queue1Name, false, consumer);
                    Console.ReadLine();
                }
            }
        }
    }
}