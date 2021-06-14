using System;

namespace CSharp实践项目
{
    enum E_SceneType
    {
        /// <summary>
        /// 开始场景
        /// </summary>
        Begin,
        /// <summary>
        /// 游戏场景
        /// </summary>
        Game,
        /// <summary>
        /// 结束场景
        /// </summary>
        End
    }
    enum E_GridType
    {
        /// <summary>
        /// 普通
        /// </summary>
        ordinary,
        /// <summary>
        /// 炸弹
        /// </summary>
        bomb,
        /// <summary>
        /// 暂停
        /// </summary>
        pause,
        /// <summary>
        /// 隧道
        /// </summary>
        tunnel,
        /// <summary>
        /// 起点
        /// </summary>
        start,
        /// <summary>
        /// 终点
        /// </summary>
        end
    }
    enum E_PlayerType
    {
        /// <summary>
        /// 电脑
        /// </summary>
        computer,
        /// <summary>
        /// 主玩家
        /// </summary>
        player
    }
    struct Vector2
    {
        public int x;
        public int y;

        public Vector2(int x, int y)
        {
            this.x = x;
            this.y = y;
        }
    }
    struct Grid
    {
        public E_GridType type;
        public Vector2 position;

        public Grid(E_GridType type, int x, int y)
        {
            this.type = type;
            position.x = x;
            position.y = y;
        }

        public void DrawGrid()
        {
            Console.SetCursorPosition(position.x, position.y);
            switch (type)
            {
                case E_GridType.ordinary:
                    Console.ForegroundColor = ConsoleColor.White;
                    Console.Write("□");
                    break;
                case E_GridType.bomb:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("●");
                    break;
                case E_GridType.pause:
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write("‖");
                    break;
                case E_GridType.tunnel:
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("¤");
                    break;
                case E_GridType.start:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("○");
                    break;
                case E_GridType.end:
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("⊙");
                    break;
                default:
                    break;
            }
        }
    }
    struct Map
    {
        public Grid[] grids;
        public Map(int num, int x, int y)//xy为初始坐标，num为格子个数（数组长度）
        {
            grids = new Grid[num];
            int xindex = 0;
            int yindex = 0;
            int step = 2;
            Random r = new Random();
            int typeIndex;
            for (int i = 0; i < num; i++)
            {
                grids[i].position.x = x;
                grids[i].position.y = y;
                //类型初始化
                if (i == 0)
                    grids[i].type = E_GridType.start;
                else if (i == grids.Length - 1)
                    grids[i].type = E_GridType.end;
                else
                {
                    //按几率设置格子类型
                    typeIndex = r.Next(0, 100);
                    if (typeIndex >= 0 && typeIndex < 88)
                        grids[i].type = E_GridType.ordinary;
                    else if (typeIndex >= 88 && typeIndex < 93)
                        grids[i].type = E_GridType.bomb;
                    else if (typeIndex >= 93 && typeIndex < 97)
                        grids[i].type = E_GridType.pause;
                    else
                        grids[i].type = E_GridType.tunnel;
                }
                //位置改变
                if (xindex < 10)
                {
                    x += step;
                    ++xindex;
                }
                else
                {
                    ++y;
                    ++yindex;
                }
                if (yindex >= 2)
                {
                    xindex = 0;  //重置横向格子计数变量；
                    step = -step;//第二行/偶数行开始往回走，即每次走的量是原来的相反数；
                    yindex = 0;
                }
                //xindex = 10,y++,yindex = 1
                //xindex = 10,y++,yindex = 2,xindex = 0,yindex = 0
                //xindex = 0;
                
            }
        }
        public void DrawMap()
        {
            foreach(Grid grid in grids)
            {
                grid.DrawGrid();
            }
        }

    }
    struct Character
    {
        public E_PlayerType character;
        public int posIndex;
        public bool isPause;

        public Character(E_PlayerType character, int posIndex)//每次扔色子之后都重新初始化一遍，所以不可以定死posindex是0
        {
            this.character = character;
            this.posIndex = posIndex;
            isPause = false;
        }

