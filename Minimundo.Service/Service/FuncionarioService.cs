using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using Minimundo.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Service.Service
{
    public class FuncionarioService : BaseService<Funcionario>, IFuncionarioService
    {
        private FuncionarioRepository _repository;
        public FuncionarioService()
        {
            _repository = new FuncionarioRepository();
        }
    }
}
