using CL_RabbitManager.Model;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace CL_RabbitManager.Manager
{
    public class RabbitMQTopicExchange
    {
        RabbitModel _model;

        public RabbitMQTopicExchange(RabbitModel model)
        {
            _model = model;
        }

        public bool RabbitMQTopicExchangeSend(User user)
        {
            var rabbitMQService = new RabbitMQConnection();

            using (var connection = rabbitMQService.GetRabbitMQConnection(_model.Hostname, _model.Virtualname, _model.Username, _model.Password))
            {
                using (var channel = connection.CreateModel())
                {
                    var publicationAddress = new PublicationAddress(ExchangeType.Headers, _model.Exchangename, _model.Routekey);

                    string message = JsonConvert.SerializeObject(user);

                    var body = Encoding.UTF8.GetBytes(message);

                    channel.BasicPublish(publicationAddress, null, body);
                }
            }

            return true;
        }

        public bool RabbitMQTopicExchangeQueueCraete()
        {
            var rabbitMQService = new RabbitMQConnection();

            using (var connection = rabbitMQService.GetRabbitMQConnection(_model.Hostname, _model.Virtualname, _model.Username, _model.Password))
            {
                using (var channel = connection.CreateModel())
                {
                    channel.ExchangeDeclare(_model.Exchangename, ExchangeType.Topic, true, false, null);

                    channel.QueueDeclare(_model.Queuename, true, false, false, null);

                    channel.QueueBind(_model.Queuename, _model.Exchangename, _model.Routekey);
                }
            }

            return true;
        }
    }
}