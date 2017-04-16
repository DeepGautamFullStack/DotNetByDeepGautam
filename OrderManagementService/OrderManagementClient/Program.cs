using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;
using System.ServiceModel;
using OrderManagementModels;


namespace OrderManagementClient
{
  public  class Program
    {
        static void Main(string[] args)
        {
            #region Creating Test Objects
            /// Test Object Creation section 
            ///  for all the objects which require to call service and consume
            ///  and use the order service with transactions
            
            
            //Test Object Order
            Order objOrder = new Order();
            objOrder.CustomerId = 1;
            objOrder.ProductId = 1;
            objOrder.Quantity = 5;
            objOrder.OrderId = 1;
            objOrder.Price = 100;
            objOrder.Amount = 500;

            //Test Object Product
            Product objProdcut = new Product();
            objProdcut.ProductId = 1;
            objProdcut.ProductName = "Iphone5";
            objProdcut.Price = 100;

            //Test Object Customer

            Customer objCustomer = new Customer();
            objCustomer.CustomerId = 1;
            objCustomer.CustomerName = "Deep Gautam";
            objCustomer.Balance = 5000;

            #endregion

            #region Consuming WCF service
            /// Below is the postion of code which has code
            /// to consume WCF service with few method as Transactional and 
            /// few as non transactional
            using (var tranScope = new TransactionScope())
            {
                try
                {
                    OrderServiceReference.OrderServiceClient proxy = new OrderServiceReference.OrderServiceClient();
                    var result = proxy.PlaceOrder(objOrder);
                    Console.WriteLine(result);
                    result = proxy.ManageInventory(objProdcut.ProductId, Convert.ToInt32( objOrder.Quantity));
                    Console.WriteLine(result);
                    result = proxy.ManageBalance(objCustomer.CustomerId,Convert.ToDecimal(Convert.ToInt32(objOrder.Quantity)) * objOrder.Price);
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

                //Here we have Print Invoice Method which will print the invoice
                //Based on succsessfully completion of transaction

                Console.WriteLine("Invoice Of the Order has been generated with below details.");
                Console.WriteLine("Order Id :"+ Convert.ToString(objOrder.OrderId));
                Console.WriteLine("Order Amount :" + Convert.ToString(objOrder.Amount));
                Console.WriteLine("Customer Id :" + Convert.ToString(objOrder.CustomerId));
                Console.WriteLine("Customer Name :" + Convert.ToString(objCustomer.CustomerName));
                Console.WriteLine("Quantity Of Item:" + Convert.ToString(objOrder.Quantity));
                Console.WriteLine("Price Of Item :" + Convert.ToString(objOrder.Price));
                Console.WriteLine("Product Id :" + Convert.ToString(objOrder.ProductId));
                Console.WriteLine("Product Name :" + Convert.ToString(objProdcut.ProductName));


                Console.ReadLine();
            }
            #endregion Consuming of transaction based WCF service.

        }
    }
    
}
