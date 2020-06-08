using System;

namespace While
{
    class Program
    {
        static void Main(string[] args)
        {
            //while 반복문
            int count = 5;
            //while (count > 0)
            //{
            //    Console.WriteLine("Hello World!");
            //    count --;
            //}
            string answer;
            do
            {
                Console.WriteLine("are you?(y/n):");
                answer = Console.ReadLine();
            } while (answer !="y");
            Console.WriteLine("정답입니다.");
        }
    }
}
