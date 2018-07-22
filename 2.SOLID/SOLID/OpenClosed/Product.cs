using System;
using System.Collections.Generic;
using System.Text;

namespace SOLID.OpenClosed
{
    public class Product
    {
        public string name;
        public Color color;
        public Size size;

        public Product(string name, Color color, Size size)
        {
            this.name = name;
            this.color = color;
            this.size = size;
        }
    }
}
