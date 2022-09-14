using System;

namespace Lesson1_枚举练习题
{
    /// <summary>
    /// QQ状态说明
    /// </summary>
    enum E_QQType 
    {
        /// <summary>
        /// 在线
        /// </summary>
        Online,
        Leave,
        Busy,
        Invisble,
    }

    enum E_CafeType {
        M,
        D,
        S,
    }

    enum E_Sex {
        Male,
        Female,
    }

    enum E_JobType {
        Warrier,
        Hunter,
        Fashi,
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("枚举练习题");
            #region 练习题一
            //定义qq状态，并提示用户选择一个在线状态
            try
            {
                Console.WriteLine("请输入QQ状态(0在线，1离开，2忙，3隐身)");
                int type = int.Parse(Console.ReadLine());
                E_QQType qqType = (E_QQType)type;
                Console.WriteLine(qqType);
            }
            catch {
                Console.WriteLine("请输入数字");
            }

            #endregion

            #region 练习题二
            //用户去买咖啡，中35元，大40元，超43元
            //请用户选择购买类型，选择后打印：您购买了xxx咖啡，花费了xx元。

            try
            {
                Console.WriteLine("请输入咖啡类型(0中杯，1大杯，2超大杯)");
                int cafeType = int.Parse(Console.ReadLine());
                E_CafeType cType = (E_CafeType)cafeType;
                switch (cType)
                {
                    case E_CafeType.M:
                        Console.WriteLine("您选择了中杯，花费35元");
                        break;
                    case E_CafeType.D:
                        Console.WriteLine("您选择了大杯，花费40元");
                        break;
                    case E_CafeType.S:
                        Console.WriteLine("您选择了超大杯，花费43元");
                        break;
                    default:
                        Console.WriteLine("请输入正确类型");
                        break;
                }
            }
            catch
            {
                Console.WriteLine("请输入数字");
            }
            #endregion

            #region 练习题三
            try
            {
                Console.WriteLine("请选择性别（男0，女1）");
                E_Sex sex = (E_Sex)int.Parse(Console.ReadLine());
                string sexStr = "";
                int atk = 0;
                int def = 0;
                switch (sex)
                {
                    case E_Sex.Male:
                        sexStr = "男性";
                        atk += 50;
                        def += 100;
                        break;
                    case E_Sex.Female:
                        sexStr = "女性";
                        atk += 150;
                        def += 20;
                        break;
                }
                Console.WriteLine("请选择职业(战士0 猎人1 法师2)");
                E_JobType jobType = (E_JobType)int.Parse(Console.ReadLine());
                string skill = "";
                string job = "";
                switch (jobType)
                {
                    case E_JobType.Warrier:
                        atk += 20;
                        def += 100;
                        skill = "冲锋";
                        job = "战士";
                        break;
                    case E_JobType.Hunter:
                        atk += 120;
                        def += 30;
                        skill = "假死";
                        job = "猎人";
                        break;
                    case E_JobType.Fashi:
                        atk += 200;
                        def += 10;
                        skill = "奥术冲击";
                        job = "法师";
                        break;
                }
                Console.WriteLine("您选择了\"{0}{1}\",攻击力：\"{3}\",防御力：\"{4}\",技能：\"{5}\"",sexStr,job,atk,def,skill);
            }
            catch
            {
                Console.WriteLine("请输入数字");
            }
            #endregion
        }
    }
}
