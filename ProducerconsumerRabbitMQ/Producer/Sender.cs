using RabbitMQ.Client;
using System;
using System.Text;

namespace Producer
{
    class Sender
    {
        //create factory
        //open connection
        //open channel
        //declare the queue
        //create a message
        //publish the message

        public static void Main(string[] args)
        {
            var factory = new ConnectionFactory() { HostName="localhost"};
            using (var connection = factory.CreateConnection())
            using (var channel = connection.CreateModel())
            {
                channel.QueueDeclare("BasicTestVatan", false, false, false, null);

                string message = "Getting started with net core rabbitMQ";
                var body = Encoding.UTF8.GetBytes(message);

                channel.BasicPublish("", "BasicTestVatan", null, body);
                Console.WriteLine("sent message {0}...",message);
            }

            Console.WriteLine("Press enter to exit the sender App...");
            //Console.ReadLine();
        }
    }
}