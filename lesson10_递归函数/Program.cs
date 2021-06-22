using System;

namespace lesson10_递归函数
{
    class Program
    {
        static void Print(int num)
        {
            if(num > 10)
            {
                return;
            }
            Console.WriteLine(num);
            num++;
            Print(num);
        }
        static int Factorial(int val)
        {
            if (val > 1)
            {
                int multi = 1;
                for (int i = val; i > 0; i--)
                {
                    multi *= i;
                }
                return multi + Factorial(val - 1);
            }
            else
                return 1;
        }
        static float Bamboo(int count)
        {
            if (count > 0)
            {
                count--;
                return 1f / 2f * Bamboo(count);
            }
            else
                return 100;
        }
        static void Print1To200(int a)
        {
            if (a == 0)
                return;
            Print1To200(a-1);
            Console.WriteLine(a);
        }
        static void Main(string[] args)
        {
            //Print(0);
            //Console.WriteLine(Factorial(5));
            //Console.WriteLine(Factorial(10));
            //Console.WriteLine(Bamboo(10));
            Print1To200(200);
        }
    }
}
