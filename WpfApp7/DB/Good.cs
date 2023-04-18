using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.DB
{
    public class Good
    {
        [Key]
        public int IdGood { get; set; }
        public string Name { get; set; }
        public double Price { get; set; }
        public double Sale { get; set; }
        public string? Description { get; set; }
     }
}
