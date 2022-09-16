using System;

namespace Lesson16_继承_密封类
{
    #region 知识点一 基本概念
    //密封类 是使用 sealed密封关键字修饰的类
    //作用 让类无法再被继承
    #endregion

    #region 知识点二 实例
    class Father
    {

    }

    sealed class Son : Father
    {
        //只要加了sealed就会结扎
    }

    #endregion

    #region 知识点三 作用
    //在面向对象程序的设计中 密封类的主要作用就是不允许最底层子类被继承
    //可以保证程序的规范性 安全性
    //目前对于大家来说 可能用处不大
    //随着大家的成长 以后制作复杂系统或者程序框架时 便能慢慢体会到密封的作用
    #endregion

    //总结
    // 关键字 sealed
    // 作用 让类无法再被继承
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("密封类");
        }
    }
}
