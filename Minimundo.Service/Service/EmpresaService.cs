using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using Minimundo.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Service.Service
{
    public class EmpresaService : BaseService<Empresa>, IEmpresaService
    {
        private EmpresaRepository _repository;
        public EmpresaService()
        {
            _repository = new EmpresaRepository();
        }
    }
}
