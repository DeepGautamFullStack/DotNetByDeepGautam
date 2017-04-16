using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace OrderManagementModels
{
    [DataContract]
    public class Order
    {
        [DataMember]
        public int OrderId { get; set; }
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public int CustomerId { get; set; }
        [DataMember]
        public long Quantity { get; set; }
        [DataMember]
        public decimal Price { get; set; }
        [DataMember]
        public decimal Amount { get; set; }

    }
}
