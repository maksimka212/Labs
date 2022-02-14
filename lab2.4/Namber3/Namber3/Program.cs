using System;
using static System.Console;
namespace Namber3
{
    class Program
    {
        static void Main(string[] args)
        {
            WriteLine();
            int a = Convert.ToInt32(ReadLine());
            int b = Convert.ToInt32(ReadLine());
            int A = a;
            int B = b;
            int n_a = 0;
            int n_b = 0;
            do
            {
                a = a / 10;
                n_a++;
            } while (a > 0);
            
            do
            {
                b = b / 10;
                n_b++;
            } while (b > 0);
            if (n_a > n_b)
            {
                WriteLine(A);
            }
            if (n_a < n_b)
            {
                WriteLine(B);
            }
            else
                WriteLine("Они равны.");
        }
    }
}
