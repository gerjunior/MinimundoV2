using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using Minimundo.Infra.Data.Repository;

namespace Minimundo.Service.Service
{
    public class EmpresaService : BaseService<Empresa>, IEmpresaService
    {
        private readonly EmpresaRepository _repository;

        public EmpresaService()
        {
            _repository = new EmpresaRepository();
        }
    }
}