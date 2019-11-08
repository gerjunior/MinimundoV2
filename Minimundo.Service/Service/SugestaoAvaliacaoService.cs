using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces.Services;
using Minimundo.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Service.Service
{
    public class SugestaoAvaliacaoService : BaseService<SugestaoAvaliacao>, ISugestaoAvaliacaoService
    {
        private SugestaoAvaliacaoRepository _repository;
        public SugestaoAvaliacaoService()
        {
            _repository = new SugestaoAvaliacaoRepository();
        }
    }
}
