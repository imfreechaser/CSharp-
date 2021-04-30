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
            //开始场景
            char inputDirection;
            int buttonId = 0;
            bool isQuit;
            //游戏场景
            bool isOver = false;
            bool WinTheGame = false;
            //结束场景
            bool backToBegin = false;

            while (true)
            {
                switch (instantSceneID)
                {
                    case 1:
                        Console.Clear();
                        //场景逻辑初始化
                        isQuit = false;
                        isOver = false;
                        WinTheGame = false;
                        backToBegin = false;
                        //
                        //游戏标题
                        Console.SetCursorPosition(width / 2 - 7, 7);
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("菁崽营救公主");
                        buttonId = 0;
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

                        #region 玩家属性相关

                        int playerAtkMin = 8;
                        int playerAtkMax = 13;
                        int playerPosX = 6, playerPosY = 5;
                        int playerHp = 100;
                        string playerIcon = "●";
                        char moveInput;
                        char atkInput;
                        ConsoleColor HeroColor = ConsoleColor.Yellow;
                        int LasPosX = 0, LasPosY = 0;

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

                        #region 公主属性相关

                        ConsoleColor princessColor = ConsoleColor.Blue;
                        string princessIcon = "★";
                        int princessX = 36, princessY = 5;

                        #endregion

                        while (true)                //游戏场景大循环
                        {
                            #region 玩家移动

                            //绘制玩家
                            Console.ForegroundColor = HeroColor;
                            Console.SetCursorPosition(playerPosX, playerPosY);
                            Console.Write(playerIcon);
                            //

                            #region 和boss战斗
                            
                            if(bossHp > 0 && 
                              (playerPosX == bossX && (playerPosY == bossY - 1 || playerPosY == bossY + 1) ||
                               playerPosY == bossY && (playerPosX == bossX - 2 || playerPosX == bossX + 2))) //判断攻击区域
                            {
                                //提示进入战斗模式，按键继续
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.SetCursorPosition(2, height - 5);
                                Console.Write("开始进入战斗！按J继续...");
                                //
                                while (playerHp > 0 && bossHp > 0)
                                {
                                    atkInput = Console.ReadKey(true).KeyChar;
                                    if(atkInput == 'j' || atkInput == 'J')
                                    {
                                        //战斗开始
                                        //主角攻击
                                        Random playerAtkR = new Random();
                                        int playerAtk = playerAtkR.Next(playerAtkMin, playerAtkMax + 1);//主角攻击力
                                        bossHp -= playerAtk;//boss剩余血量

                                        Console.ForegroundColor = ConsoleColor.Green;
                                        Console.SetCursorPosition(2, height - 4);
                                        Console.Write("                                              ");
                                        Console.SetCursorPosition(2, height - 4);
                                        if (bossHp > 0)
                                            Console.Write("主角攻击boss，boss掉了{0}滴血！boss剩余血量：{1}", playerAtk, bossHp);
                                        else
                                        {
                                            Console.SetCursorPosition(bossX, bossY);
                                            Console.Write("  ");
                                            Console.SetCursorPosition(2, height - 5);
                                            Console.Write("                                              ");
                                            Console.SetCursorPosition(2, height - 5);
                                            Console.Write("恭喜你战胜了boss！快去营救公主！");
                                            Console.SetCursorPosition(2, height - 4);
                                            Console.Write("                                              ");
                                            Console.SetCursorPosition(2, height - 4);
                                            Console.Write("按任意键继续...");
                                            Console.SetCursorPosition(2, height - 3);
                                            Console.Write("                                              ");

                                            Console.ReadKey(true);
                                            WinTheGame = true;
                                            break;
                                        }

                                        //boss攻击
                                        if (bossHp > 0)
                                        {
                                            playerAtk = playerAtkR.Next(bossAtkMin, bossAtkMax + 1);//boss攻击力
                                            playerHp -= playerAtk;//主角剩余血量

                                            Console.ForegroundColor = ConsoleColor.Yellow;
                                            Console.SetCursorPosition(2, height - 3);
                                            Console.Write("                                              ");
                                            Console.SetCursorPosition(2, height - 3);
                                            if (playerHp > 0)
                                                Console.Write("boss攻击主角，主角掉了{0}滴血！主角剩余血量：{1}", playerAtk, playerHp);
                                            else
                                            {
                                                Console.SetCursorPosition(playerPosX, playerPosY);
                                                Console.Write("  ");
                                                Console.SetCursorPosition(2, height - 5);
                                                Console.Write("                                              ");
                                                Console.SetCursorPosition(2, height - 5);
                                                Console.Write("很遗憾你战败了！");
                                                Console.SetCursorPosition(2, height - 4);
                                                Console.Write("                                              ");
                                                Console.SetCursorPosition(2, height - 4);
                                                Console.Write("按J继续...");
                                                Console.SetCursorPosition(2, height - 3);
                                                Console.Write("                                              ");

                                                int exitInput = Console.ReadKey(true).KeyChar;
                                                if (exitInput == 'j' || exitInput == 'J')
                                                    break;
                                            }
                                        
                                        }
                                    }
                                }
                                if(playerHp <= 0)
                                {
                                    instantSceneID = 3;
                                    isOver = true;
                                    break;
                                }
                            }
                            
                            if (isOver)
                                break;
                            #endregion

                            if (bossHp > 0)
                            {
                                //每帧检测boss血量，若大于0则绘制boss图标
                                Console.SetCursorPosition(bossX, bossY);
                                Console.ForegroundColor = bossColor;
                                Console.Write(bossIcon);
                            }
                            else
                            {
                                //画出公主
                                Console.ForegroundColor = princessColor;
                                Console.SetCursorPosition(princessX, princessY);
                                Console.Write(princessIcon);
                                //擦除之前显示的文字
                                Console.SetCursorPosition(2,height - 5);
                                Console.Write("                                              ");
                                Console.SetCursorPosition(2, height - 4);
                                Console.Write("                                              ");
                            }

                            #region 营救公主

                            if (bossHp <= 0 &&
                              (playerPosX == princessX && (playerPosY == princessY - 1 || playerPosY == princessY + 1) ||
                               playerPosY == princessY && (playerPosX == princessX - 2 || playerPosX == princessX + 2)))
                            {
                                //提示营救公主信息
                                Console.SetCursorPosition(2, height - 5);
                                Console.Write("按J键营救公主！");
                                while (true)
                                {
                                    int savePrinInput = Console.ReadKey(true).KeyChar;
                                    if (savePrinInput == 'J' || savePrinInput == 'j')
                                    {
                                        Console.SetCursorPosition(2, height - 5);
                                        Console.Write("                                              ");
                                        Console.SetCursorPosition(2, height - 5);
                                        Console.Write("营救公主成功！");
                                        Console.SetCursorPosition(2, height - 4);
                                        Console.Write("按任意键继续...");
                                        Console.ReadKey(true);
                                        instantSceneID = 3;
                                        isOver = true;
                                        break;
                                    }
                                }
                            }
                            if (isOver)
                                break;

                            #endregion

                            //检测输入、擦除上一帧玩家
                            moveInput = Console.ReadKey(true).KeyChar;
                            LasPosX = playerPosX;
                            LasPosY = playerPosY; 
                            Console.SetCursorPosition(playerPosX, playerPosY);
                            Console.Write("  ");

                            //改变玩家位置XY
                            switch (moveInput)
                            {
                                case 'w':
                                case 'W':
                                    playerPosY--;
                                    break;
                                case 's':
                                case 'S':
                                    playerPosY++;
                                    break;
                                case 'a':
                                case 'A': 
                                    playerPosX-=2;
                                    break;
                                case 'd':
                                case 'D':
                                    playerPosX+=2;
                                    break;
                            }
                            //检测位置是否合规
                            HeroMoveBorder();
                            AvoidBossPos();
                            AvoidPrincess();


                            #endregion
                        }

                        //主角移动边界控制
                        void HeroMoveBorder()
                        {
                            if (playerPosX < 2)
                                playerPosX = 2;
                            else if (playerPosX > 46)
                                playerPosX = 46;
                            if (playerPosY < 1)
                                playerPosY = 1;
                            else if (playerPosY > 23)
                                playerPosY = 23;
                        }
                        void AvoidBossPos()
                        {
                            if (playerPosX == bossX && playerPosY == bossY & bossHp > 0)
                            {
                                playerPosX = LasPosX;
                                playerPosY = LasPosY;
                            }
                        }
                        void AvoidPrincess()
                        {
                            if (playerPosX == princessX && playerPosY == princessY & bossHp <= 0)
                            {
                                playerPosX = LasPosX;
                                playerPosY = LasPosY;
                            }
                        }

                        break;
                    case 3:
                        Console.Clear();
                        //标题
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.SetCursorPosition(width / 2 - 4, 7);
                        Console.Write("GameOver");
                        //可变标题
                        Console.SetCursorPosition(width / 2 - 4, 8);
                        Console.Write(WinTheGame? "英雄救美":"惨遭屠杀");
                        buttonId = 0;
                        while (true)
                        {
                            Console.SetCursorPosition(width / 2 - 6, 10);
                            Console.ForegroundColor = buttonId == 0 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("回到开始界面");

                            Console.SetCursorPosition(width / 2 - 4, 12);
                            Console.ForegroundColor = buttonId == 1 ? ConsoleColor.Red : ConsoleColor.White;
                            Console.Write("退出游戏");

                            inputDirection = Console.ReadKey(true).KeyChar;
                            switch (inputDirection)
                            {
                                case 'w':
                                case 'W':
                                    //buttonId--;
                                    buttonId = --buttonId < 0 ? 0 : buttonId;
                                    break;
                                case 's':
                                case 'S':
                                    buttonId = ++buttonId > 1 ? 1 : buttonId;
                                    break;
                                case ' ':
                                    if(buttonId == 0)
                                    {
                                        instantSceneID = 1;
                                        backToBegin = true;
                                        break;
                                    }
                                    else
                                    {
                                        Environment.Exit(0);
                                    }
                                    break; 
                            }
                            if (backToBegin)
                                break;
                        }
                        break;
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
}
