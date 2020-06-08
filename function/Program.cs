using System;
using System.ComponentModel;

namespace function
{
    class Program
    {
        //Method 함수
        static void Helloworld()
        {
            Console.WriteLine("HelloWorld");
        }
        static int Add(int a, int b)
        {
            int result = a + b;
;           return result;
            
        }
        static void AddOne(ref int number)
        {
            number = number + 1;
        }
        static void Main(string[] args)
        {
            int a = 4;
            int b = 5;
            Program.AddOne(ref a);

            Console.WriteLine(a);
            //4,5=>9
        }
    }
}
