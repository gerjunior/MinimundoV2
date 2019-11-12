using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Repositories;
using Minimundo.Domain.Interfaces.Services;

namespace Minimundo.Service.Service
{
    public class TelefoneService : BaseService<Telefone>, ITelefoneService
    {
        private readonly ITelefoneRepository _repository;

        public TelefoneService(ITelefoneRepository repository)
        {
            _repository = repository;
        }
    }
}