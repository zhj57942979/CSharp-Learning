using System;

namespace Lesson18_多态_抽象类和抽象方法
{

    #region 知识点一 抽象类
    //概念
    //被抽象关键字 abstract 修饰的类
    //特点
    //1 不能被实例化的类
    //2 可以包含抽象方法
    //3 继承抽象类必须重新其抽象方法

    abstract class Thing
    {
        //抽象类中 封装的所有知识点都可以在其中书写
        public string name;

        //可以在抽象类中写抽象函数
    }

    class Water : Thing
    {

    }
    #endregion

    #region 知识点二 抽象方法
    //又叫 纯虚方法
    //用 abstract 关键字修饰的方法
    //特点
    //1 只能在抽象类中申明
    //2 没有方法体
    //3 不能是私有的
    //4 继承后必须实现 用override重写

    abstract class Fruits
    {
        public string name;
        //不能是私有的
        //抽象方法 是不能有函数体的
        public abstract void Bad();
        //虚方法是有函数体的 
        public virtual void Test()
        {
            //可以选择是否写逻辑
        }
    }

    class Apple : Fruits
    {
        public override void Bad()
        {
            
        }
        //虚方法可以由子类选择性实现
        //抽象方法必须要实现
    }

    class SuperApple : Apple
    {
        //虚方法和抽象方法 都可以被子类无限去重写
        public override void Bad()
        {
            base.Bad();
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("抽象类和抽象方法");

            //抽象类不能被实例化
            //Thing t = new Thing();
            //但是可以根据里氏替换原则 用父类容器装子类
            Thing t1 = new Water();
        }
    }

    //注意 如何选择普通类还是抽象类
    //不希望被实例化的对象 相对比较抽象的类可以使用抽象类
    //父类中的行为不太需要被实现的 只希望子类去定义具体的规则
    //可以选择抽象类然后使用其中的抽象方法来定义规则
    //作用
    //整体框架设计时 会使用
}
