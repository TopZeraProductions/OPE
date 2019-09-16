using DTO.Coordenadores.Entities;

using Microsoft.EntityFrameworkCore;

namespace DTO.Core {

    public partial class DataContext : DbContext {

        public virtual DbSet<Coordenador> Coordenador { get; set; }

        private void MapperModuloCoordenador(ModelBuilder modelBuilder) {

            modelBuilder.ApplyConfiguration(new CoordenadorModelBuilder());

        }
    }

}