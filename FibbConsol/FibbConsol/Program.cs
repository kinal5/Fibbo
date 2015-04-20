using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibbConsol
{
    class Program
    {
        static void Main(string[] args)
        {
            uint i = 2;
            uint suma = 0;
            while (Fibonacci(i) < 4000000)
            {
                if (EvenValue(Fibonacci(i)) == true)
                {
                    suma += Fibonacci(i);
                }
                i++;
            }
            Console.WriteLine(suma);
            Console.ReadKey();
        }

        /// <summary>
        /// 
        /// Public and Static: Check value if is even or not
        /// 
        /// Example:
        /// 
        /// EvenValue(8)
        ///     #=>true
        ///     
        /// EvenValue(13)
        ///     #=>false
        /// 
        /// </summary>
        /// <param name="number"></param>
        /// <returns> Return true when value is even number and false when is not </returns>
        public static Boolean EvenValue(uint number)
        {
            if (number % 2 == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            
        }

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
        
    }
}
