using System;
using System.Diagnostics.CodeAnalysis;
using System.Linq;

namespace Task
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region Task 1
            int i;
            for (i = 0; i < 10; i++)
            {
                Console.WriteLine(i);
            }
            #endregion

            #region Task 2
            int n;
            for (n = 25; n < 94; n++)
            {
                Console.WriteLine(n);
            }

            #endregion
            #region Task 3
            int a = 25;
            int b = 94;
            for (i = a; i <= b; i++)
            {
                if (a % 3 == 0 || a % 4 == 0)
                {
                    Console.WriteLine(i);
                }
            }
            #endregion
            #region Task 4
            int sum = 0;
            for (int t = 25; t < 94; t++)
            {
                sum += t;
            }
            Console.WriteLine(sum);

            #endregion
            #region Task 5
            int x = 25;
            int y = 94;
            int cem = 0;

            for (int c = x; c < 94; c++)
            {
                cem += c;
            }
            Console.WriteLine(cem / y - x);
            #endregion
            #region Task 6
            int[] arr = { 14, 21, 36, 47 };
            foreach (int item in arr)
            {
                Console.WriteLine(item);
            }
            #endregion

            #region Task 8
            // 1-ci üsul
            int[] arr1 = { 14, 21, 36, 47 };
            int sum1 = 0;
            for (int i1 = 0; i1 < arr1.Length; i1++)
            {
                sum1 += arr1[i1];
            }
            Console.WriteLine(sum1);

            //2 - ci üsul
            int[] arr3 = { 14, 21, 36, 47 };
            int sum2 = 0;
            foreach (int item in arr3)
            {
                sum2 += item;
            }
            Console.WriteLine(sum2);
            #endregion
            #region Task 9
            int[] arr4 = { 14, 21, 36, 47 };
            double sum4 = 0;
            int count = 0;
            for (int i2 = 0; i2 < arr4.Length; i2++)
            {
                sum4 += arr4[i2];
                count++;
            }
            Console.WriteLine(sum4 / count);
            #endregion
        }
    }
}
