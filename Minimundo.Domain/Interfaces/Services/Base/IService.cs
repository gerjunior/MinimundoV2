using System;
using System.Collections.Generic;
using System.Text;

namespace Minimundo.Domain.Interfaces
{
    public interface IService<T>
    {
        T Select(int id);
    }
}
