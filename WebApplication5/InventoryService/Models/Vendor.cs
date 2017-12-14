using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace InventoryService.Models
{
    public class Vendor
    {
        public int Id { get; set; }
        [Required]
        public string Code { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string FullName { get; set; }
        [Required]
        public string CompanyName { get; set; }
        public string CompanyLocalName { get; set; }
        [Required]
        public string CompanyAddress { get; set; }
        [Required]
        public string AadharNumber { get; set; }
        [Required]
        public string PanNumber { get; set; }
        public string DlNumber { get; set; }
        [Required]
        public string MobileNumber { get; set; }
        public string LandlineNumber { get; set; }
    }
}