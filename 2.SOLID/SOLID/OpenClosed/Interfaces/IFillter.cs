using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OpenClosed.Interfaces
{
    public interface IFillter<T>
    {
        IEnumerable<T> FilterBySpec(IEnumerable<T> items, ISpecification<T> spec);
    }
}
