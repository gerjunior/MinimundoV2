using Minimundo.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Domain.Interfaces
{
    public interface IRepository<T> 
    {
        T Select(int id);
        bool Update(T obj);
        bool Delete(int id);
        bool Insert(T obj);
        IList<T> SelectAll();

    }
}
