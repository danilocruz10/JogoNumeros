using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoNumeros
{
    static class Program
    {
        static void Main(string[] args)
        {
            for (int i = 1; i <= 100; i++)
            {
                bool tres = i.Multiplica(3);
                bool cinco = i.Multiplica(5);

                if (cinco && tres)
                {
                    Console.WriteLine("{0}: FizzBuzz", i);
                }
                else if (tres)
                {
                    Console.WriteLine("{0}: Fizz", i);
                }
                else if (cinco)
                {
                    Console.WriteLine("{0}: Buzz", i);
                }
                else
                {
                    Console.WriteLine(i);
                }
            }
            Console.ReadLine();
        }

        private static bool Multiplica(this int sourceNumber, int targetNumber)
        {
            return (sourceNumber % targetNumber) == 0;
        }
    }
}
