using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using Minimundo.Infra.Data.Repository;

namespace Minimundo.Service.Service
{
    public class FuncionarioService : BaseService<Funcionario>, IFuncionarioService
    {
        private readonly FuncionarioRepository _repository;

        public FuncionarioService()
        {
            _repository = new FuncionarioRepository();
        }
    }
}