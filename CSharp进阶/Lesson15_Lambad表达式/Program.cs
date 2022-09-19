using System;

namespace Lesson15_Lambad表达式
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lambad表达式");

            #region 知识点一 什么是lambad表达式
            //可以将lambad表达式 理解为匿名函数的简写
            //它除了写法不同外
            //使用上和匿名函数一模一样
            //都是和委托或者事件 配合使用的
            #endregion

            #region 知识点二 lambad表达式语法
            //匿名函数
            //delegate (参数列表)
            //{

            //};

            //lambad表达式
            //(参数列表) =>
            //{
            //  //函数体
            //};
            #endregion

            #region 知识点四 使用
            //1 无参无返回
            Action a = () =>
            {
                Console.WriteLine("无参无返回值的lambad表达式");
            };
            a();
            //2 有参
            Action<int> a2 = (int value) =>
            {
                Console.WriteLine("有参数Lambad表达式{0}", value);
            };
            a2(100);

            //3 甚至参数类型都可以省略 参数类型和委托或事件容器一致
            Action<int> a3 = (value) =>
            {
                Console.WriteLine("省略参数类型的写法{0}", value);
            };
            a3(200);
            //4 有返回值
            Func<string, int> a4 = (value) =>
             {
                 Console.WriteLine("有返回值有参数的lambad表达式{0}", value);
                 return 1;
             };
            Console.WriteLine(a4("123123"));

            //其他传参使用等和匿名函数一样
            //缺点也是和匿名函数一样的----没有办法指定函数
            #endregion

            Test t = new Test();
            t.Dosomething();
        }
    }
    #region 知识点四 闭包
    //内层的函数可以引用包含在它外层的函数的变量
    //即使外层函数的执行已经终止
    //注意
    //该变量提供的值并非变量创建时的值 而是在父函数范围内的最终值

    class Test
    {
        public event Action action;

        public Test()
        {
            int value = 10;
            //这里就形成了闭包
            //因为 当构造函数执行完毕时 其中申明的临时变量value的生命周期被改变了
            action = () =>
            {
                Console.WriteLine(value);
            };

            for (int i = 0; i < 10; i++)
            {
                //此index 非彼index
                int index = i;
                action += () =>
                {
                    //当这个lambad(event)使用时 循环已经结束了
                    //如果是i 就是10 index就是0-9
                    Console.WriteLine(index);
                };
            }
        }

        public void Dosomething()
        {
            action();
        }
    }

    #endregion

    //总结
    //匿名函数的特殊写法就是lambad表达式
    //固定写法
    // (参数列表)=>{ }
    //主要在 委托传递和存储时 为了方便可以直接使用匿名函数或者lambad表达式

    //缺点 无法指定移除
}
