using System;

namespace lesson7_函数
{
    class Program
    {
        static int GetMax(int a, int b)
        {
            return a >= b ? a : b;
        }
        static float[] CalCircle(float r)
        {
            float perimeter = 2f * r * (float)Math.PI;
            float area = (float)Math.PI * r * r;
            float[] arr = { perimeter, area };
            return arr;
        }
        static float[] CalArr(int[] arr)
        {
            float sum = 0, max = arr[0], min = arr[0];
            float avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];
                max = arr[i] >= max ? arr[i] : max;
                min = arr[i] <= min ? arr[i] : min;
            }
            avg = sum / arr.Length;
            float[] array = { sum, max, min, avg };
            return array;
        }
        static bool PrimeOrNot(int a)
        {
            for (int i = 2; i < a / 2; i++)
            {
               if (a % i == 0)
                  return false;
            }
            return true;
        }
        static bool LeapYearOrNot(int a)
        {
            if (a % 400 == 0 || (a % 4 == 0 && a % 100 != 0))
            {
                return true;
            }
            return false;
        }

        static void Main(string[] args)
        {
            //Console.WriteLine(GetMax(5, 90));

            //float[] array = CalCircle(3f);
            //Console.WriteLine("圆的周长为{0:f3}，面积为{1:f3}",array[0],array[1]);

            //int[] arr1 = { 12, 34, 7, 3, 678, 3412, 4 };
            //float[] outComeArr = CalArr(arr1);
            //Console.WriteLine("数组的总和是{0}，最大值是{1}，最小值是{2}，平均值是{3:f2}",outComeArr[0], 
            //    outComeArr[1], outComeArr[2], outComeArr[3]);

            //Console.WriteLine("请输入要判断的数字：");
            //int input = int.Parse(Console.ReadLine());
            //string outCome = PrimeOrNot(input) ?"是":"不是";
            //Console.WriteLine($"{input}{outCome}质数！");
            try
            {
                Console.WriteLine("请输入要判断的年份：");
                int inputYear = int.Parse(Console.ReadLine());
                string leapYearOrNot = LeapYearOrNot(inputYear) ? "是" : "不是";
                Console.WriteLine($"{inputYear}{leapYearOrNot}闰年！");
            }
            catch
            {
                Console.WriteLine("请输入正确格式的年份！");
            }
        }
    }
}