        public void DrawCharacter(Map map)
        {
            Console.SetCursorPosition(map.grids[posIndex].position.x, map.grids[posIndex].position.y);
            switch (character)
            {
                case E_PlayerType.computer:
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.Write("▲");
                    break;
                case E_PlayerType.player:
                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.Write("★");
                    break;
                default:
                    break;
            }
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region 控制台初始化
            int w = 50, h = 30;
            ConsoleInit(w, h);
            #endregion

            #region 场景选择相关

            //进入时默认为0开始场景
            E_SceneType sceneType = E_SceneType.Begin;

            //游戏主循环
            while (true)
            {
                switch (sceneType)
                {
                    case E_SceneType.Begin:
                        BeginScene(w,h,ref sceneType);
                        break;
                    case E_SceneType.Game:
                        Console.Clear();
                        GameScene(w, h, ref sceneType);
                        break;
                    case E_SceneType.End:
                        //结束场景循环
                        Console.Clear();
                        Console.WriteLine("EndScene");
                        Console.ReadLine();
                        break;
                    default:
                        break;
                }
            }

            #endregion
        }

        #region 控制台初始化
        static void ConsoleInit(int width, int height)
        {
            //光标隐藏
            Console.CursorVisible = false;
            //舞台大小
            Console.SetWindowSize(width, height);
        }
        #endregion

        #region 开始场景循环
        static void BeginScene(int width, int height, ref E_SceneType e_SceneType)
        {
            //设置标题
            Console.SetCursorPosition(width / 2 - 2, height / 3 - 3);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("飞行棋");

            int btnID = 0;
            bool quit = false;

            while (true)
            {
                Console.SetCursorPosition(width / 2 - 3, height / 2 - 3);
                Console.ForegroundColor = btnID == 0 ? ConsoleColor.Red : ConsoleColor.White;
                Console.Write("开始游戏");

                Console.SetCursorPosition(width / 2 - 3, height / 2 - 1);
                Console.ForegroundColor = btnID == 1 ? ConsoleColor.Red : ConsoleColor.White;
                Console.Write("退出游戏");

                switch (Console.ReadKey(true).Key)
                {
                    case ConsoleKey.W:
                        btnID --;
                        if (btnID < 0)
                            btnID = 0;
                        break;
                    case ConsoleKey.S:
                        btnID ++;
                        if (btnID > 1)
                            btnID = 1;
                        break;
                    case ConsoleKey.Enter:
                        if (btnID == 0)
                        {
                            e_SceneType = E_SceneType.Game;
                            quit = true;
                        }
                        else
                        {
                            Environment.Exit(0);
                        }
                        break;
                    default:
                        break;
                }
                if (quit)
                    break;
            }
        }
        #endregion

        #region 游戏场景循环
        static void GameScene(int width, int height, ref E_SceneType sceneType)
        {
            //绘制红墙、不变的文字信息
            BuildRedWall(width, height);
            Hint(height);
            //绘制飞行棋地图
            Map map = new Map(80, 15, 3);
            //初始化玩家及回合所需参数
            Character mPlayer = new Character(E_PlayerType.player, 0);
            Character cPlayer = new Character(E_PlayerType.computer, 0);
            bool playerRound = true;
            bool over = false;
            //绘制地图
            map.DrawMap();
            //绘制玩家和电脑
            DrawPlayer(mPlayer, cPlayer, map);
            //提示按键开始游戏
            Console.SetCursorPosition(2, height - 5);
            Console.ForegroundColor = ConsoleColor.White;
            Console.Write("请按任意键开始游戏！");
            //游戏回合循环
            while (true)
            {
                //绘制地图
                map.DrawMap();
                //绘制玩家和电脑
                DrawPlayer(mPlayer, cPlayer, map);
                //玩家输入按键
                Console.ReadKey(true);
                //回合内容
                Play( ref mPlayer, ref cPlayer, map, ref playerRound, ref over, height);
                //回合结束逻辑
                if (over)
                {
                    sceneType = E_SceneType.End;
                    //绘制地图
                    map.DrawMap();
                    //绘制玩家和电脑
                    DrawPlayer(mPlayer, cPlayer, map);
                    Console.ReadKey(true);
                    break;
                }
            }
        }
        #endregion

