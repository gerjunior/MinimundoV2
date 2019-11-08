using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using Minimundo.Infra.Data.Repository;

namespace Minimundo.Service.Service
{
    public class AvaliadorService : BaseService<Avaliador>, IAvaliadorService
    {
        private readonly AvaliadorRepository _repository;
        public AvaliadorService()
        {
            _repository = new AvaliadorRepository();
        }
    }
}
