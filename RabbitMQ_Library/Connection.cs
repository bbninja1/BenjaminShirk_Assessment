using System.Text;
using System.Xml.Linq;
using RabbitMQ.Client;
using Newtonsoft.Json;

namespace RabbitMQ_Library
{
    public class Connection
    {
        /// <summary>
        /// Connection Method to the RabbitMQ server
        /// </summary>
        /// <param name="name"></param>
        public static void RabbitMQConnection(string name)
        {
            try
            {
                var Conn = new ConnectionFactory
                {
                    //default settings
                    Uri = new Uri("amqp://guest:guest@localhost:5672")
                };

                //Create the connection and model
                using var connection = Conn.CreateConnection();
                using var channel = connection.CreateModel();

                channel.QueueDeclare("message-queue", durable: true, exclusive: false, autoDelete: false, arguments: null);

                //sets the message to the required format
                string Message = "Hello my name is, " + name;

                var body = Encoding.UTF8.GetBytes(JsonConvert.SerializeObject(Message));

                //publishes the message to the queue
                channel.BasicPublish("", "message-queue", null, body);
                //confirmation of the message sent to the queue
                Console.WriteLine("The Message: " + Message + ". has been sent to the queue");
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error occurred: {ex.Message}");
            }
        }
    }

}
//-------------------------------------End OF File------------------------------------------//
