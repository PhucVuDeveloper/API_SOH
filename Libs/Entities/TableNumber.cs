using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs.Entities
{
    public class TableNumber
    {
        [Key]
        public Guid IdTable { get; set; }
        public int TableNum { get; set; }
        public int TableStatus { get; set; }
        public int Floor { get; set; }
    }
}
