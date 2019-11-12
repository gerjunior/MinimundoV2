using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Repositories;
using Minimundo.Domain.Interfaces.Services;

namespace Minimundo.Service.Service
{
    public class SugestaoService : BaseService<Sugestao>, ISugestaoService
    {
        private readonly ISugestaoRepository _repository;

        public SugestaoService(ISugestaoRepository repository)
        {
            _repository = repository;
        }
    }
}