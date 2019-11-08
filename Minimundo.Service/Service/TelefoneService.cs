using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using Minimundo.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Service.Service
{
    public class TelefoneService : BaseService<Telefone>, ITelefoneService
    {
        private TelefoneRepository _repository;
        public TelefoneService()
        {
            _repository = new TelefoneRepository();
        }
    }
}
