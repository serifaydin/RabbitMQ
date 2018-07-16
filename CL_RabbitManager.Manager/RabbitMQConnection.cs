using RabbitMQ.Client;

namespace CL_RabbitManager.Manager
{
    public class RabbitMQConnection
    {
        public IConnection GetRabbitMQConnection(string hostname, string virtualname, string username, string password)
        {
            ConnectionFactory connectionFactory = new ConnectionFactory()
            {
                HostName = hostname,
                UserName = username,
                Password = password,
                VirtualHost = virtualname
            };

            return connectionFactory.CreateConnection();
        }
    }
}