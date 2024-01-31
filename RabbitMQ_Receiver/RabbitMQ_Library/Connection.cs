using RabbitMQ.Client.Events;
using RabbitMQ.Client;
using System.Text;

namespace RabbitMQ_Library
{
    public class Connection
    {
        /// <summary>
        /// Connection Method to the RabbitMQ server
        /// </summary>
        public static void RabbitMQConnection()
        {
            try
            {
                var host = new ConnectionFactory
                {
                    //default settings
                    Uri = new Uri("amqp://guest:guest@localhost:5672")
                };

                //Create the connection and model
                using var connection = host.CreateConnection();
                using var channel = connection.CreateModel();

                channel.QueueDeclare("message-queue", durable: true, exclusive: false, autoDelete: false, arguments: null);

                var consumer = new EventingBasicConsumer(channel);

                ValidationClass validation = new ValidationClass();

                consumer.Received += (sender, e) =>
                {
                    var body = e.Body.ToArray();
                    var name = Encoding.UTF8.GetString(body);

                    //Validates the message to get the name
                    var rname = validation.ValidateMessage(name);

                    //Displays the Required Message
                    Console.WriteLine("Hello " + rname + ", I am your Father!");
                };

                channel.BasicConsume("message-queue", true, consumer);
                Console.ReadLine();
            }

            //Handling exceptions and displaying an error message
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
            }
        }

    }
}
//-------------------------------------End OF File------------------------------------------//
