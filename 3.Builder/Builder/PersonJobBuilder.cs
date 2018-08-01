namespace Builder
{
    public class PersonJobBuilder : PersonBuilder
    {
        public PersonJobBuilder(Person person)
        {
            this.person = person;
        }

        public PersonJobBuilder At(string companyName)
        {
            person.companyName = companyName;
            return this;
        }

        public PersonJobBuilder Asa(string position)
        {
            person.position = position;
            return this;
        }

        public PersonJobBuilder Earning(int amount)
        {
            person.annualIncome = amount;
            return this;
        }
    }
}
