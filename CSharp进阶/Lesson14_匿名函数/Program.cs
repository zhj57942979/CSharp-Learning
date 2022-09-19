using System;

namespace Lesson14_匿名函数
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("匿名函数");

            #region 知识点一 什么是匿名函数
            //顾名思义 就是没有名字的函数
            //匿名函数的使用主要是配合委托和事件进行使用
            //脱离委托和事件 是不会使用匿名函数的------重要
            #endregion

            #region 知识点二 基本语法
            //delegate (参数列表)
            //{
            //   //函数逻辑
            //};
            //何时使用?
            //1 函数中传递委托参数时
            //2 委托或事件赋值时
            #endregion

            #region 知识点三 使用
            //1 无参无返回
            //申明 然后放进 Action 委托
            //这样申明匿名函数 只是在申明函数而已 还没有调用
            //真正调用它的时候 是这个委托容器什么时候调用 就是什么时候调用这个匿名函数
            Action a = delegate ()
            {
                Console.WriteLine("匿名函数逻辑");
            };
            a();
            //2 有参
            Action<int, string> b =  delegate (int a, string b)
            {
                Console.WriteLine(a);
                Console.WriteLine(b);
            };

            b(100, "123");
            //3 有返回值
            Func<string> c = delegate ()
            {
                return "123123";
            };

            Console.WriteLine(c());
            //4 一般情况会作为函数参数传递 或者 作为函数返回值
            Console.WriteLine("*********************");
            Test t = new Test();
            Action ac = delegate ()
            {
                Console.WriteLine("随参数传入的匿名函数逻辑");
            };
            t.Dosomething(50, ac);
            //  参数传递
            Console.WriteLine("*********************");
            t.Dosomething(100, delegate ()
            {
                Console.WriteLine("随参数传入的匿名函数逻辑");
            });
            //  返回值
            Action ac2 = t.GetFun();
            ac2();
            //一步到位 直接调用返回的委托函数
            t.GetFun()();
            #endregion

            #region 知识点四 匿名函数的缺点
            //添加到委托或事件容器中后 不记录 无法单独移除

            Action ac3 = delegate ()
            {
                Console.WriteLine("匿名函数一");
            };

            ac3 += delegate ()
            {
                Console.WriteLine("匿名函数二");
            };

            ac3();
            //因为匿名函数没有名字 所以没有办法指定移除某一个匿名函数 -= 也不行
            //只能清空
            ac3 = null;
            #endregion

        }
    }

    class Test
    {
        public Action action;

        //作为参数传递时
        public void Dosomething(int a, Action fun)
        {
            Console.WriteLine(a);
            fun();
        }

        //作为返回值
        public Action GetFun()
        {
            return delegate () {
                Console.WriteLine("函数内部返回的一个匿名函数逻辑");
            };
                ;
        }
    }

    //总结
    //匿名函数就是没有名字的函数
    //delegate(参数列表){}
    //主要是在 委托传递和存储时 为了方便可以直接使用匿名该函数
    //缺点是 没有办法指定移除 
    //一般在委托只有一个函数时使用
}
