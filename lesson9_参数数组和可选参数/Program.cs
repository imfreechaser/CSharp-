using System;

namespace lesson9_参数数组和可选参数
{
    class Program
    {
        #region Practice1
        static void SumAndAvg(params int[] arr)
        {
            int sum = 0;
            float avg = 0;
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
                sum += arr[i];
            }
            Console.WriteLine("sum:{0}",sum);
            avg = (float)sum / arr.Length;
            Console.WriteLine("avg:{0}", avg);
        }
        #endregion
        #region Practice2

        static void EvenAndOddSum(params int[] arr)
        {
            int evenSum = 0, oddSum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == 0)
                {
                    evenSum += arr[i];
                }
                else
                    oddSum += arr[i];
            }
            Console.WriteLine("偶数和是{0}，奇数和是{1}", evenSum, oddSum);
        }

        #endregion

        static void Main(string[] args)
        {
            SumAndAvg(1,2,9,4,5);
            EvenAndOddSum(1, 2, 3, 4, 5, 6, 7, 8);
        }
    }
}
