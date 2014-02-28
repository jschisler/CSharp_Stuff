using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Algorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 5, 2, 4, 6, 1, 3 };
            int[] sorted = new int[A.Length];
            int i = 0, key;

            for (int j=1; j < A.Length; j++)
            {
                key = A[j];
                i = j - 1;

                while (i > 0 && A[i] > key)
                {
                    A[i + 1] = A[i];
                    i--;
                }
                A[i + 1] = key;
            }

            int breakpoint = 1;
        }
    }
}
