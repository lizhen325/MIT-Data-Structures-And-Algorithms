using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DynamicProgramming
{
    public class Fibonacci
    {
        public long[] FibonacciNumbers(int n)
        {
            long[] fibo = new long[n + 1];
            fibo[0] = 0;
            fibo[1] = 1;
            for (int i = 2; i < n + 1; i++)
                fibo[i] = fibo[i - 1] + fibo[i - 2];
            return fibo;
        }
    }
}
