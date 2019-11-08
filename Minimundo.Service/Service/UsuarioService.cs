using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using Minimundo.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Service.Service
{
    public class UsuarioService : BaseService<Usuario>, IUsuarioService
    {
        private UsuarioRepository _repository;
        public UsuarioService()
        {
            _repository = new UsuarioRepository();
        }
    }
}
