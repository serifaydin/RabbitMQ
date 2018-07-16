using CL_RabbitManager.Model;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace CL_RabbitManager.Manager
{
    public class RabbitMQDirectExchange
    {

        RabbitModel _model;

        public RabbitMQDirectExchange(RabbitModel model)
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
                    var publicationAddress = new PublicationAddress(ExchangeType.Direct, _model.Exchangename, _model.Routekey);

                    string message = JsonConvert.SerializeObject(user);
                    var body = Encoding.UTF8.GetBytes(message);
                    channel.BasicPublish(publicationAddress, null, body);
                }
            }

            return true;
        }

        public bool RabbitMQDirectExchangeQueueSet()
        {
            var rabbitMQService = new RabbitMQConnection();

            using (var connection = rabbitMQService.GetRabbitMQConnection(_model.Hostname, _model.Virtualname, _model.Username, _model.Password))
            {
                using (var channel = connection.CreateModel())
                {
                    channel.ExchangeDeclare(_model.Exchangename, ExchangeType.Direct, true, false, null);
                    channel.QueueDeclare(_model.Queuename, true, false, false, null);
                    channel.QueueBind(_model.Queuename, _model.Exchangename, _model.Routekey);
                }
            }

            return true;
        }
    }
}