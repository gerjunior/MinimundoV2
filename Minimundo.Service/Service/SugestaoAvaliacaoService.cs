using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using Minimundo.Infra.Data.Repository;

namespace Minimundo.Service.Service
{
    public class SugestaoAvaliacaoService : BaseService<SugestaoAvaliacao>, ISugestaoAvaliacaoService
    {
        private readonly SugestaoAvaliacaoRepository _repository;

        public SugestaoAvaliacaoService()
        {
            _repository = new SugestaoAvaliacaoRepository();
        }
    }
}