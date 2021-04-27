using System;

namespace 入门实践
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 控制台基础设置
            //隐藏光标
            Console.CursorVisible = false;
            //设置舞台大小
            int width = 50, height = 30;
            Console.SetWindowSize(width, height);
            Console.SetBufferSize(width, height);
            #endregion

            #region 设置多个场景

            int instantSceneID = 1;//1开始场景 2游戏场景 3结束场景
            char inputDirection;
            //bool isEnterDown = false;
            //int buttonX = 20, buttonY = 12;
            int buttonId = 0;
            bool isQuit = false;

            while (true)
            {
                switch (instantSceneID)
                {
                    case 1:
                        Console.Clear();
                        //游戏标题
                        Console.SetCursorPosition(width / 2 - 7, 7);
                        Console.WriteLine("唐老师营救公主");
                        //开始场景逻辑搭建
                        #region 自己的实现方法
                        //startSceneStatus1();
                        //while (true)
                        //{
                        //    inputDirection = Console.ReadKey(true).KeyChar;

                        //    switch (inputDirection)
                        //    {
                        //        case 'w':
                        //        case 'W':
                        //            instantSceneID = 2;
                        //            startSceneStatus1();
                        //            break;
                        //        case 's':
                        //        case 'S':
                        //            instantSceneID = 3;
                        //            startSceneStatus2();
                        //            break;
                        //        case ' ':
                        //            isEnterDown = true;
                        //            break;
                        //    }
                        //    if (isEnterDown)
                        //    {
                        //        break;
                        //    }
                        //}
                        //break;

                        #endregion
                        #region 老师的优化方法

                        while (true)
                        {
                            Console.SetCursorPosition(width / 2 - 4, 12);
                            Console.ForegroundColor = buttonId == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.WriteLine("开始游戏");

                            Console.SetCursorPosition(width / 2 - 4, 14);
                            Console.ForegroundColor = buttonId == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.WriteLine("退出游戏");

                            inputDirection = Console.ReadKey(true).KeyChar;
                            switch (inputDirection)
                            {
                                case 'w':
                                case 'W':
                                    buttonId--;
                                    if (buttonId < 0)
                                        buttonId = 0;
                                    break;
                                case 's':
                                case 'S':
                                    buttonId++;
                                    if (buttonId > 1)
                                        buttonId = 1;
                                    break;
                                case ' ':               //按下确定键
                                    if (buttonId == 0)
                                    {
                                        instantSceneID = 2;
                                        isQuit = true;
                                        break;
                                    }
                                    else
                                        Environment.Exit(0);
                                    break;
                            }
                            if (isQuit)
                                break;
                        }
                        break;

                    #endregion

                    case 2:
                        Console.Clear();

                        #region 不变的红墙

                        Console.ForegroundColor = ConsoleColor.Red;
                        //int widthAmount = width / 2;

                        for (int i = 0; i <= width - 2; i+=2)
                        {
                            //最上方的墙
                            Console.SetCursorPosition(i, 0);
                            Console.Write("■");
                            //中间的墙
                            Console.SetCursorPosition(i, height - 6);
                            Console.Write("■");
                            //底部的墙
                            Console.SetCursorPosition(i, height - 1);
                            Console.Write("■");
                        }
                        for (int i = 0; i < height - 1; i++)
                        {
                            //左边的墙
                            Console.SetCursorPosition(0, i);
                            Console.WriteLine("■");
                            //右边的墙
                            Console.SetCursorPosition(width - 2, i);
                            Console.Write("■");
                        }

                        #endregion

                        #region Boss属性相关

                        //boss位置
                        int bossX = 24, bossY = 15;
                        //boss攻击力
                        int bossAtkMin = 7, bossAtkMax = 13;
                        //血量
                        int bossHp = 100;
                        //boss图标
                        string bossIcon = "■";
                        //boss颜色
                        ConsoleColor bossColor = ConsoleColor.Green;

                        #endregion

                        while (true)
                        {
                            if(bossHp > 0)
                            {
                                //绘制boss图标
                                Console.SetCursorPosition(bossX, bossY);
                                Console.ForegroundColor = bossColor;
                                Console.Write(bossIcon);
                            }

                        }
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("结束场景");
                        break;
                }
            }
            #region 开始场景文字颜色状态方法（自己方法）
            //void startSceneStatus1()
            //{
            //    Console.SetCursorPosition(buttonX, buttonY);
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("开始游戏");

            //    Console.SetCursorPosition(buttonX, buttonY + 2);
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine("退出游戏");
            //}
            //void startSceneStatus2()
            //{
            //    Console.SetCursorPosition(buttonX, buttonY);
            //    Console.ForegroundColor = ConsoleColor.Yellow;
            //    Console.WriteLine("开始游戏");

            //    Console.SetCursorPosition(buttonX, buttonY + 2);
            //    Console.ForegroundColor = ConsoleColor.Red;
            //    Console.WriteLine("退出游戏");
            //}
            #endregion


            #endregion
        }
    }
}
