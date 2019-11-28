using Microsoft.AspNetCore.Mvc;
using Minimundo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Domain.Interfaces.Controllers
{
    public interface IBaseController<T> where T : class
    {
        Resposta Verificar(T obj);

        Resposta Verificar(IEnumerable<T> obj);
    }
}
