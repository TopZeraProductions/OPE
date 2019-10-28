using DTO.SharedKernel;

namespace DTO.Clients {
    public sealed class Client : DefaultEntity {

        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string PrimaryTelephone { get; set; }

        public string SecondaryTelephone { get; set; }
        
        public string Email { get; set; }
        
        public string ResidentialAddress { get; set; }
        
        public string Region { get; set; }

        public string HomeNumber { get; set; }

        public string Cep { get; set; }
        
    }
}