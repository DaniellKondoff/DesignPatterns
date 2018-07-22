using Autofac;
using System;

namespace NullObject
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var log = new ConsoleLog();
            var bankAccount = new BankAccount(log);
            bankAccount.Deposit(100);

            var cb = new ContainerBuilder();
            cb.RegisterType<BankAccount>();
            cb.RegisterType<NullLog>().As<ILog>();

            using (var c = cb.Build())
            {
                var ba = c.Resolve<BankAccount>();
                ba.Deposit(100);
            }
        }
    }
}
