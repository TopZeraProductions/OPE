using DTO.Produtos.Entities;

using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DTO.Produtos.Builder {
    
    sealed class ProdutoModelBuilder : IEntityTypeConfiguration<Produto> {
        public void Configure(EntityTypeBuilder<Produto> builder) {

            builder.ToTable("tb_produto", schema : "Produto");

            builder.HasKey(model => model.id);
            builder.Property(c => c.id).ValueGeneratedOnAdd();

            /*builder.HasOne(c => c.Usuario)
                   .WithMany()
                   .HasForeignKey(c => c.idUsuario)
                   .OnDelete(DeleteBehavior.Restrict);
            */

            builder.HasIndex(c => c.email).IsUnique();
            builder.HasIndex(c => c.celular).IsUnique();
        }
    }

}