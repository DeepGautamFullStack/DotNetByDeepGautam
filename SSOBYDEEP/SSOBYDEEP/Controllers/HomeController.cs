using Microsoft.ServiceBus.Messaging;
using SSOBYDEEP.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SSOBYDEEP.Controllers
{
    [Authorize]
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        public ActionResult Message()
        {
            ViewData["Message"] = "Your Message page.";
            List<Message> objlist = new List<Models.Message>();
            Message obj = new Message();

            var connectionString = "Endpoint=sb://deepgautam.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=JBNZc6zh8GA7tmC/XJvD2Av55rhdorxKDDKaki8wbjs=";
            var queueName = "queuedeeptest";

            var client = QueueClient.CreateFromConnectionString(connectionString, queueName);

            client.OnMessage(message =>
            {
                obj.Body = String.Format("Message body: {0}", message.GetBody<String>());
                obj.Id = String.Format("Message id: {0}", message.MessageId);
            });

            objlist.Add(obj);


            return View(objlist);
        }
    }
}