using DTO.Core.sharedKernel;

namespace DTO.Produtos.Entities {

    public class Produto : DefaultEntity {
        public int id { get; set; }

        public int idUsuario { get; set; }

        public string nome { get; set; }

        public string email { get; set; }

        public string celular { get; set; }
    }

}