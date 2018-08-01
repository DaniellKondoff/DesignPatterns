using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Person
    {
        public string streetAdress, postCode, city;

        //employment
        public string companyName, position;
        public int annualIncome;

        public override string ToString()
        {
            return $"{nameof(streetAdress)}: {streetAdress}, {nameof(postCode)}: {postCode}, {nameof(city)}: {city}";
        }
    }
}
