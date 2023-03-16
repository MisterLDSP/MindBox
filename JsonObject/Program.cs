using System;

namespace JsonObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
}


// 1. Выделяем json.
// 2. Копируем.
/*
{
    "Name": "Valentin",
    "Age": "34",
    "City": "Surgut"
}
*/

// 3. Переходим туда где хотим вставить класс.
// 4. Правка.
// 5. Специальная вставка.
// 6. Вставить json как классы.
public class Rootobject
{
    public string Name { get; set; }
    public string Age { get; set; }
    public string City { get; set; }
}

