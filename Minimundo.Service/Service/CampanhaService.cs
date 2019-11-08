using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using Minimundo.Infra.Data.Repository;

namespace Minimundo.Service.Service
{
    public class CampanhaService : BaseService<Campanha>, ICampanhaService
    {
        private readonly CampanhaRepository _repository;
        public CampanhaService()
        {
            _repository = new CampanhaRepository();
        }
    }
}
