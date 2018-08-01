namespace Builder
{
    public class PersonBuilder //facade
    {
        //reference!
        protected Person person = new Person();

        public PersonJobBuilder Works => new PersonJobBuilder(person);
        public PersonAddressBuilder Lives => new PersonAddressBuilder(person);

        public static Person GetPerson(PersonBuilder pb)
        {
            return pb.person;
        }
    }
}
