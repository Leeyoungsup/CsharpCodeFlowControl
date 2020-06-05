using System;
using System.Runtime.Serialization;

namespace Switch
{
    class Program
    {
        static void Main(string[] args)
        {
            int Choice = 2; //0:가위 1:바위 2:보
            switch(Choice)
            {
                case 0:
                    Console.WriteLine("가위입니다.");
                    break;
                case 1:
                    Console.WriteLine("바위입니다.");
                    break;
                case 2:
                    Console.WriteLine("보입니다");
                    break;
                case 3:
                    Console.WriteLine("치트키입니다");
                    break;
                default:
                    Console.WriteLine("다 실패했습니다.");
                    break;
            }
            //삼항연산자
            int number = 25;
            bool isPair=((number %2)==0 ? true:false);
            
        }
    }
}
