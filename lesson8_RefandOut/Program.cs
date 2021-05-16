using System;

namespace lesson8_RefandOut
{
    class Program
    {
        public static void WrongUserName(out bool outCome, out string message)
        {
            outCome = false;
            message = "用户名错误";
        }
        public static void WrongPassword(out bool outCome, out string message)
        {
            outCome = false;
            message = "密码错误";
        }
        static void Main(string[] args)
        {
            try
            {
                bool signInOutCome;
                string signInMes;
                string userName;
                int password;
                Console.WriteLine("请输入用户名：");
                userName = Console.ReadLine();
                Console.WriteLine("请输入密码：");
                password = int.Parse(Console.ReadLine());

                if (userName == "admin")
                {
                    if (password == 666666)
                    {
                        signInOutCome = true;
                        signInMes = "登录成功！";
                    }
                    else
                        WrongPassword(out signInOutCome, out signInMes);
                }
                else
                {
                    WrongUserName(out signInOutCome, out signInMes);
                }
                Console.WriteLine("您的登录结果为：{0}，{1}", signInOutCome, signInMes);
            }
            catch
            {
                Console.WriteLine("请输入正确格式的密码！");
            }
        }
    }
}
