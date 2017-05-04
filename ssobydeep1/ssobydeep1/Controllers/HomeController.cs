using Microsoft.ServiceBus.Messaging;
using ssobydeep1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace ssobydeep1.Controllers
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
            ViewBag.Message = "About Azure Active directory.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
        [AllowAnonymous]
        public ActionResult Notify(SendNotificationModel m)
        {
            
            ViewBag.Message = "Your notification sender page.";

            if(m.Message!=null)
            {

                var connectionString = "Endpoint=sb://deepgautam.servicebus.windows.net/;SharedAccessKeyName=RootManageSharedAccessKey;SharedAccessKey=JBNZc6zh8GA7tmC/XJvD2Av55rhdorxKDDKaki8wbjs=";
                var queueName = "queuedeeptest";

                var client = QueueClient.CreateFromConnectionString(connectionString, queueName);
                var message = new BrokeredMessage("Message from"+m.SenderName+ ",Message is-"+m.Message +"and action date is-"+m.ActionDate+ "He sent at "+DateTime.Now.ToShortDateString());

                client.Send(message);
            }

            return View();
        }
        [HttpPost]
        public ActionResult SendNotification(SendNotificationModel m)
        {
            return RedirectToAction("Notify");
        }
    }
}