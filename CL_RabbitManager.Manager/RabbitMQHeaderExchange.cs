using CL_RabbitManager.Model;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace CL_RabbitManager.Manager
{
    public class RabbitMQHeaderExchange
    {
        RabbitModel _model;

        public RabbitMQHeaderExchange(RabbitModel model)
        {
            _model = model;
        }

        public bool RabbitMQDirectExchangeSend(User user)
        {
            var rabbitMQService = new RabbitMQConnection();

            using (var connection = rabbitMQService.GetRabbitMQConnection(_model.Hostname, _model.Virtualname, _model.Username, _model.Password))
            {
                using (var channel = connection.CreateModel())
                {
                    IBasicProperties properties = channel.CreateBasicProperties();

                    properties.Headers = _model.HeaderEchangeOptions;

                    var publicationAddress = new PublicationAddress(ExchangeType.Headers, _model.Exchangename, "");
                    string message = JsonConvert.SerializeObject(user);
                    var body = Encoding.UTF8.GetBytes(message);
                    channel.BasicPublish(publicationAddress, properties, body);
                }
            }

            return true;
        }

        public bool RabbitMQDirectExchangeQueueCreate()
        {
            var rabbitMQService = new RabbitMQConnection();

            using (var connection = rabbitMQService.GetRabbitMQConnection(_model.Hostname, _model.Virtualname, _model.Username, _model.Password))
            {
                using (var channel = connection.CreateModel())
                {
                    channel.ExchangeDeclare(_model.Exchangename, ExchangeType.Headers, true, false, null);
                    channel.QueueDeclare(_model.Queuename, true, false, false, null);
                    channel.QueueBind(_model.Queuename, _model.Exchangename, "", _model.HeaderEchangeOptions);
                }
            }

            return true;
        }
    }
}