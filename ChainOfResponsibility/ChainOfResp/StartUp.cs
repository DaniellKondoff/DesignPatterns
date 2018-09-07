using ChainOfResp.MethodChain;
using System;
using static System.Console;

namespace ChainOfResp
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //MethodChain();

            Approver teamLead = new TeamLead();
            Approver vp = new VicePresident();
            Approver ceo = new President();

            teamLead.SetSuccessor(vp);
            vp.SetSuccessor(ceo);

            var purchase = new Purchase(2034, 350.00);
            teamLead.ProcessRequest(purchase);

            purchase = new Purchase(2035, 32590.10);
            teamLead.ProcessRequest(purchase);

            purchase = new Purchase(2036, 122100.00);
            teamLead.ProcessRequest(purchase);
        }

        private static void MethodChain()
        {
            var goblin = new Creature("Goblin", 2, 2);
            WriteLine(goblin);

            var root = new CreatureModifier(goblin);

            //root.Add(new NoBonusesModifier(goblin));

            WriteLine("Let's double goblin's attack...");
            root.Add(new DoubleAttackModifier(goblin));

            WriteLine("Let's increase goblin's defense");
            root.Add(new IncreaseDefenseModifier(goblin));

            // eventually...
            root.Handle();
            WriteLine(goblin);
        }
    }
}
