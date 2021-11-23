using MyLibs.Serialisation;
using System;

namespace MyLibsTests.Serialisation
{
    class Program
    {
        static void Main(string[] args)
        {
            Serializer sz = new Serializer();
            var data = new Person{ Name = "Toto", Age = 65 };
            sz.Serialize<Person>(data, "Person.bin");
            Console.WriteLine("Done!");
            Console.ReadKey();
        }
    }
}
