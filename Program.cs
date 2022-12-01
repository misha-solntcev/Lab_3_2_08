using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/* 8. Найти все целые числа из промежутка от 200 до 500, 
    у которых ровно шесть делителей. */

namespace Lab_3_2_08
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for (int i = 500; i >= 200; i--)
            {
                int count = 0;
                for (int j = 1; j <= i; j++)
                {
                    if (i % j == 0)
                    {
                        count++;
                    }
                }
                if (count == 6)
                    Console.WriteLine($"i={i}, count={count}");
            }
            Console.ReadKey();
        }
    }
}
