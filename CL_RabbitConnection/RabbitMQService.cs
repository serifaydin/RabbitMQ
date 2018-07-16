using RabbitMQ.Client;

namespace CL_RabbitConnection
{
    public class RabbitMQService
    {
        private readonly string _hostName = "localhost";
        private readonly string _name = "admin";
        private readonly string _password = "admin";

        public IConnection GetRabbitMQConnection()
        {
            ConnectionFactory connectionFactory = new ConnectionFactory()
            {
                HostName = _hostName,
                UserName = _name,
                Password = _password,
                VirtualHost = "serifHost"
            };

            return connectionFactory.CreateConnection();
        }
    }
}