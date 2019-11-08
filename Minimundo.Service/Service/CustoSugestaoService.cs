using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using Minimundo.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Service.Service
{
    public class CustoSugestaoService : BaseService<CustoSugestao>, ICustoSugestaoService
    {
        private CustoSugestaoRepository _repository;
        public CustoSugestaoService()
        {
            _repository = new CustoSugestaoRepository();
        }
    }
}
