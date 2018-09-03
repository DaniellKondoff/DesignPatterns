using Proxy.ProtectionProxy;
using System;

namespace Proxy
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //Protection Proxy
            ICar car = new CarProxy(new Driver(12)); // 22
            car.Drive();


        }
    }
}
