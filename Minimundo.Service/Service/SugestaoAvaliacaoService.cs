using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Repositories;
using Minimundo.Domain.Interfaces.Services;

namespace Minimundo.Service.Service
{
    public class SugestaoAvaliacaoService : BaseService<SugestaoAvaliacao>, ISugestaoAvaliacaoService
    {
        private readonly ISugestaoAvaliacaoRepository _repository;

        public SugestaoAvaliacaoService(ISugestaoAvaliacaoRepository repository)
        {
            _repository = repository;
        }
    }
}