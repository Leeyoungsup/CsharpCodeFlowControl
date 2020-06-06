using System;

namespace ConstantsAndEnumerations
{
    class Program
    {
        enum Choice
        {
            Rock=1,
            Paper=2,
            Scissors=0
        }
        static void Main(string[] args)
        {
            //const int Rock=1;
            //const int Paper=2;
            //const int Scissors=0;
            //0:가위 1:바위 2:보
            Random rand = new Random();
            int aiChoice = rand.Next(0, 3); //0~2사이의 랜덤 값
            int choice = Convert.ToInt32(Console.ReadLine());
            switch (choice)
            {
                case (int)Choice.Scissors:
                    Console.WriteLine("당신의 선택은 가위입니다");
                    break;
                case (int)Choice.Rock:
                    Console.WriteLine("당신의 선택은 바위입니다");
                    break;
                case (int)Choice.Paper:
                    Console.WriteLine("당신의 선택은 보입니다");
                    break;
                default:
                    Console.WriteLine("잘못입력하셨습니다");
                    break;
            }
            switch (aiChoice)
            {
                case (int)Choice.Scissors:
                    Console.WriteLine("컴퓨터의 선택은 가위입니다");
                    break;
                case (int)Choice.Rock:
                    Console.WriteLine("컴퓨터의 선택은 바위입니다");
                    break;
                case (int)Choice.Paper:
                    Console.WriteLine("컴퓨터의 선택은 보입니다");
                    break;
            }
            //승리 , 무승부 ,패배
            if (choice == aiChoice)
            {
                Console.WriteLine("무승부입니다.");
            }
            else if (choice == (aiChoice + 1) % 3)
            {
                Console.WriteLine("이겼습니다");
            }
            else if (choice == (aiChoice + 2) % 3)
            {
                Console.WriteLine("졌습니다");
            }
        }
    }
}
