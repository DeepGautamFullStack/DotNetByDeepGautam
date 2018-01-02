using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryService.Models
{
    public class Order
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public int Quantity { get; set; }
        [Required]
        public decimal PerUnitPrice { get; set; }
        [Required]
        public string OrderId { get; set; }

        [Required]
        public string poDate { get; set; }

        public string poType { get; set; }

        [Required]
        public string VendorCode { get; set; }

        public string VendorName { get; set; }

        [Required]
        public string ShppingBy { get; set; }
        [Required]
        public string AirBillNo { get; set; }
        [Required]
        public string RequestDate { get; set; }
        [Required]
        public string ToAddress { get; set; }
    }
}