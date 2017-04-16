using Microsoft.ServiceBus.Messaging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureServiceBusTestApp
{
    class Program
    {
        static void Main(string[] args)
        {
            var connectionString = "Endpoint=sb://deepgautam.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=JBNZc6zh8GA7tmC/XJvD2Av55rhdorxKDDKaki8wbjs=";
            var queueName = "queuedeeptest";

            var client = QueueClient.CreateFromConnectionString(connectionString, queueName);
            var message = new BrokeredMessage("Azure Service Bus Message -6-From Deep GAUTAM-!Another sent from his home laptop dated-"+DateTime.Now.ToString());

            client.Send(message);
        }
    }
}
