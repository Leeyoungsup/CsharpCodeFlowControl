using System;

namespace ConstantsAndEnumerations
{
    class Program
    {
        static void Main(string[] args)
        {
            //0:가위 1:바위 2:보
            Random rand = new Random();
            int aiChoice = rand.Next(0, 3); //0~2사이의 랜덤 값
            int Choice = Convert.ToInt32(Console.ReadLine());
            switch (Choice)
            {
                case 0:
                    Console.WriteLine("당신의 선택은 가위입니다");
                    break;
                case 1:
                    Console.WriteLine("당신의 선택은 바위입니다");
                    break;
                case 2:
                    Console.WriteLine("당신의 선택은 보입니다");
                    break;
                default:
                    Console.WriteLine("잘못입력하셨습니다");
                    break;
            }
            switch (aiChoice)
            {
                case 0:
                    Console.WriteLine("컴퓨터의 선택은 가위입니다");
                    break;
                case 1:
                    Console.WriteLine("컴퓨터의 선택은 바위입니다");
                    break;
                case 2:
                    Console.WriteLine("컴퓨터의 선택은 보입니다");
                    break;
            }
            //승리 , 무승부 ,패배
            if (Choice == aiChoice)
            {
                Console.WriteLine("무승부입니다.");
            }
            else if (Choice == (aiChoice + 1) % 3)
            {
                Console.WriteLine("이겼습니다");
            }
            else if (Choice == (aiChoice + 2) % 3)
            {
                Console.WriteLine("졌습니다");
            }
        }
    }
}
