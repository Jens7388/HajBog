using System;

namespace Opgave3
{
    class Program
    {
        static void Main(string[] args)
        {
            double firstNumber = 1;
            double secondNumber = 1.000001;
            bool isEqual =  Math.Abs(firstNumber - secondNumber) < 0.000001;

            if(isEqual)
            {
                Console.WriteLine("De to tal er ens");
            }
            else
            {
                Console.WriteLine("De to tal er ikke ens");
            }
            Console.ReadLine();
        }
    }
}
