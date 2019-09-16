using Microsoft.EntityFrameworkCore;

namespace DTO.Core {

    public partial class DataContext : DbContext {

        protected override void OnModelCreating(ModelBuilder modelBuilder) {

            this.MapperModuloCoordenador(modelBuilder);

            base.OnModelCreating(modelBuilder);
        }
    }

}