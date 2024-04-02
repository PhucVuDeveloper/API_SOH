using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs.Entities
{
    public class Cartlist
    {
        [Key]
        public Guid IdCart { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ImageUrl { get; set; }
        public int ProductQuantity { get; set; }
        public int TableNum { get; set; }
    }
}
