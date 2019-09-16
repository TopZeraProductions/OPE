using DTO.Produtos.Builder;
using DTO.Produtos.Entities;

using Microsoft.EntityFrameworkCore;

namespace DTO.Core {

    public partial class DataContext : DbContext {

        public virtual DbSet<Produto> Produto { get; set; }

        private void MapperModuloProduto(ModelBuilder modelBuilder) {

            modelBuilder.ApplyConfiguration(new ProdutoModelBuilder());

        }
    }

}