using System;

namespace Lesson19_多态_接口
{
    #region 知识点一 接口的概念
    //接口是行为的抽象规范
    //他也是一种自定义类型
    //关键字 interface

    //接口申明的规范
    //1 不包含成员变量
    //2 只包含方法 属性 索引器 事件
    //3 成员不能被实现
    //4 成员可以不用写访问修饰符 不能是私有的
    //5 接口不能继承类 但是可以继承另一个接口

    //接口的使用规范
    //1 类可以继承多个接口
    //2 类继承接口后 必须实现接口中所有成员

    //特点
    //1 他和类的申明类似
    //2 接口是用来继承的
    //3 接口不能被实例化 但是可以作为容器存储对象
    #endregion

    #region 知识点二 接口的申明
    //接口关键字 interface
    //语法
    // interface 接口名
    // {
    // }
    //一句话记忆 接口是抽象行为的 基类
    //接口命名规范 帕斯卡前面加个I

    interface IFly
    {
        //不能是private 不写默认public
        //方法
        public void Fly();
        //属性
        string Name
        {
            //自动属性写法 不能具体实现
            get;
            set;
        }
        //索引器
        int this[int index]
        {
            get;
            set;
        }
        //事件
        event Action doSomething;
    }
    #endregion

    #region 知识点三 接口的使用
    //接口是用来继承的
    class Animal
    {

    }

    //1 类可以继承1个类 n个接口
    //2 继承了接口后 必须实现其中的内容 并且必须是public的
    class Person : Animal, IFly
    {
        //如果是protected 就必须显示实现
        //3 实现的接口前面可以加virtual 再在子类重写
        public virtual void Fly()
        {

        }

        public string Name
        {
            get;
            set;
        }

        public int this[int index]
        {
            get
            {
                return 0;
            }
            set
            {
                
            }
        }

        public event Action doSomething;
    }

    #endregion

    #region 知识点四 接口可以继承接口
    //接口继承接口 不需要实现
    //待类继承接口后 类自己去实现所有内容
    interface IWalk
    {
        void Walk();
    }

    interface IMove:IFly, IWalk
    {

    }

    class Test : IMove
    {
        public int this[int index] { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public string Name { get => throw new NotImplementedException(); set => throw new NotImplementedException(); }

        public event Action doSomething;

        public void Fly()
        {
            throw new NotImplementedException();
        }

        public void Walk()
        {
            throw new NotImplementedException();
        }
    }
    #endregion

    #region 知识点五 显示实现接口
    //当一个类继承两个接口
    //但是接口中存在着同名方法时
    //注意 显示实现接口时 不能写访问修饰符

    interface IAtk
    {
        void Atk();
    }

    interface ISuperAtk
    {
        void Atk();
    }

    class Player : IAtk, ISuperAtk
    {
        //如果直接写 Atk() 就失去了两个方法的意义了
        //显示实现接口就是用 接口名.成员名 去实现
        void IAtk.Atk()
        {
            Console.WriteLine("Atk");
        }

        void ISuperAtk.Atk()
        {
            Console.WriteLine("SuperAtk");
        }

        public void Atk()
        {
            Console.WriteLine("Player的Atk");
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("接口");
            //4 接口也遵循里氏替换原则
            IFly f = new Person();

            IMove im = new Test();
            IFly ifly = new Test();
            IWalk iw = new Test();

            Player p = new Player();
            (p as IAtk).Atk();
            (p as ISuperAtk).Atk();
        }
    }

    //总结
    //继承类 是对象之间的继承 包括特征行为等待
    //继承接口 是行为之间的继承 继承接口的行为规范 按照规范去实现内容
    
}
