using System;

namespace 必备知识点_控制台相关
{
    class Program
    {
        static void Main(string[] args)
        {
            //设置初始点位置
            int heroX = 0, heroY = 0;
            //设置背景颜色
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            //设置字体颜色
            Console.ForegroundColor = ConsoleColor.Yellow;
            //隐藏光标
            Console.CursorVisible = false;
            while (true)
            {
                Console.SetCursorPosition(heroX, heroY);
                Console.Write("■");
                char inputDirection = Console.ReadKey(true).KeyChar;//不显示输入内容

                Console.SetCursorPosition(heroX, heroY);//回到上一次的光标位置
                Console.Write("  ");//打印空格-->擦除/覆盖原来打印的方块

                switch (inputDirection)
                {
                    case 'w':
                    case 'W':
                        heroY--;
                        break;
                    case 's':
                    case 'S':
                        heroY++;
                        break;
                    case 'A':
                    case 'a':
                        heroX -= 2;
                        break;
                    case 'D':
                    case 'd':
                        heroX += 2;
                        break;
                }
                //边界控制
                if (heroX < 0)
                    heroX = 0;
                else if (heroX > Console.WindowWidth - 2)
                    heroX = Console.WindowWidth - 2;
                if (heroY < 0)
                    heroY = 0;
                else if (heroY > Console.WindowHeight - 1)
                    heroY = Console.WindowHeight - 1;

                //退出程序
                if(inputDirection == 'q')
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
