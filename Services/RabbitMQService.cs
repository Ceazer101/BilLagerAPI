using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Text;
using CarStorageApi.Controllers;
using CarStorageApi.Models;

namespace CarStorageApi.Services
{
    public class RabbitMQService
    {
        private readonly IConnection _connection;
        private readonly IModel _channel;
        private readonly ConnectionFactory _factory;
        private readonly IConfigurationSection _rabbitMQConfig;

        public RabbitMQService(IConfiguration configuration)
        {
            _rabbitMQConfig = configuration.GetSection("RabbitMQ");
            _factory = new ConnectionFactory()
            {
                HostName = _rabbitMQConfig["HostName"],
                UserName = _rabbitMQConfig["UserName"],
                Password = _rabbitMQConfig["Password"]
            };
        }

        public void Publish(List<Car> cars)
        {
            using (var connection = _factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.ExchangeDeclare(_rabbitMQConfig["ExchangeName"], ExchangeType.Fanout);

                foreach (var car in cars)
                {
                    var body = Encoding.UTF8.GetBytes(car.ToString());
                    channel.BasicPublish(exchange: _rabbitMQConfig["ExchangeName"],
                                         routingKey: _rabbitMQConfig["RoutingKey"],
                                         basicProperties: null,
                                         body: body);
                    Console.WriteLine($"Sent: {car}");
                }
            }
        }
    }
}