        #region 不变的红墙
        static void BuildRedWall(int width, int height)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            //横向红墙
            for (int i = 0; i < width; i += 2)
            {
                Console.SetCursorPosition(i, 0);
                Console.Write("■");
                Console.SetCursorPosition(i, height - 11);
                Console.Write("■");
                Console.SetCursorPosition(i, height - 6);
                Console.Write("■");
                Console.SetCursorPosition(i, height - 1);
                Console.Write("■");
            }
            //纵向红墙
            for (int i = 1; i < height; i++)
            {
                Console.SetCursorPosition(0, i);
                Console.Write("■");
                Console.SetCursorPosition(width - 2, i);
                Console.Write("■");
            }
        }
        #endregion

        #region 不变的提示文字 
        static void Hint(int height)
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.SetCursorPosition(2,height - 10);
            Console.Write("□：普通格子");

            Console.SetCursorPosition(2, height - 9);
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.Write("||：暂停，一回合不动");

            Console.ForegroundColor = ConsoleColor.Red;
            Console.Write("\t ●：炸弹，倒退5格");

            Console.SetCursorPosition(2, height - 8);
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.Write("¤：时空隧道，随机倒退/暂停/换位置");

            Console.SetCursorPosition(2, height - 7);
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("★：玩家");

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.Write("\t▲：电脑");

