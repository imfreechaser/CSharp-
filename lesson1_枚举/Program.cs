using System;

namespace lesson1_枚举
{
    enum E_QQState {online, hide, offline}
    enum E_cofType
    {
        /// <summary>
        /// 中杯
        /// </summary>
        middleCup,
        bigCup,
        hugeCup
    }

    enum E_Sex
    {
        /// <summary>
        /// 男性
        /// </summary>
        male,
        /// <summary>
        /// n/==女性
        /// </summary>
        female
    }
    enum E_Career
    {
        /// <summary>
        /// 战士
        /// </summary>
        warrior,
        /// <summary>
        /// 猎人
        /// </summary>
        hunter,
        /// <summary>
        /// 法师
        /// </summary>
        mage
    }
    class Program
    {
        static void Main(string[] args)
        {
            #region Practice1
            //while (true)
            //{
            //    try
            //    {
            //        Console.WriteLine("请选择一个在线状态：（0代表在线，1代表隐身）");
            //        //int inputState = int.Parse(Console.ReadLine());
            //        int intKeyInput = int.Parse(Console.ReadKey().KeyChar.ToString());
            //        //Console.WriteLine(intKeyInput);
            //        E_QQState qQState = (E_QQState)intKeyInput;
            //        Console.WriteLine("您当前的状态为：{0}",qQState);
            //        break;
            //    }
            //    catch
            //    {
            //        Console.WriteLine("请输入正确格式的数字！");
            //    }
            //}

            #endregion
            #region Practice2
            //int inputCofType;
            //int coffeePrice = 0;
            //string chinName = "某某杯";
            //while (true)
            //{
            //    try 
            //    {
            //        Console.WriteLine("请选择你要购买的咖啡型号：0中杯（35元），1大杯（40元），2超大杯（43元）");
            //        inputCofType = int.Parse(Console.ReadKey().KeyChar.ToString());
            //        E_cofType cofType = (E_cofType)inputCofType;
            //        switch (cofType)
            //            {
            //                case E_cofType.middleCup:
            //                    coffeePrice = 35;
            //                    chinName = "中杯";
            //                    break;
            //                case E_cofType.bigCup:
            //                    coffeePrice = 40;
            //                    chinName = "大杯";
            //                    break;
            //                case E_cofType.hugeCup:
            //                    coffeePrice = 43;
            //                    chinName = "超大杯";
            //                    break;
            //                default:
            //                    Console.WriteLine("请输入正确格式的数字！");
            //                    break;

            //            }
            //            Console.WriteLine($"您购买了{chinName}咖啡，花费了{coffeePrice}元");
            //            break;

            //    }
            //    catch
            //    {
            //        Console.WriteLine("请输入正确格式的数字！");
            //    }
            //}

            #endregion
            #region Practice3
            int atkAmt = 0, dfdAmt = 0;
            string skill = "",sexName = "",careerName = "";
            int sexType, careerType;
            while (true)
            {
                try
                {
                    atkAmt = 0;
                    dfdAmt = 0;
                    Console.WriteLine("请输入数字选择您的英雄性别：0男性，1女性");
                    sexType = int.Parse(Console.ReadKey().KeyChar.ToString());
                    Console.WriteLine();
                    Console.WriteLine("请输入数字选择您的英雄职业：0战士，1猎人，2法师");
                    careerType = int.Parse(Console.ReadKey().KeyChar.ToString());
                    Console.WriteLine();
                    E_Sex sex = (E_Sex)sexType;
                    E_Career career = (E_Career)careerType;
                    switch (sex)
                    {
                        case E_Sex.male:
                            atkAmt += 50;
                            dfdAmt += 100;
                            sexName = "男性";
                            break;
                        case E_Sex.female:
                            atkAmt += 150;
                            dfdAmt += 20;
                            sexName = "女性";
                            break;
                        default:
                            Console.WriteLine("请输入正确格式的数字！");
                            break;
                    }
                    switch (career)
                    {
                        case E_Career.warrior:
                            atkAmt += 20;
                            dfdAmt += 100;
                            skill = "冲锋";
                            careerName = "战士";
                            break;
                        case E_Career.hunter:
                            atkAmt += 120;
                            dfdAmt += 30;
                            careerName = "猎人";
                            skill = "假死";
                            break;
                        case E_Career.mage:
                            atkAmt += 200;
                            dfdAmt += 10;
                            skill = "奥术冲击";
                            careerName = "法师";
                            break;
                        default:
                            Console.WriteLine("请输入正确格式的数字！");
                            break;
                    }
                    Console.WriteLine($"您选择了{sexName}{careerName},攻击力：{atkAmt},防御力：{dfdAmt},职业技能：{skill}");
                }
                catch
                {
                    Console.WriteLine("请输入正确格式的数字！");
                }
            }


            #endregion
        }
    }
}
