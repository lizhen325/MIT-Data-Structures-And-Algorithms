using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    class Program
    {
        static void Main(string[] args)
        {
            Fibonacci fibo = new Fibonacci();
            long [] res = fibo.FibonacciNumbers(50);
            foreach (var i in res)
                Console.Write(i + ", ");
            Console.ReadKey();
        }
    }
}
