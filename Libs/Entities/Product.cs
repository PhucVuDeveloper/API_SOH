using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs.Entities
{
    public class Product
    {
        [Key]
        public Guid IdProduct { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ImageUrl { get; set; }
        public int ProductType { get; set; } 
        public int ProductQuantity { get; set; }
        public int ProductStatus { get; set; }
        //public IFormFile Image { get; set; }
    }
}
