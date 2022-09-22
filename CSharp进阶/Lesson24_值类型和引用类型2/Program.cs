using System;
using System.Collections.Generic;

namespace Lesson24_值类型和引用类型2
{
    class Test
    {

    }
    struct TestStrict
    {
        public Test t;
        public int i;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("值类型和引用类型2");

            #region 知识回顾
            //值类型
            //有符号 无符号 浮点数 特殊 枚举 结构体

            //引用类型
            //string 数组 class interface 委托

            //本质区别 栈内存 堆内存
            #endregion

            #region 问题一 如何判断 值类型和引用类型
            //F12 进到类型的内部去查看
            //是class就是引用
            int i = 12;
            string str = "123";
            //是struct就是值

            #endregion

            #region 问题二 语句块
            //命名空间
            // 向下
            //类 接口 结构体
            // 向下
            //函数 属性 索引器 运算符重载等(类 接口 结构体)
            // 向下
            //条件分支 循环

            //上层语句块 类 结构体
            //中层语句块 函数
            //底层语句块 条件分支 循环等

            //我们的逻辑代码写在哪里?
            //函数 条件分支 循环-中底层语句块中

            //我们的变量可以申明在哪里?
            //上 中 底都能申明变量
            //上层语句块中 成员变量
            //中 底层语句块中 临时变量
            #endregion

            #region 问题三 变量的生命周期
            //编程时 大部分都是临时变量
            //在中底层申明的临时变量
            //语句块执行结束
            //没有被记录的对象将被回收或变成垃圾
            //值类型 被系统自动回收
            //引用类型 栈上用于存地址的房间被系统自动回收 堆中具体内容变成垃圾 等待下次GC回收

            //想要不被回收或者不变垃圾
            //必须将其记录下来
            //如何记录？
            //在更高层级记录或者
            //使用静态全局变量记录
            #endregion

            #region 问题四 结构体中的值和引用
            //结构体本身是值类型
            //前提 该结构体没有做为其他类的成员
            //在结构体中的值 栈中存储值具体的内容
            //在结构体中的引用 堆中存储引用具体的内容

            //引用类型始终存储在堆中
            //真正通过结构体使用其中引用类型时只是顺藤摸瓜
            #endregion

            #region 问题五 类中的值和引用
            //类本身是引用类型
            //在类中的值 堆中存储具体的值
            //在类中的引用 堆中存储具体的值

            //值类型跟着大哥走 引用类型一根筋
            #endregion

            #region 问题六 数组中的存储规则
            //数组本身是引用类型
            //值类型数组 堆中房间存具体内容
            //引用类型数组 堆中房间存地址 指向堆中另外一个房间
            #endregion

            #region 问题七 结构体继承接口
            //利用里氏替换原则 用接口容器装载结构体存在装箱拆箱

            TestStruct obj1 = new TestStruct();
            obj1.Value = 1;
            Console.WriteLine(obj1.Value);
            TestStruct obj2 = obj1;
            obj2.Value = 2;
            Console.WriteLine(obj1.Value);
            Console.WriteLine(obj2.Value);

            ITest iObj1 = obj1;//装箱 value1
            ITest iObj2 = iObj1;
            iObj2.Value = 99;
            Console.WriteLine(iObj1.Value);
            Console.WriteLine(iObj2.Value);

            TestStruct obj3 = (TestStruct)iObj1;//拆箱

            #endregion
        }
    }
    interface ITest
    {
        int Value
        {
            get;
            set;
        }
    }

    struct TestStruct : ITest
    {
        public int Value 
        {
            get
            {
                return Value;
            }
            set
            {
                this.Value = Value;
            }
        }
    }
}
