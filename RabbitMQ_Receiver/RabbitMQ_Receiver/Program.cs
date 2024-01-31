using RabbitMQ.Client;
using RabbitMQ.Client.Events;
using System;
using System.Text;
using RabbitMQ_Library;

namespace RabbitMQ_Sender
{
    static class Program
    {
        static void Main(string[] args)
        {
            Connection.RabbitMQConnection();
        }
    }
}
//-------------------------------------End OF File------------------------------------------//