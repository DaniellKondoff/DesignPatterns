namespace Builder
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var builder = new HtmlBuilder("ul");

            builder
                .AddChild("li", "Hello")
                .AddChild("li", "from Html Builder");
            System.Console.WriteLine(builder.ToString());

            System.Console.WriteLine();
            System.Console.WriteLine("======================================");
            //Fecate Builder
            var pb = new PersonBuilder();
            var person = pb
                .Works
                    .At("COmpany")
                    .Asa("Engineer")
                    .Earning(20000)
                .Lives
                    .At("123 London")
                    .In("London")
                    .WithPostcode("11111");

            
            System.Console.WriteLine(PersonBuilder.GetPerson(person));
                
        }
    }
}
