using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace WebApplication1.Models
{
    public class DBContext : DbContext
    {
        public virtual DbSet<Client> Client { get; set; }

        public virtual DbSet<Provider> Provider { get; set; }

        public virtual DbSet<ServiceProvided> ServiceProvided { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            base.OnModelCreating(modelBuilder);
        }
    }
}