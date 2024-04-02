using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace Libs.Entities
{
    public class Kitchen
    {
        [Key]
        public Guid IdKitchen { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public string ImageUrl { get; set; }
        public int CreatedNumber { get; set; }
        public int TableNum { get; set; }
        public int ProductQuantity {  get; set; }
        public string ProductNote { get; set; }
}
}
