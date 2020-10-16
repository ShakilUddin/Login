using Login.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Login.Data
{
    public class LoginBDConext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-SNRF64I;Database=EFCorLogin;Trusted_Connection=True;");
        }

        public DbSet<UserLogin> UserLogins { get; set; }
    }
}
