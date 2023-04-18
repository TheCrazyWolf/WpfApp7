using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.DB
{
    public class Account
    {
        [Key]
        public int IdAccount { get; set; }

        // public Guid IdAccount {get;set;}
        public string Login { get; set; }
        public string Password { get; set; }
        public Role? Role { get; set; }

    }

    public enum Role
    {
        Admin, User
    }
}
