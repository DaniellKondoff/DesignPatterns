namespace Builder
{
    public class PersonAddressBuilder : PersonBuilder
    {
        public PersonAddressBuilder(Person person)
        {
            this.person = person;
        }

        public PersonAddressBuilder At(string streetAddress)
        {
            person.streetAdress = streetAddress;
            return this;
        }

        public PersonAddressBuilder WithPostcode(string postcode)
        {
            person.postCode = postcode;
            return this;
        }

        public PersonAddressBuilder In(string city)
        {
            person.city = city;
            return this;
        }
    }
}