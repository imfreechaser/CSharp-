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
            #region Pratice2

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
            //        if (j == 3)
            //            Console.WriteLine();
            //    }
            //}

            #endregion
            #region Practice3

            int[,] array = new int[3, 3];
            Random r = new Random();
            
            for(int i = 0; i < array.GetLength(0); i++)
            {
                for(int j = 0; j < array.GetLength(1); j++)
                {
                    array[i, j] = r.Next(1, 11);
                    Console.Write($"{array[i, j]}\t");
                    if (j == 2)
                        Console.WriteLine();
                }
            }

            #endregion
        }
    }
}
