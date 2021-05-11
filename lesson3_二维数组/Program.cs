using System;

namespace lesson3_二维数组
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Practice1

            //int[,] array = new int[100, 100];
            //int count = 1;

            //for(int i = 0;i < array.GetLength(0); i++)
            //{
            //    for(int j = 0;j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = count;
            //        count++;
            //        Console.Write($"array[{i},{j}]:{array[i,j]}\t");
            //    }
            //}

            #endregion
            #region Practice2

            //int[,] array = new int[4, 4];
            //Random r = new Random();

            //for(int i = 0; i < array.GetLength(0); i++)
            //{
            //    for(int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = r.Next(1, 101);
            //        if ((i == 0 || i == 1) && (j == 2 || j == 3))
            //            array[i, j] = 0;
            //        Console.Write($"{array[i, j]}\t");
            //    }
            //    Console.WriteLine();
            //}

            #endregion
            #region Practice3

            //int[,] array = new int[3, 3];
            //Random r = new Random();
            //int sum = 0;

            //for(int i = 0; i < array.GetLength(0); i++)
            //{
            //    for(int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = r.Next(1, 11);
            //        Console.Write($"{array[i, j]}\t");
            //        if ((i == j) || (j + j == 2))//对角线的行列号规律
            //            sum += array[i, j];
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"Sum:{sum}");

            #endregion
            #region Practice4

            //int[,] array = new int[5, 5];
            //Random r = new Random();
            //int arrMax = array[0, 0];
            //int maxHor = 0, maxVer = 0;

            //for(int i = 0; i < array.GetLength(0); i++)
            //{
            //    for(int j = 0; j < array.GetLength(1); j++)
            //    {
            //        array[i, j] = r.Next(1, 501);
            //        if(array[i, j] >= arrMax)
            //        {
            //            arrMax = array[i, j];
            //            maxHor = i;
            //            maxVer = j;
            //        }
            //        Console.Write($"{array[i,j]}\t");
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine($"最大元素是{arrMax},在第{maxHor+1}行第{maxVer+1}列");

            #endregion
            #region Practice5

            int M = 5, N = 5;
            int[,] array = new int[M, N];
            Random r = new Random();
            bool[] hang = new bool[M];
            bool[] lie = new bool[N];

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = r.Next(0, 2);
                    Console.Write($"{array[i,j]}\t");
                    if(array[i, j] == 1)
                    {
                        hang[i] = true;
                        lie[j] = true;
                    }
                }
                Console.WriteLine();
            }
            Console.WriteLine();

            for (int i = 0; i < array.GetLength(0); i++)
            {
                for (int j = 0; j < array.GetLength(1); j++)
                {
                    if (hang[i] || lie[j])
                        array[i, j] = 1;
                    Console.Write($"{array[i, j]}\t");
                }
                Console.WriteLine();
            }
            #endregion
        }
    }
}
