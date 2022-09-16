using System;

namespace Lesson17_多态_vob
{
    #region 知识回顾

    #region 封装 用程序语言来形容对象

    #endregion

    #region 封装 复用封装对象的代码 儿子继承父亲 复用现成代码

    #endregion

    #endregion

    #region 知识点一 多态的概念
    //多态按字面的意思就是 多种状态
    //让继承同一父类的子类们 在执行相同方法时有不同的表情（状态）
    //主要目的
    //同一父类的对象 执行相同行为（方法）有不同的表现
    //解决的问题
    //让同一个对象有唯一行为的特征
    #endregion

    #region 知识点二 解决的问题
    class Father
    {
        public void Speakname()
        {
            Console.WriteLine("Father的方法");
        }
    }

    class Son : Father
    {
        public void Speakname()
        {
            Console.WriteLine("Son的方法");
        }
    }
    #endregion

    #region 知识点三 多态的实现
    //我们之前已经学过的多态
    //编译时多态 函数重载 开始就写好了

    //我们将学习的
    //运行时的多态（vob, 抽象函数, 接口）
    //今天学习 vob
    //v virtual 虚函数
    //o override 重写
    //b base 父类

    class GameObject
    {
        public string name;
        public GameObject(string name)
        {
            this.name = name;
        }
        //虚函数可以被子类重写
        public virtual void Atk()
        {
            Console.WriteLine("游戏对象进行攻击");
        }
    }

    class Player : GameObject
    {
        public Player(string name) : base(name)
        {

        }
        //重写虚函数
        public override void Atk()
        {
            //base的作用
            //代表父类 可以通过base来保留父类的行为

            //指定保留父类攻击行为 
            //如果在父类基础上要加逻辑 就可以加代码
            base.Atk();
            Console.WriteLine("玩家对象进行攻击");
        }
    }

    class Monster : GameObject
    {
        public Monster(string name):base(name)
        {

        }

        public override void Atk()
        {
            Console.WriteLine("怪物对象进行攻击");
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region 解决的问题
            Father f = new Son();
            f.Speakname();

            (f as Son).Speakname();
            #endregion

            #region 多态的使用
            GameObject p = new Player("唐老师");
            p.Atk();
            (p as Player).Atk();

            GameObject p1 = new Monster("111");
            p1.Atk();
            (p1 as Monster).Atk();
            #endregion
        }
    }
    //总结
    //多态 让同一类型的对象 执行相同行为不同表现
    //解决问题 让同一对象有唯一的行为特征

    //virtual
    //override
    //base
    //v和o一定是结合使用 来实现多态

}
