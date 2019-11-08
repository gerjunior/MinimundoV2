using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using Minimundo.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Service.Service
{
    public class SugestaoService : BaseService<Sugestao>, ISugestaoService
    {
        private SugestaoRepository _repository;
        public SugestaoService()
        {
            _repository = new SugestaoRepository();
        }
    }
}
