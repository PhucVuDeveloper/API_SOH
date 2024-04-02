using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libs.Entities
{
    public class Account
    {
        [Key]
        public Guid IdAcc { get; set; }
        public string AccountName { get; set; }
        public string Password { get; set; }
        public int Permission { get; set; }
    }
}
