using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using Minimundo.Infra.Data.Repository;

namespace Minimundo.Service.Service
{
    public class SugestaoService : BaseService<Sugestao>, ISugestaoService
    {
        private readonly SugestaoRepository _repository;

        public SugestaoService()
        {
            _repository = new SugestaoRepository();
        }
    }
}