using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Domain.Interfaces
{
    public interface IBaseService<T>
    {
        T Select(int id);
        T Update(T obj);
        T Delete(int id);
        T Insert(T obj);
        IEnumerable<T> SelectAll();

    }
}
