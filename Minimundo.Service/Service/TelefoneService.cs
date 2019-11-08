using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using Minimundo.Infra.Data.Repository;

namespace Minimundo.Service.Service
{
    public class TelefoneService : BaseService<Telefone>, ITelefoneService
    {
        private readonly TelefoneRepository _repository;

        public TelefoneService()
        {
            _repository = new TelefoneRepository();
        }
    }
}