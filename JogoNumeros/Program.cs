using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JogoNumeros
{
    class Program
    {
        static void Main(string[] args)
        {
            int num;

            Console.WriteLine("Digite um Número");
            num = int.Parse(Console.ReadLine());
            //conta a quantidade de divisíveis
            for (int cont = 1; cont <= num/3; cont++)

            if (cont !=3)
            {
               
                Console.WriteLine ("Fizz");
            }
            for (int cont = 1; cont <= num/5; cont++)

            if (cont !=5)
            {
                
                Console.WriteLine("Buzz");
            }
            
            Console.ReadKey();
            
        }
    }
}