            Console.ForegroundColor = ConsoleColor.Green;
            Console.Write("\t◎：玩家电脑重合");
        }
        #endregion

        #region 绘制玩家
        static void DrawPlayer(Character mPlayer, Character cPlayer, Map map)
        {
            if (mPlayer.posIndex == cPlayer.posIndex)
            {
                Console.SetCursorPosition(map.grids[mPlayer.posIndex].position.x, map.grids[mPlayer.posIndex].position.y);
                Console.ForegroundColor = ConsoleColor.Green;
                Console.Write("◎"); 
            }
            else
            {
                mPlayer.DrawCharacter(map);
                cPlayer.DrawCharacter(map);
            }
        }
        #endregion

        #region 游戏回合
        static void Play(ref Character mPlayer, ref Character cPlayer, Map map, ref bool playerRound,
            ref bool over, int height)
        {
            Character p,otherP;
            if (playerRound)//玩家回合
            {
                p = mPlayer;
                otherP = cPlayer;
            }
            else//电脑回合
            {
                p = cPlayer;
                otherP = mPlayer;
            }

            if (p.isPause)//暂停一回合
            {
                p.isPause = false;

                ClearInfo(height);
                Console.SetCursorPosition(2, height - 5);
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("处于暂停点，{0}需要暂停一回合", playerRound ? "玩家" : "电脑");
            }
            else//正常进行此回合
            {
                RandomMove(out int Step);
                p.posIndex += Step;
                if (p.posIndex >= map.grids.Length - 1)//到达终点
                {
                    p.posIndex = map.grids.Length - 1;
                    over = true;
                    RoundText(p, height, Step, "", true);
                }
                else//未到达终点
                {
                    encounterGrid(map, ref p.posIndex, ref otherP.posIndex, Step, out string roundText, ref p.isPause);
                    //p = new Character(E_PlayerType.player, mPlayer.posIndex);
                    RoundText(p, height, Step, roundText, false);
                }
            }
            mPlayer = playerRound ? p : otherP;
            cPlayer = !playerRound ? p : otherP;
            playerRound = !playerRound;
        }
        #endregion

        #region 扔色子
        /// <summary>
        /// 每次扔出的点数
        /// </summary>
        /// <param name="step"></param>
        static void RandomMove(out int step)
        {
            Random r = new Random();
            step = r.Next(1, 7);
        }
        #endregion

        #region 遇到不同类型格子的处理
        static void encounterGrid(Map map, ref int thisPosIndex, ref int tOtherPosIndex,int step,out string roundText,ref bool PauseRoundOrNot)
        {
            switch (map.grids[thisPosIndex].type)
            {
                case E_GridType.ordinary:
                    roundText = "到达一个安全位置";
                    PauseRoundOrNot = false;
                    break;
                case E_GridType.bomb:
                    thisPosIndex -= 5;
                    if (thisPosIndex < 0)
                        thisPosIndex = 0;
                    roundText = "遇到炸弹！倒退5格！";
                    PauseRoundOrNot = false;
                    break;
                case E_GridType.pause: 
                    roundText = "处于暂停点，需要暂停一回合";
                    PauseRoundOrNot = true;
                    break;
                case E_GridType.tunnel:
                    TunnelGrid(ref thisPosIndex, ref tOtherPosIndex, step, out string roundTextTunnel, ref PauseRoundOrNot);
                    roundText = roundTextTunnel;
                    break;
                default:
                    roundText = "";
                    PauseRoundOrNot = false;
                    break;
            }

        }
        #endregion

        #region 时空隧道格子
        static void TunnelGrid(ref int thisPosIndex, ref int tOtherPosIndex, int step, out string roundTextTunnel, ref bool pauseRound)
        {
            Random r = new Random();
            int rdindex = r.Next(1, 4);
            switch (rdindex)
            {
                case 1://倒退
                    int backStep = r.Next(1, 6);
                    thisPosIndex -= (backStep + step);
                    if (thisPosIndex < 0)
                        thisPosIndex = 0;
                    roundTextTunnel = $"进入时空隧道！倒退{backStep}步！";
                    pauseRound = false;
                    break;
                case 2://暂停
                    roundTextTunnel = "进入时空隧道！暂停一回合！";
                    pauseRound = true;
                    break;
                case 3://换位置
                    int midVar = thisPosIndex;
                    thisPosIndex = tOtherPosIndex;
                    tOtherPosIndex = midVar;
                    roundTextTunnel = "进入时空隧道！与另一玩家互换位置！";
                    pauseRound = false;
                    break;
                default:
                    roundTextTunnel = "";
                    pauseRound = false;
                    break;
            }
        }
        #endregion

        #region 游戏回合文字
        static void RoundText(Character player, int height, int step, string roundText, bool reachTheEnd)
        {
            Console.ForegroundColor = player.character == E_PlayerType.player ? ConsoleColor.Cyan : ConsoleColor.Magenta;
            string playerName = player.character == E_PlayerType.player ? "你" : "电脑";

            ClearInfo(height);
            Console.SetCursorPosition(2, height - 5);
            Console.Write($"{playerName}扔出的点数为：{step}");

            if (!reachTheEnd)//未到达终点
            {
                Console.SetCursorPosition(2, height - 4);
                Console.Write(roundText);

                Console.SetCursorPosition(2, height - 3);
                Console.Write("请按任意键，让{0}开始扔色子", player.character == E_PlayerType.player ? "电脑" : "你自己");
            }
            else//到达终点
            {
                Console.SetCursorPosition(2, height - 4);
                Console.Write(player.character == E_PlayerType.player ?"恭喜你率先到达终点！":"很遗憾，电脑率先到达了终点");

                Console.SetCursorPosition(2, height - 3);
                Console.Write("请按任意键结束游戏");
            }
        }
        #endregion

        #region 擦除回合提示文字
        static void ClearInfo(int height)
        {
            Console.SetCursorPosition(2, height - 5);
            Console.WriteLine("                                   ");
            Console.SetCursorPosition(2, height - 4);
            Console.WriteLine("                                   ");
            Console.SetCursorPosition(2, height - 3);
            Console.WriteLine("                                   ");
        }
        #endregion 
    }
}
