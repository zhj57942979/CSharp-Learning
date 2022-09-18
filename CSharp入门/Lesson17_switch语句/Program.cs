using System;

namespace Lesson17_switch语句
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("switch语句");
            #region 知识点一 作用

            #endregion

            #region 知识点二 基本语法
            //switch (变量) 
            //{
            //    //当变量==常量 执行case和break中代码
            //    case 常量:
            //        //满足条件执行的代码
            //        break;
            //    case 常量:
            //        break;
            //    default:
            //        //如果条件都不满足 就会执行default中的代码
            //        break;
            //}
            // 常量！！智能写一个值 不能写范围或者条件 
            // switch 只判断变量是否等于某一个固定值!!

            int a = 3;
            switch (a)
            {
                //case 后面一定是常量 变量都不行
                case 1:
                    Console.WriteLine("a等于1");
                    break;
                case 2:
                    Console.WriteLine("a等于2");
                    break;
                case 3:
                    Console.WriteLine("a等于3");
                    break;
                default:
                    Console.WriteLine("什么条件都不满足 ");
                    break;
            }

            float f = 1.4f;
            //一般配合枚举使用
            switch (f)
            {
                case 1.5f:
                    Console.WriteLine("f等于1.5");
                    break;
                case 1:
                    Console.WriteLine("f等于1");
                    break;
                default:
                    Console.WriteLine("什么条件都不满足 ");
                    break;
            }


            #endregion

            #region 知识点三 default可省略
            //什么都不想做可以不写default
            string str = "123";
            switch (str)
            {
                case "123":
                    Console.WriteLine("str等于123");
                    break;
                case "234":
                    Console.WriteLine("str等于234");
                    break;
            }
            #endregion

            #region 知识点四 可自定义常量
            char c = 'A';
            const char c2 = 'A';
            switch (c)
            {
                case c2:
                    Console.WriteLine("c等于A");
                    break;
                default:
                    break;
            }
            #endregion

            #region 知识点五 贯穿
            //满足某些条件时 做的事情是一样的就可以使用贯穿
            int aa = 1;
            switch (aa)
            {
                //不写case对于的break就是贯穿
                //满足1或者2中一个条件久惠执行之后代码
                case 1:
                case 2:
                    //case和break之间可以写n句语句
                    //并且可以嵌套使用
                    Console.WriteLine("是个数字");
                    if (aa == 1) {
                        Console.WriteLine("aa等于1");
                    }
                    break;
                default:
                    break;
            }
            #endregion
        }
    }
}
