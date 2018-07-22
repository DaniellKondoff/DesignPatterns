using SOLID.OpenClosed.Interfaces;
using System.Collections.Generic;
using System.Linq;

namespace SOLID.OpenClosed
{
    public class Filter : IFillter<Product>
    {
        public IEnumerable<Product> FilterBySpec(IEnumerable<Product> products, ISpecification<Product> spec)
        {
            return products
                    .Where(p => spec.IsSatisfied(p))
                    .ToList();
        }
    }
}
