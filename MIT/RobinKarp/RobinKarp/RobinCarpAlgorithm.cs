using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RobinKarp
{
    public class RobinCarpAlgorithm
    {
        public static void RabinKarp(string A, string B)
        {
            ulong siga = 0;
            ulong sigb = 0;
            ulong Q = 107;
            ulong D = 256;
            for (int i = 0; i < B.Length; i++)
            {
                siga = (siga * D + (ulong)A[i]) % Q;
                sigb = (sigb * D + (ulong)B[i]) % Q;
            }
            if (siga == sigb)
            {
                Console.WriteLine(string.Format(">>{0}<<{1}", A.Substring(0, B.Length), A.Substring(B.Length)));
                return;
            }
            ulong pow = 1;
            for (int k = 1; k <= B.Length - 1; k++)
                pow = (pow * D) % Q;

            for (int j = 1; j <= A.Length - B.Length; j++)
            {
                siga = (siga + Q - pow * (ulong)A[j - 1] % Q) % Q;
                siga = (siga * D + (ulong)A[j + B.Length - 1]) % Q;
                if (siga == sigb)
                {
                    if (A.Substring(j, B.Length) == B)
                    {
                        Console.WriteLine("found");
                        return;
                    }
                }
            }
        }
    }
}
