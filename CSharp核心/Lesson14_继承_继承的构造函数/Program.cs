using System;

namespace Lesson14_继承_继承的构造函数
{

    #region 知识回顾
    //构造函数
    //实例化对象时调用的函数
    //主要用来初始化成员变量
    //每个类 都会有一个默认的无参构造函数

    //语法
    //不写返回值
    //函数名和类名相同
    //访问修饰符根据需求而定 一般是public 
    //构造函数可以重载
    //可以用this语法重用代码

    //注意
    //有参构造会顶掉无参构造
    //如想保留无参构造需重载

    class Test
    {
        public int testI;
        public string testStr;
        public Test()
        {

        }
        public Test(int i)
        {
            this.testI = i;
        }
        public Test(int i, string str) : this(i)
        {
            this.testStr = str;
        }
    }
    #endregion

    #region 知识点一 继承中的构造函数 基本概念
    //特点
    //当申明一个子类对象时
    //先执行父类的构造函数
    //再执行子类的构造函数

    //注意
    //1 父类的无参构造 很重要
    //2 子类可以通过base关键字 代表父类 调用父类构造
    #endregion

    #region 知识点二 继承中构造函数的执行顺序
    //父类的父类的构造->...父类的构造->...->子类构造

    class GameObject
    {
        public GameObject()
        {
            Console.WriteLine("GameObject的构造函数");
        }
    }
    class Player : GameObject
    {
        public Player()
        {
            Console.WriteLine("Player的构造函数");
        }
    }
    class MainPlayer : Player
    {
        public MainPlayer()
        {
            Console.WriteLine("MainPlayer的构造函数");
        }
    }
    #endregion

    #region 知识点三 父类的无参构造函数 很重要
    //子类实例化时 默认自动调用 父类的无参构造 所以如果父类无参构造被顶掉 会报错
    class Father
    {
        //public Father()
        //{

        //}
        public Father(int i)
        {
            Console.WriteLine("Father构造");
        }
    }

    class Son : Father
    {
        #region 知识点四 通过base调用指定父类构造
        //base写法类似this 传父类的参数
        public Son(int i) :base(i)
        {
            Console.WriteLine("Son的一个函数的构造");
        }
        //this 简介调用上面base的函数
        public Son(int i,string str) : this(i)
        {
            Console.WriteLine("Son的两个函数的构造");
        }
        #endregion
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            MainPlayer mp = new MainPlayer();

            Son s = new Son(1,"123");
        }
    }

    //特点
    //执行顺序 先执行父类的构造函数 再执行子类的 从老祖宗开始 一次一代代向下
    
    //父类的无参构造函数很重要

    //this和base的区别
    //this代表自己的另外一个构造函数
    //base代表父类的构造函数
}
