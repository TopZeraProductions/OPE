using Microsoft.EntityFrameworkCore;

namespace DAL.Core
{
    public sealed partial class DataContext : DbContext
    {
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            this.MapperProductModule(modelBuilder);
            this.MapperOrdersModule(modelBuilder);
            this.MapperClientsModule(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }
}