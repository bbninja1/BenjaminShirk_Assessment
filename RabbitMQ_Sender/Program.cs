using Newtonsoft.Json;
using RabbitMQ.Client;
using System;
using System.Text;
using System.Text.Json.Serialization;
using RabbitMQ_Library;


namespace RabbitMQ_Sender
{
    static class Program
    {
        static void Main(string[] args)
        {
            var worker = new WorkerClass();
            worker.ProcessName();
        }
    }
}
//-------------------------------------End OF File------------------------------------------//
