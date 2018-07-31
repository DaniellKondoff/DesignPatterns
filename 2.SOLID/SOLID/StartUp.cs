using System;
using System.IO;
using System.Linq;
using SOLID.LISKOV;
using SOLID.OpenClosed;
using SOLID.SignleResponsibility;

namespace SOLID
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //1.Single Responsible
            //var j = new Journal();
            //j.AddEntry("Entry 1");
            //j.AddEntry("Entry 2");
            //Console.WriteLine(j);

            //var p = new Persistence();
            //string filePath = @"D:\temp\test.txt";
            //p.SaveToFile(j, filePath, true);

            //2.OpenClosed
            //var apple = new Product("Apple", Color.Green, Size.Small);
            //var tree = new Product("Tree", Color.Green, Size.Large);
            //var house = new Product("House", Color.Blue, Size.Medium);

            //Product[] products = new Product[] { apple, tree, house };

            //var f = new Filter();
            //var cs = new ColorSpecification(Color.Green);
            //var greenProducts = f.FilterBySpec(products, cs);
            //Console.WriteLine(string.Join(Environment.NewLine, greenProducts.Select(p => p.name)));

            //var sizeSpec = new SizeSpecification(Size.Small);
            //var smallProducts = f.FilterBySpec(products, sizeSpec);
            //Console.WriteLine(string.Join(Environment.NewLine, smallProducts.Select(p => p.name)));

            //Console.WriteLine();
            //var andSpec = new AndSpecification<Product>(cs, sizeSpec);
            //var smallGreenProducts = f.FilterBySpec(products, andSpec);
            //Console.WriteLine(string.Join(Environment.NewLine, smallGreenProducts.Select(p => p.name)));

            //3.Liskov
            
            //Rectangle rc = new Rectangle(2, 3);
            //int Area(Rectangle r) => r.Height * r.Width;
            //Console.WriteLine(Area(rc));

            //Rectangle sc = new Square(4, 4);
            //Console.WriteLine(Area(sc));


        }
    }
}
