using System;
using System.Collections.Generic;
using System.Text;
using State.States;

namespace State
{
    public class Account
    {
        public double Balance { get; internal set; }
        public States.State State { get; internal set; }
        public string Owner { get; set; }

        public Account(string owner)
        {
            // New accounts are 'Silver' by default
            this.Owner = owner;
            this.State = new SilverState(this);
        }

        public void Deposit(double amount)
        {
            this.State.Deposit(amount);
            Console.WriteLine("Deposited {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status  = {0}", this.State.GetType().Name);
            Console.WriteLine();
        }

        public void Withdraw(double amount)
        {
            this.State.Withdraw(amount);
            Console.WriteLine("Withdrew {0:C} --- ", amount);
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status  = {0}\n", this.State.GetType().Name);
        }

        public void PayInterest()
        {
            this.State.PayInterest();
            Console.WriteLine("Interest Paid --- ");
            Console.WriteLine(" Balance = {0:C}", this.Balance);
            Console.WriteLine(" Status  = {0}\n", this.State.GetType().Name);
        }
    }
}
