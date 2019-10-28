using DAL.Models.Clients.Builder;
using DTO.Clients;
using Microsoft.EntityFrameworkCore;

namespace DAL.Core {

    public sealed partial class DataContext : DbContext {

        public DbSet<Client> Client { get; set; }

        private void MapperClientsModule(ModelBuilder modelBuilder) {

            modelBuilder.ApplyConfiguration(new ClientModelBuilder());

        }
    }

}