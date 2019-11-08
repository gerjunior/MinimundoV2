using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Repositories;

namespace Minimundo.Infra.Data.Repository
{
    public class EmpresaRepository : BaseRepository<Empresa>, IEmpresaRepository
    {
    }
}