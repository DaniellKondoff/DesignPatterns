namespace State.States
{
    public abstract class State
    {
        protected Account Account { get; private set; }

        protected double Interest { get; set; }

        protected double LowerLimit { get; set; }

        protected double UpperLimit { get; set; }

        protected State(Account account)
        {
            this.Account = account;
        }

        public abstract void Deposit(double amount);

        public abstract void Withdraw(double amount);

        public abstract void PayInterest();
    }
}
