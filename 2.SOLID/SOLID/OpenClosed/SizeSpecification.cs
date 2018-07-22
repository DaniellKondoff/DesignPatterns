using SOLID.OpenClosed.Interfaces;

namespace SOLID.OpenClosed
{
    public class SizeSpecification : ISpecification<Product>
    {
        private Size size;

        public SizeSpecification(Size size)
        {
            this.size = size;
        }

        public bool IsSatisfied(Product p)
        {
            return p.size.Equals(size);
        }
    }
}
