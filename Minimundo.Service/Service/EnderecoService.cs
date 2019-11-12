using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Repositories;
using Minimundo.Domain.Interfaces.Services;

namespace Minimundo.Service.Service
{
    public class EnderecoService : BaseService<Endereco>, IEnderecoService
    {
        private readonly IEnderecoRepository _repository;

        public EnderecoService(IEnderecoRepository repository)
        {
            _repository = repository;
        }
    }
}