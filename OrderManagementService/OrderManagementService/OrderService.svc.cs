using OrderManagementModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace OrderManagementService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "OrderService" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select OrderService.svc or OrderService.svc.cs at the Solution Explorer and start debugging.
    public class OrderService : IOrderService
    {
        public List<Customer> GetCustomers()
        {
            List<Customer> listCustomers = new List<Customer>();
            listCustomers.Add(new Customer { CustomerId = 1, CustomerName = "Deep Gautam", Balance = 85000 });
            listCustomers.Add(new Customer { CustomerId = 2, CustomerName = "Atul Gautam", Balance = 95000 });
            listCustomers.Add(new Customer { CustomerId = 3, CustomerName = "Prasant Gautam", Balance = 75000 });
            listCustomers.Add(new Customer { CustomerId = 4, CustomerName = "Prakash Gautam", Balance = 95000 });
            listCustomers.Add(new Customer { CustomerId = 5, CustomerName = "Jay Gautam", Balance = 185000 });

            return listCustomers;
        }

        public List<Product> GetProducts()
        {
            List<Product> listProducts = new List<Product>();
            listProducts.Add(new Product { ProductId = 1, ProductName = "Iphone 7", Price = 65000 });
            listProducts.Add(new Product { ProductId = 2, ProductName = "Iphone 6", Price = 55000 });
            listProducts.Add(new Product { ProductId = 3, ProductName = "Iphone 5", Price = 45000 });
            listProducts.Add(new Product { ProductId = 4, ProductName = "Iphone 4", Price = 35000 });

            return listProducts;
        }

        public string ManageBalance(int customerId, decimal amount)
        {
            //Update customer balance
            //Hit db and update customer balance as per customer id and given amount

            return "Balance has been update.";
        }

        public string ManageInventory(int productId, int quantity)
        {
            //Update Inventory
            //Hit db and update inventory based on product id and quantity sold out.

            return "Inventory has been update.";

        }

        public string PlaceOrder(Order order)
        {
            //Insert order details in order table
            //Return message after inserting

            return "Order has been placed successfully.";
        }
    }
}
