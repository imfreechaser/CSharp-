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
            bool isEnterDown = false;
            int buttonX = 20, buttonY = 7;

            while (true)
            {
                switch (instantSceneID)
                {
                    case 1:
                        Console.Clear();
                        //游戏标题
                        Console.WriteLine("\n\n\n\n\t\t  唐老师营救公主");
                        //按钮初始化
                        startSceneStatus1();
                        while (true)
                        {
                            inputDirection = Console.ReadKey(true).KeyChar;

                            switch (inputDirection)
                            {
                                case 'w':
                                    instantSceneID = 2;
                                    startSceneStatus1();
                                    break;
                                case 's':
                                    instantSceneID = 3;
                                    startSceneStatus2();
                                    break;
                                case ' ':
                                    isEnterDown = true;
                                    break;
                            }
                            if(isEnterDown)
                            {
                                break;
                            }
                        }
                        break;
                    case 2:
                        Console.Clear();
                        Console.WriteLine("游戏场景");
                        break;
                    case 3:
                        Console.Clear();
                        Console.WriteLine("结束场景");
                        break;
                }
                //break;
            }

            //开始场景文字颜色状态方法
            void startSceneStatus1()
            {
                Console.SetCursorPosition(buttonX, buttonY);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("开始游戏");

                Console.SetCursorPosition(buttonX, buttonY + 2);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("退出游戏");
            }
            void startSceneStatus2()
            {
                Console.SetCursorPosition(buttonX, buttonY);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("开始游戏");

                Console.SetCursorPosition(buttonX, buttonY + 2);
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("退出游戏");
            }
            #endregion
        }
    }
}
