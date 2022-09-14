using System;

namespace Lesson7_函数
{
    class Program
    {
        #region 知识点一 基本概念
        //函数也被称为方法

        //作用
        //封装代码 提升代码复用率 抽象行为
        #endregion

        #region 知识点二 函数写在哪里
        //class语句中
        //struct语句中
        #endregion

        #region 知识点三 基本语法
        //
        // static 返回类型 函数名(参数类型 参数名1, 参数类型 参数名2, ...)
        //{
        //  函数的代码逻辑;
        //  return 返回值;（如果有返回类型才返回）
        //}

        //关于static 不是必须的 没有 学习类和结构体之前都是必须的
        // void 没有返回值
        // 返回类型可以是任意的变量类型 14中变量类型...
        //关于函数名 使用帕斯卡命名法 MyName
        //参数不是必须的， 可以有0到n个参数，参数类型可以是任意类型 参数用逗号隔开
        //参数使用驼峰命名法
        //当返回值不为void时，必须通过return返回对应内容（void也可以选择使用return）
        #endregion

        #region 知识点四 实际应用
        //无参数无返回值的函数
        static void SayHellow()
        {
            Console.WriteLine("你好世界");
            //return;
        }

        //有参数无返回值的函数
        static void SayYourName(string name)
        {
            Console.WriteLine("你的名字是：{0}", name);
        }

        //无参数有返回值的函数

        static string WhatYourName() {
            return "唐老师";
        }

        //有参数有返回值的函数

        static int Sum(int a, int b)
        {
            int sum = a + b;
            return sum;
        }

        //有参数多返回值的函数

        static int[] Calc(int a, int b)
        {
            int sum = a + b;
            int avg = sum / 2;
            return new int[] { sum, avg };
        }

        #endregion

        #region 知识点五 关于return
        //即使函数没有函数值也可以使用return
        //return可以直接不执行之后的代码 直接返回到函数外部

        static void Speak(string str)
        {
            if(str == "混蛋")
            {
                return;
            }
            Console.WriteLine(str);
        }
        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("函数");

            SayHellow();

            //参数可以是常量 变量 函数
            SayYourName("唐老师啊");

            SayYourName(WhatYourName());

            Console.WriteLine(Sum(1, 1));
            int[] arr = Calc(5, 7);
            Console.WriteLine(arr[0] +"*"+ arr[1]);

            Speak("混蛋");
            
        }
    }
}
