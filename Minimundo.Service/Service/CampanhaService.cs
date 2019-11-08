using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using Minimundo.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Service.Service
{
    public class CampanhaService : BaseService<Campanha>, ICampanhaService
    {
        private CampanhaRepository _repository;
        public CampanhaService()
        {
            _repository = new CampanhaRepository();
        }
    }
}
