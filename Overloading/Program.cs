using System;

namespace Overloading
{
    class Program
    {
        //함수 이름의 재사용
        static int Add(int a, int b,int c=0,float d= 0.0f,double e=3.0)
        {
            Console.WriteLine("Add int 3호출");
            return a + b+c;

        }
        static float Add(float a, float b)
        {
            Console.WriteLine("Add float 호출");
            return a + b;
        }
        static void Main(string[] args)
        {
            int ret= Program.Add(2, 3,2);
            float ret1 = Program.Add(2.0f, 3.0f);
            Console.WriteLine(ret1);
        }
    }
}
