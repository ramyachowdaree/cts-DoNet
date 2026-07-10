using System;
using Lab6_KafkaIntegration.Producer;
using Lab6_KafkaIntegration.Consumer;

namespace Lab6_KafkaIntegration
{
    class Program
    {
        static void Main(string[] args)
        {
            Producer producer = new Producer();
            Consumer consumer = new Consumer();

            string message = "Hello Kafka";

            producer.SendMessage(message);

            consumer.ReceiveMessage(message);
        }
    }
}