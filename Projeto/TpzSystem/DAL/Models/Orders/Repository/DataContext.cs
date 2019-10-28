using DAL.Models.Orders.Builder;
using DAL.Models.Products.Builder;
using DTO.Orders;
using Microsoft.EntityFrameworkCore;

namespace DAL.Core
{
    public sealed partial class DataContext : DbContext
    {
        public DbSet<Order> Order { get; set; }

        public DbSet<OrderItem> OrderItem { get; set; }

        private void MapperOrdersModule(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new OrderModelBuilder());
            modelBuilder.ApplyConfiguration(new OrderItemModelBuilder());
        }
    }
}