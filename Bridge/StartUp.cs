using System;

namespace Bridge
{
    class StartUp
    {
        static void Main(string[] args)
        {
            IRenderer render = new VectorRenderer();
            IRenderer render2 = new RasterRenderer();
            var circle = new Circle(render2, 5);
            circle.Draw();
            circle.Resize(5);
            circle.Draw();
        }
    }
}
