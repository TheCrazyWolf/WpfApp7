using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp7.DB
{
    public class ContextDb : DbContext
    {
        public DbSet<Account> Accounts { get; set; }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Order> Orders { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseSqlServer("Server=192.168.51.181;Database=Test1804;User Id=Stud;Password=Stud;Encrypt=False");
        }

    }
}
