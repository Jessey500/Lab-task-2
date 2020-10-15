using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Second_Task
{
    class Program
    {
        static void Main(string[] args)
        {
            //NO.1
            int n = 20;
            for (int i = 1; i <= n; i++)
            {
                if (i % 2 == 0)
                    Console.WriteLine("even : " + i);
            }
            //NO.2
            for (int j = 1; j <= 2; j++)
            {
                Console.WriteLine("X0X0X0");
                Console.WriteLine("0X0X0X");
            }
            //NO.3
            int rows = 5;
            int cols = 5;
            int m;
            int s;
            for (m = 1; m <= rows; m++)
            {
                for (s = m; s < m + cols; s++)
                {
                    Console.Write(s);
                }

                Console.WriteLine("\n");
            }
            //NO.4
            int ik, odd_sum = 0, even_sum = 0, num = 100;

            for (ik = 1; ik <= num; ik++)
            {
                if (ik % 2 == 0)
                    even_sum = even_sum + ik;
                else
                    odd_sum = odd_sum + ik;
            }
            Console.WriteLine("Sum of all odd numbers  = " + odd_sum + "\n");
            Console.WriteLine("Sum of all even numbers = " + even_sum + "\n");
            //NO.5
            int ir, jr, rowsR = 5;
            for (ir = 1; ir <= rowsR; ++ir)
            {
                for (jr = 1; jr <= ir; ++jr)
                {
                    if (jr == ir)
                    {
                        for (int lr = 1; lr < jr; lr++)
                        {
                            Console.Write(" ");
                        }
                        Console.Write(jr);
                    }
                }
                Console.WriteLine("\n");
            }
            //NO.6
            int num6 = 5, sum6 = 1;
            for (int i6 = 1; i6 <= num6; i6++)
            {
                sum6 = sum6 * i6;
            }
            Console.WriteLine("Factorial : " + sum6);
            //NO.7
            int i7, j7, N7 = 5;
            for (i7 = 1; i7 <= N7; i7++)
            {
                for (j7 = 1; j7 <= i7; j7++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
            for (i7 = N7 - 1; i7 >= 1; i7--)
            {
                for (j7 = 1; j7 <= i7; j7++)
                {
                    Console.Write("*");
                }
                Console.WriteLine("\n");
            }
        }
    }
}
