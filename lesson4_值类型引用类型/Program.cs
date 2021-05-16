using System;

namespace lesson4_值类型引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Practice1

            //int a = 10;
            //int b = a;
            //b = 20;
            //Console.WriteLine(a);

            #endregion
            #region Practice2

            //int[] a = new int[] { 10 };
            //int[] b = a;
            //b[0] = 20;
            //Console.WriteLine(a[0]);

            #endregion
            #region Practice3

            string str = "1234";
            string str2 = str;
            str2 = "321";
            Console.WriteLine(str);

            #endregion
        }
    }
}
