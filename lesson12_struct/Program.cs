using System;

namespace lesson12_struct
{
    struct Student
    {
        //成员变量
        public int age;
        public bool sex;//true男 false女
        public string major;
        public int curriculum;
        public string name;

        //方法不需要加static
        public void Speak()
        {
            Console.WriteLine("学生的名字是：{0}，今年{1}岁，{2}专业{3}班，性别：{4}",name,age,major,curriculum,sex ? "男" : "女");
        }
        public Student(int age, bool sex, int curriculum, string name,string major)
        {
            this.age = age;
            this.sex = sex;
            this.curriculum = curriculum;
            this.name = name;
            this.major = major;
        }

    }
    struct Rectangle
    {
        public float length;
        public float width;
        public float area;
        public float perimeter;
        
        public Rectangle(float length, float width)
        {
            this.length = length;
            this.width = width;
            area = length * width;
            perimeter = 2 * (length + width);
        }

        public void ShowInfor()
        {
            Console.WriteLine("矩形的长为{0}，宽为{1}，周长为{2}，面积为{3}",length,width, perimeter, area);
        }
    }
    struct Player
    {
        public string playerName;
        public E_PlayerCareer career;
        public bool quit;
        public Player(string playerName, E_PlayerCareer career)
        {
            this.playerName = playerName;
            this.career = career;
            quit = false;
        }
        public void Atk()
        {
            string careerName = null;
            string skill = null;

            switch (career)
            {            
                case E_PlayerCareer.warrior:
                    careerName = "战士";
                    skill = "冲锋";
                    break;
                case E_PlayerCareer.hunter:
                    careerName = "猎人";
                    skill = "假死";
                    break;
                case E_PlayerCareer.witch:
                    careerName = "法师";
                    skill = "奥术冲击";
                    break;
                default:
                    Console.WriteLine("请输入正确格式的职业代号！");
                    break;
            }
            if (careerName != null)
            {
                Console.WriteLine("{0}{1}释放了{2}", careerName, playerName, skill);
                quit = true;
            }
        }
    }
    enum E_PlayerCareer
    {
        warrior,
        hunter,
        witch
    }
    struct SmallMonster
    {
        public string name;
        public int atk;
        public ushort level;

        public SmallMonster(string name, int atk, ushort level)
        {
            this.name = name;
            this.atk = atk;
            this.level = level;
        }

        public void PrintSmallMonster()
        {
            Console.WriteLine("{0}，{1}级，攻击力：{2}",name,level,atk);
        }
    }
    struct OutManAndSmallMonster
    {
        public int outManDfd;
        public int outManHp;
        public int sMDfd;
        public int sMHp;
        int outManAtk;
        int sMAtk;
        public bool quit;

        public OutManAndSmallMonster(int outManDfd, int sMDfd, int outManHp,int sMHp)
        {
            this.outManDfd = outManDfd;
            this.sMDfd = sMDfd;
            this.outManHp = outManHp;
            this.sMHp = sMHp;
            outManAtk = 0;
            sMAtk = 0;
            quit = false;
        }

        public void OutManAtkSM()
        {
            sMHp -= outManAtk >= sMDfd ? outManAtk - sMDfd : 0;
            if(sMHp > 0)
            {
                Console.WriteLine("奥特曼攻击了小怪兽，小怪兽剩余血量：{0}，奥特曼剩余血量：{1}",sMHp,outManHp);
            }
            else
                Console.WriteLine("奥特曼攻击了小怪兽，小怪兽被打死啦！");
        }
        public void SMAtkOutMan()
        {
            outManHp -= sMAtk >= outManDfd ? sMAtk - outManDfd : 0;
            if (outManHp > 0)
            {
                Console.WriteLine("小怪兽攻击了奥特曼，奥特曼剩余血量：{0}，小怪兽剩余血量：{1}", outManHp,sMHp);
            }
            else
                Console.WriteLine("小怪兽攻击了奥特曼，奥特曼被打死啦！");
        }
        public void Atk(char atkRound)
        {
            Random r = new Random();
            outManAtk = r.Next(8, 13);
            sMAtk = r.Next(7, 12);

            switch (atkRound)
            {
                case 'J':
                case 'j':
                    OutManAtkSM();
                    break;
                case 'K':
                case 'k':
                    SMAtkOutMan();
                    break;
                default:
                    Console.WriteLine("请输入正确的按键！");
                    break;
            }
            if (outManHp <= 0 || sMHp <= 0)
                quit = true;
        }
    }

    class Program
    {
        static void ChangeA(int aa)
        {
            aa = 9;
        }
        static void Main(string[] args)
        {
            #region Practice1
            //Student s1 = new Student(18, true, 3, "小华", "环境工程");
            //s1.Speak();
            //Student s2 = new Student(22, false, 2, "小菁", "建环");
            //s2.Speak();
            #endregion
            #region Practice3
            //Rectangle rect1 = new Rectangle(2.5f, 2.4f);
            //rect1.ShowInfor();
            #endregion
            #region Practice4

            //E_PlayerCareer pc;

            //Console.WriteLine("请输入玩家姓名：");
            //string playerName = Console.ReadLine();

            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("请选择玩家职业：（0战士/1猎人/2法师）");
            //        pc = (E_PlayerCareer)int.Parse(Console.ReadLine());
            //        Player p1 = new Player(playerName, pc);
            //        p1.Atk();
            //        if (p1.quit)
            //            break;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("请输入正确格式的职业代号！");
            //    }
            //}

            #endregion
            #region Practice5

            //SmallMonster sm1 = new SmallMonster("奥姆","五连锤",50);
            //sm1.PrintSmallMonster();

            #endregion
            #region Practice6
            //SmallMonster[] monsters = new SmallMonster[10];
            //for (int i = 0; i < monsters.Length; i++)
            //{
            //    monsters[i] = new SmallMonster("小怪兽"+i,10,1);
            //    monsters[i].PrintSmallMonster();
            //}
            #endregion
            #region Practice7

            OutManAndSmallMonster game1 = new OutManAndSmallMonster(6, 7, 20, 18);
            char atkRound;

            while (true)
            {
                Console.WriteLine("请按键开始攻击！（J：奥特曼攻击，K：小怪兽攻击）");
                atkRound = Console.ReadKey(true).KeyChar;
                Console.Clear();

                game1.Atk(atkRound);
                if (game1.quit)
                    break;
            }

            #endregion
        }
    }
}
