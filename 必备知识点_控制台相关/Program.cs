using System;

namespace 必备知识点_控制台相关
{
    class Program
    {
        static void Main(string[] args)
        {
            int heroX = 0, heroY = 0;
            Console.BackgroundColor = ConsoleColor.Red;
            Console.Clear();
            Console.CursorVisible = false;
            while (true)
            {
                //Console.Clear();
                Console.Write("■");
                char inputDirection = Console.ReadKey(true).KeyChar;
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
                //Console.WriteLine("\n\n\n\nx,y:{0},{1}",heroX, heroY);
                Console.SetCursorPosition(heroX, heroY);

                
                if(inputDirection == 'q')
                {
                    Environment.Exit(0);
                }
            }
        }
    }
}
