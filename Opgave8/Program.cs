using System;

namespace Opgave8
{
    class Program
    {
        static void Main(string[] args)
        {
            string hello = "Hello ";
            string world = "World";
            object myObject = String.Concat(hello, world);
            string str = (string)myObject;
            Console.WriteLine(str);
            Console.ReadLine();
        }
    }
}
