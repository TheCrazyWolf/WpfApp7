using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.DB
{
    public class Order
    {
        [Key]
        public int IdOrder { get; set; }
        public DateTime DateTimeOrder { get; set; }
        public Good Good { get; set; }
        public Account Account { get; set; }

        //public List<Good> Goods { get; set; }
    }
}
