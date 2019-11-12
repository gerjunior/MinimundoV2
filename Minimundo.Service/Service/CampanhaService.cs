using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Repositories;
using Minimundo.Domain.Interfaces.Services;

namespace Minimundo.Service.Service
{
    public class CampanhaService : BaseService<Campanha>, ICampanhaService
    {
        private readonly ICampanhaRepository _repository;

        public CampanhaService(ICampanhaRepository repository)
        {
            _repository = repository;
        }
    }
}