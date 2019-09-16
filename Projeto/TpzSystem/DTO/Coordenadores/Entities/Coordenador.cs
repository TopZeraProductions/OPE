using DTO.Core.sharedKernel;

namespace DTO.Coordenadores.Entities {

    public class Coordenador : DefaultEntity {
        public int id { get; set; }

        public int idUsuario { get; set; }

        public string nome { get; set; }

        public string email { get; set; }

        public string celular { get; set; }
    }

}