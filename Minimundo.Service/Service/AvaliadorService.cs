using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Repositories;
using Minimundo.Domain.Interfaces.Services;

namespace Minimundo.Service.Service
{
    public class AvaliadorService : BaseService<Avaliador>, IAvaliadorService
    {
        private readonly IAvaliadorRepository _repository;

        public AvaliadorService(IAvaliadorRepository repository)
        {
            _repository = repository;
        }
    }
}