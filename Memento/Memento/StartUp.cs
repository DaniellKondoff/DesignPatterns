using static System.Console;

namespace Memento
{
    class StartUp
    {
        static void Main(string[] args)
        {
            //BaseMemento();
            var ba = new UndoRedo.BankAccount(100);
            ba.Deposit(50);
            ba.Deposit(25);
            WriteLine(ba);

            ba.Undo();
            WriteLine($"Undo 1: {ba}");
            ba.Undo();
            WriteLine($"Undo 2: {ba}");
            ba.Redo();
            WriteLine($"Redo 2: {ba}");
        }

        private static void BaseMemento()
        {
            var ba = new BankAccount(100);
            var m1 = ba.Deposit(50); // 150
            var m2 = ba.Deposit(25); // 175
            WriteLine(ba);

            // restore to m1
            ba.Restore(m1);
            WriteLine(ba); //150

            ba.Restore(m2);
            WriteLine(ba); //175
        }
    }
}
