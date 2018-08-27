using Adapter.dotFactory.RealWorldCode;
using Adapter.dotFactory.StructuralCode;
using System;


class StartUp
{
    static void Main(string[] args)
    {
        //StructuralCode();

        RealWorldCode();
    }

    private static void RealWorldCode()
    {
        // Non-adapted chemical compound

        Compound unknown = new Compound("Unknown");
        unknown.Display();

        // Adapted chemical compounds

        Compound water = new RichCompound("Water");
        water.Display();

        Compound benzene = new RichCompound("Benzene");
        benzene.Display();

        Compound ethanol = new RichCompound("Ethanol");
        ethanol.Display();

        // Wait for user

        Console.ReadKey();
    }

    private static void StructuralCode()
    {
        // Create adapter and place a request

        Target target = new Adapter.dotFactory.StructuralCode.Adapter();
        target.Request();

        // Wait for user

        Console.ReadKey();
    }
}

