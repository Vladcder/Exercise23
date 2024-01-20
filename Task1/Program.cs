using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task1
{
    internal class Program
    {
        
        static void Factorial(int n)
        {
            long fact = 1;
            for (int i = 1; i <= n; i++)
            {
                fact *= i;
                Thread.Sleep(100);
            }
            Console.WriteLine(fact);
        }

      
        static async void FactorialAsync(int n)
        {
             await Task.Run(() => Factorial(n));
        }

      


        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
           FactorialAsync(n);
            Console.ReadKey();
        }


    }
}
