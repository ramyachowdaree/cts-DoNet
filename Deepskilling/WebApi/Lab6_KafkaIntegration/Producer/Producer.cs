using System;

namespace Lab6_KafkaIntegration.Producer
{
    public class Producer
    {
        public void SendMessage(string message)
        {
            Console.WriteLine($"Message Sent : {message}");
        }
    }
}