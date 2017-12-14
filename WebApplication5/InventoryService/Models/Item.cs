using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;


namespace InventoryService.Models
{
    public class Item
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
        public string Category { get; set; }

        public string Description { get; set; }
    }
}