using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureServiceBusTestReciever
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Endpoint=sb://deepgautam.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=JBNZc6zh8GA7tmC/XJvD2Av55rhdorxKDDKaki8wbjs=";
            var queueName = "queuedeeptest";

            var client = QueueClient.CreateFromConnectionString(connectionString, queueName);

            client.OnMessage(message =>
            {
                Console.WriteLine(String.Format("Message body: {0}", message.GetBody<String>()));
                Console.WriteLine(String.Format("Message id: {0}", message.MessageId));
            });

            Console.ReadLine();
        }
    }
}
