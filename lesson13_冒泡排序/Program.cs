using System;

namespace lesson13_冒泡排序
{
    class Program
    {
        #region Practice2
        public static int[] SortArray(int[] arr,bool isAscendingOrder)
        {
            bool isSort = false;
            int midvar;
            bool condition;

            for (int m = 0; m < arr.Length; m++)
            {
                isSort = false;
                for (int i = 0; i < arr.Length - 1 - m; i++)
                {
                    condition = isAscendingOrder ? arr[i] > arr[i + 1] : arr[i] < arr[i + 1];
                    if (condition)
                    {
                        midvar = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = midvar;
                    }
                    isSort = true;
                }
                if (!isSort)
                    break;
            }
            return arr;
        }
        #endregion
        static void Main(string[] args)
        {
            #region lesson
            //int[] arr = new int[] { 8, 7, 1, 5, 4, 2, 6, 3, 9 };
            //bool isSort = false;

            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            ////冒泡排序
            //for (int n = 0; n < arr.Length; n++)
            //{
            //    isSort = false;
            //    for (int i = 0; i < arr.Length - 1 - n; i++)
            //    {
            //        int midVar;
            //        if (arr[i] > arr[i + 1])
            //        {
            //            isSort = true;
            //            midVar = arr[i];
            //            arr[i] = arr[i + 1];
            //            arr[i + 1] = midVar;
            //        }
            //    }
            //    if (!isSort)//优化：如果有一轮完全没有交换，则证明排序已经完成，不需要进行后面的循环，直接跳出；
            //        break;
            //}
            //Console.WriteLine("****************************************");
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            #endregion
            #region Practice1

            //int[] arr = new int[20];
            //Random r = new Random();
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    arr[i] = r.Next(0, 101);
            //    Console.Write($"{arr[i]}\t");
            //}
            //Console.WriteLine("******************************************");
            ////冒泡升序排列
            //bool isSort = false;
            //for(int m = 0; m < arr.Length; m++)
            //{
            //    isSort = false;
            //    for (int i = 0; i < arr.Length - 1 - m; i++)
            //    {
            //        if (arr[i] > arr[i + 1])
            //        {
            //            int midvar;
            //            midvar = arr[i];
            //            arr[i] = arr[i + 1];
            //            arr[i + 1] = midvar;
            //            isSort = true;
            //        }
            //    }
            //    if (!isSort)
            //        break;
            //}
            ////打印数组元素
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            ////冒泡降序排列
            //for (int m = 0; m < arr.Length; m++)
            //{
            //    isSort = false;
            //    for (int i = 0; i < arr.Length - 1 - m; i++)
            //    {
            //        if (arr[i] < arr[i + 1])
            //        {
            //            int midvar;
            //            midvar = arr[i];
            //            arr[i] = arr[i + 1];
            //            arr[i + 1] = midvar;
            //            isSort = true;
            //        }
            //    }
            //    if (!isSort)
            //        break;
            //}
            ////打印数组元素
            //for (int i = 0; i < arr.Length; i++)
            //{
            //    Console.WriteLine(arr[i]);
            //}
            #endregion
            #region Practice3
            int[] arr = new int[] { 3, 5, 2, 8, 2, 7, 3, 50, 34, 56, 5 };
            int[] arr1 = SortArray(arr, true);
            for (int i = 0; i < arr1.Length; i++)
            {
                Console.WriteLine(arr1[i]);
            }
            #endregion

        }
    }
}
