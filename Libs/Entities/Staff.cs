using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs.Entities
{
    public class Staff
    {
        [Key]
        public Guid IdStaff { get; set; }
        public string NameStaff { get; set; }
        public string PhoneNum { get; set; }
        public string Address { get; set; }
        public string Role { get; set; }
    }
}
