using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementModels
{
    [DataContract]
    public class Customer
    {
        [DataMember]
        public int CustomerId { get; set; }
        [DataMember]
        public string CustomerName { get; set; }
        [DataMember]
        public decimal Balance { get; set; }
    }
}
