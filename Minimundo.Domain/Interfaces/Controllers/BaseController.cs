using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Mvc;
using Minimundo.Domain.Entities;

namespace Minimundo.Domain.Interfaces.Controllers
{
    public class BaseController<T> : IBaseController<T> where T : class
    {
        public Resposta Verificar(T obj)
        {

            var Resposta = new Resposta();

            try
            {
                if (obj == null)
                    Resposta.Add("Nenhum valor foi encontrado.", false, null);
                else
                    Resposta.Add("Sucesso.", true, obj);
            }
            catch (Exception ex)
            {
                Resposta.Add(ex.Message, false, null);
            }

            return Resposta;
        }

        public Resposta Verificar(IEnumerable<T> obj)
        {
            var Resposta = new Resposta();

            try
            {
                if (obj == null)
                    Resposta.Add("Nenhum valor foi encontrado.", false, null);

                Resposta.Add("Sucesso.", true, obj);
            }
            catch (Exception ex)
            {
                Resposta.Add(ex.Message, false, null);
            }

            return Resposta;
        }
    }
}
