using Minimundo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Domain.Interfaces
{
    public interface IRepository<T> 
    {
        T Select(int id);
        T Update(T obj);
        T Delete(int id);
        T Insert(T obj);
        IEnumerable<T> SelectAll();

    }
}
