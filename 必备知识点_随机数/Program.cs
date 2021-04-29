using System;

namespace 必备知识点_随机数
{
    class Program
    {
        static void Main(string[] args)
        {
            // test
            Random attackAmount = new Random();
            int tangAttack = 0;
            int hpLost = 0;
            int monsterHp = 20;
            while (true)
            {
                Console.WriteLine("请按任意键攻击小怪兽");
                Console.ReadKey(true);
                Console.Clear();

                tangAttack = attackAmount.Next(8, 13);
                hpLost = tangAttack - 10;
                if (hpLost <= 0)
                    Console.WriteLine("本次攻击没有伤害到小怪兽！\n");
                else
                {
                    Console.WriteLine("本次攻击打掉小怪兽{0}滴血！\n", hpLost);
                    monsterHp -= hpLost;
                }
                if(monsterHp <= 0)
                {
                    Console.WriteLine("win!小怪兽死了！");
                    break;
                }


            }
        }
    }
}
