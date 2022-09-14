using System;

namespace Lesson1_枚举
{
    #region 知识点二 在哪里枚举
    //1. 在namespace语句块中
    //2. class语句块中 struct语句块中
    //3. 枚举不能在函数语句中申明

    enum E_MonsterType
    {
        Normal,//0

        Boss,//1
    }

    enum E_PlayerType
    { 
        Main,

        Other,
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("枚举");
            #region 知识点一 基本概念
            //被命名的整形常量集合

            //申明枚举 和 申明枚举变量
            //申明枚举 创建一个自定义的枚举类型
            //申明枚举变量 使用自定义的枚举类型 创建一个变量

            //申明枚举语法
            //枚举名以E_开头
            //enum E_自定义枚举名 {
            //    自定义枚举型名字，//枚举中包裹的整形常量 第一个默认值是0 下面依次累加
            //    自定义枚举型名字1，// 1
            //    自定义枚举型名字2，// 2
            // }
            //enum E_自定义枚举名
            //{
            //    自定义枚举型名字 = 5，//第一个默认值是5 下面依次累加
            //        自定义枚举型名字1，// 6
            //        自定义枚举型名字2 = 100，// 100
            //        自定义枚举型名字3,// 101
            //}
            #endregion

            #region 知识点三 枚举的使用
            //申明枚举变量
            //自定义枚举类型 变量名 = 默认值;(自定义枚举类型.枚举项)
            E_PlayerType playerType = E_PlayerType.Main;

            if (playerType == E_PlayerType.Main)
            {

                Console.WriteLine("主玩家逻辑");
            }
            else if (playerType == E_PlayerType.Other) {
                Console.WriteLine("其他玩家逻辑");
            }

            //枚举和swithc是天生一对
            E_MonsterType monsterType = E_MonsterType.Boss;
            switch (monsterType) 
            {
                case E_MonsterType.Normal:
                    Console.WriteLine("normal逻辑");
                    break;
                case E_MonsterType.Boss:
                    Console.WriteLine("boss逻辑");
                    break;
                default:
                    break;
            }
            #endregion

            #region 知识点四 枚举的类型转换
            //枚举和int互相转换
            int i = (int)playerType;
            Console.WriteLine(i);
            //int转枚举
            playerType = 0;

            //枚举和string相互转换
            string str = playerType.ToString();
            Console.WriteLine(str);
            //string转枚举
            //Parse 后第一个参数 你要转的目标类型 第二个参数 用于转换的对应枚举项的字符串
            //转换完毕后 是一个通用的类型 我们需要用括号强转成我们想要的目标枚举类型
            playerType = (E_PlayerType)Enum.Parse(typeof(E_PlayerType), "Other");
            Console.WriteLine(playerType);
            #endregion

            #region 知识点五 枚举的作用
            //在游戏开发中，对象很多时候 会有许多状态
            //比如玩家 有一个动作状态 我们需要用一个变量或者标识 来表示当前玩家状态
            //综合考虑可能用int来表示状态
            //1行走 2下蹲 3跳跃。。。

            //枚举可以帮助我们 清晰分清楚状态的含义
            #endregion
        }

    }
}
