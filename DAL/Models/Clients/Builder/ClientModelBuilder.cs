using DTO.Clients;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace DAL.Models.Clients.Builder {
    
    sealed class ClientModelBuilder : IEntityTypeConfiguration<Client> {
        public void Configure(EntityTypeBuilder<Client> builder) {

            builder.ToTable("tb_client");

            builder.HasKey(model => model.Id);
            
            builder.Property(c => c.Id).ValueGeneratedOnAdd();

            /*builder.HasOne(c => c.Usuario)
                   .WithMany()
                   .HasForeignKey(c => c.idUsuario)
                   .OnDelete(DeleteBehavior.Restrict);
            */
        }
    }

}