using System;

namespace Deconstruct
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            var person = new Person { FirstName = "Valentin", LastName = "Dolgov" };
            
            // Деконструируем.
            (var firstname, var lastname) = person;

            Console.WriteLine($"Имя: {firstname}");
            Console.WriteLine($"Фамилия: {lastname}");


        }

        class Person
        {
            public string FirstName { get; set; }
            public string LastName { get; set; }

            public void Deconstruct(out string firstname, out string lastname)
            {
                firstname = this.FirstName;
                lastname = this.LastName;
            }
        }
    }
}
