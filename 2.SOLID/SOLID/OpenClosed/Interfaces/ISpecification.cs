using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OpenClosed.Interfaces
{
    public interface ISpecification<T>
    {
        bool IsSatisfied(T t);
    }
}
