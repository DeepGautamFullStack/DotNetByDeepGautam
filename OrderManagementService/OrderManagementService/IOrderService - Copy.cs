using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace OrderManagementService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IService1" in both code and config file together.
    [ServiceContract]
    public interface IOrderService
    {
        [OperationContract]
        [TransactionFlow(TransactionFlowOption.NotAllowed)]
        List<Customer> GetCustomers();

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.NotAllowed)]
        List<Product> GetProducts();

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Mandatory)]
        string PlaceOrder(Order order);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Mandatory)]
        string ManageInventory(int productId, int quantity);

        [OperationContract]
        [TransactionFlow(TransactionFlowOption.Mandatory)]
        string ManageBalance(int customerId, decimal amount);




        // TODO: Add your service operations here
    }


    // Use a data contract as illustrated in the sample below to add composite types to service operations.

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

    [DataContract]
    public class Product
    {
        [DataMember]
        public int ProductId { get; set; }
        [DataMember]
        public string ProductName { get; set; }
        [DataMember]
        public decimal Price { get; set; }

    }

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
