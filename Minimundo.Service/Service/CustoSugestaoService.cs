using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using Minimundo.Infra.Data.Repository;

namespace Minimundo.Service.Service
{
    public class CustoSugestaoService : BaseService<CustoSugestao>, ICustoSugestaoService
    {
        private readonly CustoSugestaoRepository _repository;

        public CustoSugestaoService()
        {
            _repository = new CustoSugestaoRepository();
        }
    }
}