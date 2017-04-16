using Microsoft.Azure.NotificationHubs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AzureNotificationtestHub
{
    class Program
    {
        static void Main(string[] args)
        {
            SendNotificationAsyn();
        }
        private static async void SendNotificationAsyn()
        {
            NotificationHubClient hub = NotificationHubClient.CreateClientFromConnectionString("Endpoint=sb://noyificationns.servicebus.windows.net/;SharedAccessKeyName=DefaultFullSharedAccessSignature;SharedAccessKey=bM5YwR/4VxMduwa5sOeFeV2PLZ73ozptx5dNeR0I0r8=", "DeepNotification");
            string message = "{\"data\":{\"message\": \"Deep Has sent a small push notification\"}}";
            var test=await hub.SendGcmNativeNotificationAsync(message);

            Console.ReadLine();
        }
   }
}
