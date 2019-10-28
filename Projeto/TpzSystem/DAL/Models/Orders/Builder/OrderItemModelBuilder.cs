using DTO.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Models.Orders.Builder {
    internal sealed class OrderItemModelBuilder : IEntityTypeConfiguration<OrderItem> {
        public void Configure(EntityTypeBuilder<OrderItem> builder) {

            builder.ToTable("tb_order_item");
            
            builder.HasKey(model => model.Id);
            
            builder.Property(model => model.Id).ValueGeneratedOnAdd();

            builder.HasOne(model => model.Order).WithMany().HasForeignKey(c => c.IdOrder);
            
            builder.HasOne(model => model.Product).WithMany().HasForeignKey(c => c.IdProduct);
        }
    }

}