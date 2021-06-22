using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp基础实践小项目
{
    class Program
    {


        static void Main(string[] args)
        {
            #region 控制台初始化
            int w = 50, h = 30;
            ConsoleInit(w, h);
            #endregion
            Console.WriteLine("hello wo!!");
        }
        #region 控制台初始化
        static void ConsoleInit(int weight, int height)
        {
            //光标隐藏
            Console.CursorVisible = false;
            //舞台大小
            Console.SetWindowSize(weight,height);
        }
        #endregion
    }
}
