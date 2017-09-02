using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using SSOwithDotnetcore.Model;

namespace SSOwithDotnetcore.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }
        public IActionResult Message()
        {
            ViewData["Message"] = "Your Message page.";
            List<Message> objlist = new List<Model.Message>();
            Message obj = new Message();

            var connectionString = "Endpoint=sb://deepgautam.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=JBNZc6zh8GA7tmC/XJvD2Av55rhdorxKDDKaki8wbjs=";
            var queueName = "queuedeeptest";

            //var client = QueueClient.CreateFromConnectionString(connectionString, queueName);

            //client.OnMessage(message =>
            //{
            //   obj.Body= String.Format("Message body: {0}", message.GetBody<String>());
            //    obj.Id=String.Format("Message id: {0}", message.MessageId);
            //});

            //objlist.Add(obj);


            return View(objlist);
        }

        public IActionResult Error()
        {
            return View();
        }
    }
}
