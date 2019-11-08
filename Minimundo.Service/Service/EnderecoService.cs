using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using Minimundo.Infra.Data.Repository;

namespace Minimundo.Service.Service
{
    public class EnderecoService : BaseService<Endereco>, IEnderecoService
    {
        private readonly EnderecoRepository _repository;
        public EnderecoService()
        {
            _repository = new EnderecoRepository();
        }
    }
}
