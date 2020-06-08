using System;
using System.Xml;

namespace BreakContinue
{
    class Program
    {
        static void Main(string[] args)
        {
            //int num = 97;//1,97로만 나뉘는 숫자
            ////4=2*2
            ////11
            //bool isPrime = true;
            //for (int i=2;i<num; i++)
            //{
            //    //특정조건
            //    if ((num % i) ==0)
            //    {
            //        isPrime = false;
            //        break;
            //    }
            //}
            //if(isPrime)
            //{
            //    Console.WriteLine("소수입니다.");
            //}
            //else
            //    Console.WriteLine("소수가 아닙니다");
            for (int i = 1; i <= 100; i++)
            {
                if ((i % 3) != 0)
                {
                    continue;
                }

                Console.WriteLine($"3으로 나뉘는 숫자 발견: {i}");
            }

         
        }
    }
}
