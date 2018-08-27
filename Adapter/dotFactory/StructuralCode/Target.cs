using System;

namespace Adapter.dotFactory.StructuralCode
{
    public class Target
    {
        public virtual void Request()
        {
            Console.WriteLine("Called Target Request()");
        }
    }
}
