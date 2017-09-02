using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebAPIODataTest.Models
{
    public class ProductsContext:DbContext
    {
        public ProductsContext(): base("name=ProductsContext")
        {
        }
        public DbSet<Product> Products { get; set; }
    }
}
