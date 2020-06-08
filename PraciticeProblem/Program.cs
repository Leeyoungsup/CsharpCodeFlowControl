using System;
using System.Globalization;

namespace PraciticeProblem
{
    class Program
    {
        static void Gugudan()
        {
            for (int i = 2; i < 10; i++)
            {
                for (int j = 1; j < 10; j++)
                {
                    int result = i * j;
                    Console.WriteLine($"{i} x {j} = {result}");
                }
            }
        }
        static void Staring()
        {
            for(int i=0;i<5;i++)
            {
                for (int j=0;j<=i;j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        static void Factorial(int a)
        {
            int result=1;
            for(int i =a;i>0;i--)
            {
                result = result * i;
            }
            Console.WriteLine(result);
        }
        static void Main(string[] args)
        {
            Factorial(4);
        }
    }
}
