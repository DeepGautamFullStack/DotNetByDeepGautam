using OrderManagementService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace OrderManagementClient
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var tranScope = new TransactionScope())
            {
                try
                {
                    OrderServiceReference proxy = new OrderServiceReference();
                   var result = proxy.PlaceOrder(Order);
                    Console.WriteLine(result);
                    result = proxy.ManageInventory(product.ProductId, quantity);
                    Console.WriteLine(result);
                    result = proxy.ManageBalance(customer.CustomerId,
                      Convert.ToDecimal(quantity) * order.Price);
                    Console.WriteLine(result);
                    tranScope.Complete();
                }
                catch (FaultException faultEx)
                {
                    Console.WriteLine(faultEx.Message);
                }
                catch (ProtocolException protocolEx)
                {
                    Console.WriteLine(protocolEx.Message);
                }
            }
            
        }
    }
}
