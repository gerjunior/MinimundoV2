using Minimundo.Domain.Entities;
using Minimundo.Domain.Interfaces;
using Minimundo.Domain.Interfaces.Services;
using Minimundo.Infra.Data.Repository;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Service.Service
{
    public class AvaliadorService : BaseService<Avaliador>, IAvaliadorService
    {
        private AvaliadorRepository _repository;
        public AvaliadorService()
        {
            _repository = new AvaliadorRepository();
        }
        //AvaliadorRepository avaliadorRepository;

        //public void RealizarAvaliacao()
        //{
        //    //eexemplo avliador realizar uma unica avaliacao
        //    avaliadorRepository.RealizarAvaliacao();
        //}
    }
}
