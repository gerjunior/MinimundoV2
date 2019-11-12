using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Repositories;
using Minimundo.Domain.Interfaces.Services;

namespace Minimundo.Service.Service
{
    public class CustoSugestaoService : BaseService<CustoSugestao>, ICustoSugestaoService
    {
        private readonly ICustoSugestaoRepository _repository;

        public CustoSugestaoService(ICustoSugestaoRepository repository)
        {
            _repository = repository;
        }
    }
}