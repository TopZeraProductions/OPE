using DTO.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Models.Products.Builder {
    
    sealed class ProductModelBuilder : IEntityTypeConfiguration<Product> {
        public void Configure(EntityTypeBuilder<Product> builder) {

            builder.ToTable("tb_product");

            builder.HasKey(model => model.Id);
            builder.Property(model => model.Id).ValueGeneratedOnAdd();

            /*builder.HasOne(c => c.Usuario)
                   .WithMany()
                   .HasForeignKey(c => c.idUsuario)
                   .OnDelete(DeleteBehavior.Restrict);
            */
            
            // builder.Property(model => model.UnitaryPrice).HasPrecision(10, 3);
        }
    }

}