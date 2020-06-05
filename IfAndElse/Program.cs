using System;

namespace IfAndElse
{
    class Program
    {
        static void Main(string[] args)
        {
            int hp = 10;
            bool isDead = (hp <= 0);
            if (isDead)
            {
                Console.WriteLine("Yor are dead!");
            }
            else
            {
                Console.WriteLine("You are alive!");
            }
            int Choice = 2; //0:가위 1:바위 2:보
            if (Choice== 0)
            {
                Console.WriteLine("가위입니다.");
            }
            else if (Choice == 1)
            {
                Console.WriteLine("바위입니다.");
            }
            else if (Choice == 2)
            {
                Console.WriteLine("보입니다.");
            }
        }   
    }
}
