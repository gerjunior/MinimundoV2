using System.Collections.Generic;

namespace Minimundo.Domain.Interfaces
{
    public interface IBaseRepository<T>
    {
        T Select(int id);

        T Update(T obj);

        T Delete(int id);

        T Insert(T obj);

        IEnumerable<T> SelectAll();
    }
}