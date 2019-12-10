using Minimundo.Domain.Entities.Authentication;
using Minimundo.Domain.Interfaces.Repositories;
using Minimundo.Domain.Interfaces.Services;

namespace Minimundo.Service.Service
{
    public class CredencialService : BaseService<credencial>, ICredencialService
    {
        private readonly ICredencialRepository _repository;

        public CredencialService(ICredencialRepository repository)
        {
            _repository = repository;
        }
    }
}