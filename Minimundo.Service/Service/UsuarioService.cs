using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using Minimundo.Infra.Data.Repository;

namespace Minimundo.Service.Service
{
    public class UsuarioService : BaseService<Usuario>, IUsuarioService
    {
        private readonly UsuarioRepository _repository;
        public UsuarioService()
        {
            _repository = new UsuarioRepository();
        }
    }
}
