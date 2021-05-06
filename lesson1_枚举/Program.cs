using System;

namespace lesson1_枚举
{
    enum E_GameState { a = 5, b, c,d = 10, e }
    class Program
    {
        static void Main(string[] args)
        {
            E_GameState gameState = E_GameState.c;

            if(gameState == E_GameState.c)
            {
                Console.WriteLine((int)E_GameState.c);
            }

            switch (gameState)
            {
                case E_GameState.a:
                    break;
                case E_GameState.b:
                    break;
                case E_GameState.c:
                    break;
                case E_GameState.d:
                    break;
                case E_GameState.e:
                    break;
                default:
                    break;
            }
        }
    }
}
