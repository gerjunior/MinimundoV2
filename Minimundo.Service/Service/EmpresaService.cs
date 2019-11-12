using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Repositories;
using Minimundo.Domain.Interfaces.Services;

namespace Minimundo.Service.Service
{
    public class EmpresaService : BaseService<Empresa>, IEmpresaService
    {
        private readonly IEmpresaRepository _repository;

        public EmpresaService(IEmpresaRepository repository)
        {
            _repository = repository;
        }
    }
}