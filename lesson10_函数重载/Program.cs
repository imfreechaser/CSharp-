using System;

namespace lesson10_函数重载
{
    class Program
    {
        static int GetMax(int a, int b)
        {
            return a >= b ? a : b;
        }
        static float GetMax(float a, float b)
        {
            return a >= b ? a : b;
        }
        static double GetMax(double a, double b)
        {
            return a >= b ? a : b;
        }

        static int GetArrMax(params int[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("没有传参！");
                return 0;
            }
            else
            {
                int max = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    max = arr[i] >= max ? arr[i] : max;
                }
                return max;
            }
        }
        static float GetArrMax(params float[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("没有传参！");
                return 0;
            }
            else
            {
                float max = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    max = arr[i] >= max ? arr[i] : max;
                }
                return max;
            }
        }
        static double GetArrMax(params double[] arr)
        {
            if (arr.Length == 0)
            {
                Console.WriteLine("没有传参！");
                return 0;
            }
            else
            {
                double max = arr[0];
                for (int i = 0; i < arr.Length; i++)
                {
                    max = arr[i] >= max ? arr[i] : max;
                }
                return max;
            }
        }

        static void Main(string[] args)
        {
            Console.WriteLine(GetMax(1,3));
            Console.WriteLine(GetMax(1.9f, 3.9f));
            Console.WriteLine(GetMax(123.4, 386.1));
            Console.WriteLine("************************");
            Console.WriteLine(GetArrMax(1,2,3,4,5,6,7,99));
            Console.WriteLine(GetArrMax(3,5f,95.7f,43,6f,2.509f));
            Console.WriteLine(GetArrMax(3.5, 95.7, 43, 6, 250.9));
        }
    }
}
