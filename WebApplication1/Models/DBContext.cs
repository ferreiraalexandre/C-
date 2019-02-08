using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;

namespace WebApplication1.Models
{
    public class DBContext : DbContext
    {
//        public DBContext() :base("DataContext")
//        {
//        }

        public DbSet<Client> Client { get; set; }

        public DbSet<Provider> Provider { get; set; }

        public DbSet<ServiceProvided> ServiceProvided { get; set; }

 //       protected override void OnModelCreating(DbModelBuilder modelBuilder)
 //       {
 //           base.OnModelCreating(modelBuilder);
 //       }
    }
}