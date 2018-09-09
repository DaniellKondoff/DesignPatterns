using static System.Console;
using System.Collections.Generic;
using System.Linq;

namespace Command
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var ba = new BankAccount();
            var commands = new List<BankAccountCommand>
            {
                new BankAccountCommand(ba, Action.Deposit, 100),
                new BankAccountCommand(ba, Action.Withdraw, 1000)
            };

            WriteLine(ba);

            foreach (var c in commands)
                c.Call();

            WriteLine(ba);

            foreach (var c in Enumerable.Reverse(commands))
                c.Undo();

            WriteLine(ba);
        }
    }
}
