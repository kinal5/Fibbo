using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibbConsol
{
    class ProgramFibZSuma
    {

        public static uint Fibonacci(uint n)
        {
            if (n <= 2)
            {
                return 1;
            }
            else
            {
                return Fibonacci(n - 2) + Fibonacci(n - 1);
            }
        }
        static void Main(string[] args)
        {
            uint i = 2;
            uint suma = 0;
            while (Fibonacci(i) < 4000000)
            {
                //Console.WriteLine(Fibonacci(i));
                suma += Fibonacci(i);
                i++;
            }
            Console.WriteLine(suma);
            Console.ReadKey();
        }
    }
}
