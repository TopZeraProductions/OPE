using DAL.Models.Products.Builder;
using DTO.Products;
using Microsoft.EntityFrameworkCore;

namespace DAL.Core {

    public sealed partial class DataContext : DbContext {

        public DbSet<Product> Product { get; set; }

        private void MapperProductModule(ModelBuilder modelBuilder) {

            modelBuilder.ApplyConfiguration(new ProductModelBuilder());

        }
    }

}