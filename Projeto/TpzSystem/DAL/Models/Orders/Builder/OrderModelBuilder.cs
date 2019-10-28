using DTO.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Models.Orders.Builder {
    internal sealed class OrderModelBuilder : IEntityTypeConfiguration<Order> {
        public void Configure(EntityTypeBuilder<Order> builder) {

            builder.ToTable("tb_order");

            builder.HasKey(model => model.Id);
            builder.Property(model => model.Id).ValueGeneratedOnAdd();

            builder.HasOne(model => model.Client).WithMany().HasForeignKey(c => c.IdClient);
            
            builder.HasMany(model => model.OrderItems).WithOne(model => model.Order).HasForeignKey(c => c.IdOrder);
            
            /*builder.HasOne(c => c.Usuario)
                   .WithMany()
                   .HasForeignKey(c => c.idUsuario)
                   .OnDelete(DeleteBehavior.Restrict);
            */
        }
    }

}