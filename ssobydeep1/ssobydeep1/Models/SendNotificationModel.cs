using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ssobydeep1.Models
{
    public class SendNotificationModel
    {
        public int Id { get; set; }
        public string SenderName { get; set; }
        public string Message { get; set; }
        public DateTime ActionDate { get; set; }
    }
}