using System;

namespace Lab6_KafkaIntegration.Consumer
{
    public class Consumer
    {
        public void ReceiveMessage(string message)
        {
            Console.WriteLine($"Message Received : {message}");
        }
    }
}