using System;

namespace lesson2_数组
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Practice1

            //int[] arrayA = new int[100];

            //for (int i = 0; i < 100; i++)
            //{
            //    arrayA[i] = i;
            //}

            #endregion
            #region Practice2

            //int[] arrayB = new int[100];
            //for(int i = 0;i < arrayA.Length; i++)
            //{
            //    arrayB[i] = arrayA[i] * 2;
            //    Console.WriteLine(arrayB[i]);
            //}

            #endregion
            #region Practice3

            //Random r = new Random();
            //int[] array = new int[10];
            //for (int i = 0; i < array.Length; i++)
            //{
            //    array[i] = r.Next(0, 101);
            //    Console.WriteLine(array[i]);
            //}

            #endregion
            #region Practice4

            //int arrMax = array[0], arrMin = array[0];
            //int arrSum = 0;
            //float arrAvg = 0f;

            //for(int i = 0; i < array.Length; i++)
            //{
            //    arrMax = array[i] >= arrMax ? array[i] : arrMax;
            //    arrMin = array[i] <= arrMin ? array[i] : arrMin;
            //    arrSum += array[i];
            //}
            //arrAvg = arrSum / (float)array.Length;
            //Console.WriteLine($"最大值：{arrMax}，最小值：{arrMin}，总和：{arrSum}，平均值：{arrAvg}");
            #endregion
            #region Practice5

            //int[] array = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //int midVel = 0;

            //for(int i = 0; i < array.Length / 2; i++)
            //{
            //    midVel = array[i];
            //    array[i] = array[array.Length - 1 - i];
            //    array[array.Length - 1 - i] = midVel;
            //}
            //for(int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            #endregion
            #region Practice6

            //int[] array = { -5, -4, -3, -2, -1, 0, 1, 2, 3, 4, 5 };
            //for(int i = 0; i < array.Length; i++)
            //{
            //    if(array[i] > 0)
            //    {
            //        array[i] += 1;
            //    }
            //    else if(array[i] < 0)
            //    {
            //        array[i] -= 1;
            //    }
            //    Console.WriteLine(array[i]);
            //}

            #endregion
            #region Practice7

            //int[] mathGrade = new int[10];
            //for(int i = 0; i< mathGrade.Length; i++)
            //{
            //    try
            //    {
            //        Console.Clear();
            //        Console.WriteLine("请输入第{0}位同学的数学成绩：", i + 1);
            //        mathGrade[i] = int.Parse(Console.ReadLine());
            //    }
            //    catch
            //    {
            //        Console.WriteLine("请输入正确格式的成绩！");
            //    }
            //}
            //int gradeMax = mathGrade[0], gradeMin = mathGrade[0];
            //int maxIndex = 0, minIndex = 0;
            //float gradeAvg = 0;
            //int gradeSum = 0;
            //for(int i = 0; i < mathGrade.Length; i++)
            //{
            //    if(mathGrade[i] >= gradeMax)
            //    {
            //        gradeMax = mathGrade[i];
            //        maxIndex = i + 1;
            //    }
            //    if(mathGrade[i] <= gradeMin)
            //    {
            //        gradeMin = mathGrade[i];
            //        minIndex = i + 1;
            //    }
            //    gradeSum += mathGrade[i];
            //}
            //gradeAvg = gradeSum / (float)mathGrade.Length;
            //Console.WriteLine($"班级最高分为第{maxIndex}位同学的{gradeMax}分，班级最低分为第{minIndex}位同学的{gradeMin}分，" +
            //    $"班级平均分为{gradeAvg}");
            #endregion
            #region Practice8

            //string[] chessGame = new string[25];

            //for(int i = 0;i < chessGame.Length; i++)
            //{
            //    chessGame[i] = i % 2 != 0 ? "□" : "■";
            //    if (i % 5 == 0 && i != 0)
            //        Console.WriteLine();
            //    Console.Write(chessGame[i]);
            //}

            #endregion
        }
    }
}
