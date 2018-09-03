using System;

namespace Facade
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var homeTheaterPro = HomeTheaterPro.CreateInstance();
            homeTheaterPro.InitHomeSystem();
            homeTheaterPro.DisplayAvailableMedia();
            homeTheaterPro.Next();
            homeTheaterPro.Next();
            homeTheaterPro.Previous();
            homeTheaterPro.Stop();
        }
    }
}
