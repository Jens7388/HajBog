using System;

namespace Opgave7
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello ";
            string world = "World";
            object myObject = String.Concat(hello, world);
            Console.WriteLine(myObject);
            Console.ReadLine();
        }
    }
}
