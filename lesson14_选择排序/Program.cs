using System;

namespace lesson14_选择排序
{
    class Program
    {
        static void Main(string[] args)
        {
            #region classPractice
            //int[] array = new int[] { 3, 5, 2, 8, 7, 6, 4, 9, 10, 48 };
            //int index;
            //int midvar;

            //for (int n = 0; n < array.Length; n++)//n为轮数
            //{
            //    index = 0;
            //    for (int i = 1; i < array.Length - n; i++)
            //    {
            //        //与每一个数相比较，若对方大则记住对方索引号
            //        if (array[i] > array[index])
            //        {
            //            index = i;
            //        }
            //    }
            //    //与这轮最后一个数比较完毕后，交换索引位置与最后一位的元素；
            //    if (index != array.Length - n - 1)
            //    {
            //        midvar = array[array.Length - n - 1];
            //        array[array.Length - n - 1] = array[index];
            //        array[index] = midvar;
            //    }
            //}

            ////打印数组
            //for (int i = 0; i < array.Length; i++)
            //{
            //    Console.WriteLine(array[i]);
            //}
            #endregion
            #region Practice1
            //创建数组并初始化
            int[] arr = new int[20];
            Random r = new Random();
            for (int i = 0; i < arr.Length; i++)
            {
                arr[i] = r.Next(0, 101);
                Console.Write(arr[i] + " ");
            }
            Console.WriteLine();

            //选择排序-升序
            //int index;
            //int midvar;
            //for (int n = 0; n < arr.Length; n++)
            //{
            //    index = 0;
            //    for (int i = 1; i < arr.Length - n; i++)
            //    {
            //        if(arr[index] < arr[i])
            //        {
            //            index = i;
            //        }
            //    }
            //    if(index != arr.Length - 1 - n)
            //    {
            //        midvar = arr[arr.Length - 1 - n];
            //        arr[arr.Length - 1 - n] = arr[index];
            //        arr[index] = midvar;
            //    }
            //}

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}

            //选择排序-降序
            int index;
            int midvar;
            for (int n = 0; n < arr.Length; n++)
            {
                index = 0;
                for (int i = 1; i < arr.Length - n; i++)
                {
                    if (arr[index] > arr[i])
                    {
                        index = i;
                    }
                }
                if (index != arr.Length - 1 - n)
                {
                    midvar = arr[arr.Length - 1 - n];
                    arr[arr.Length - 1 - n] = arr[index];
                    arr[index] = midvar;
                }
            }

            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }
            #endregion
        }
    }
}
