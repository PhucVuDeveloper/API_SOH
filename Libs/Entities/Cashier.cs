using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs.Entities
{
    public class Cashier
    {
        [Key]
        public Guid IdCashier { get; set; }
        public string ProductName { get; set; }
        public decimal ProductPrice { get; set; }
        public int ProductQuantity { get; set; }
        public int TableNum { get; set; }
    }
}
