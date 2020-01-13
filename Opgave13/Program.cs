using System;

namespace Opgave13
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 5;
            int b = 10;
            int oldA = a;
            a = b;
            b = oldA;
            Console.WriteLine(a);
            Console.WriteLine(b);
            Console.ReadLine();
        }
    }
}
