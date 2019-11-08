using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using Minimundo.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Service.Service
{
    public class EnderecoService : BaseService<Endereco>, IEnderecoService
    {
        private EnderecoRepository _repository;
        public EnderecoService()
        {
            _repository = new EnderecoRepository();
        }
    }
}
