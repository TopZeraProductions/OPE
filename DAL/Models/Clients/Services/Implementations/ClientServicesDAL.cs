using DAL.Core;
using DAL.Core.Implementations;
using DAL.Models.Clients.Services.Contracts;
using DTO.Clients;

namespace DAL.Models.Clients.Services.Implementations {
    public class ClientServicesDAL : GenericDataServicesDAL<Client>, IClientServicesDAL {
        public ClientServicesDAL(DefaultContext defaultContext) : base(defaultContext) {
            
        }
    }
}