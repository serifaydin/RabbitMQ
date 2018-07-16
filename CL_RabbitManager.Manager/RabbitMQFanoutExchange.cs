using CL_RabbitManager.Model;
using Newtonsoft.Json;
using RabbitMQ.Client;
using System.Text;

namespace CL_RabbitManager.Manager
{
    public class RabbitMQFanoutExchange
    {
        RabbitModel _model;

        public RabbitMQFanoutExchange(RabbitModel model)
        {
            _model = model;
        }

        public bool RabbitMQFanoutExchangeSend(User user)
        {
            var rabbitMQService = new RabbitMQConnection();

            using (var connection = rabbitMQService.GetRabbitMQConnection(_model.Hostname, _model.Virtualname, _model.Username, _model.Password))
            {
                using (var channel = connection.CreateModel())
                {
                    var publicationAddress = new PublicationAddress(ExchangeType.Fanout, _model.Exchangename, "");

                    string message = JsonConvert.SerializeObject(user);
                    var body = Encoding.UTF8.GetBytes(message);
                    channel.BasicPublish(publicationAddress, null, body);
                }
            }

            return true;
        }

        public bool RabbitMQFanoutExchangeQueueCreate()
        {
            var rabbitMQService = new RabbitMQConnection();

            using (var connection = rabbitMQService.GetRabbitMQConnection(_model.Hostname, _model.Virtualname, _model.Username, _model.Password))
            {
                using (var channel = connection.CreateModel())
                {
                    channel.ExchangeDeclare(_model.Exchangename, ExchangeType.Fanout, true, false, null);

                    channel.QueueDeclare(_model.Queuename, true, false, false, null);

                    channel.QueueBind(_model.Queuename, _model.Exchangename, "");
                }
            }

            return true;
        }
    }
}