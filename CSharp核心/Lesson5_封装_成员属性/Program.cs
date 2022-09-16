using System;

namespace Lesson5_封装_成员属性
{

    #region 知识回顾
    //class Person
    //{
    //    //特征-成员变量
    //    private int age;
    //    private string name;
    //    //金钱
    //    private int money;
    //    //行为-成员方法
    //    public void Speak()
    //    {

    //    }
    //    //初始化调用-构造函数
    //    public Person(int age)
    //    {

    //    }
    //    public  Person(int age,string name)
    //    {

    //    }
    //    //释放时调用-析构函数
    //    ~Person()
    //    {

    //    }
    //}
    #endregion

    #region 知识点一 成员属性的基本信息
    //基本概念
    //1 用于保护成员变量
    //2 为成员属性的获取和赋值添加逻辑处理
    //3 为解决3p的局限性
    //   public 内外访问
    //   purivate 内部访问
    //   protected 内部和子类访问
    //   属性可以让成员变量在外部
    //   只能获取 不能修改 或者 不能修改 不能获取
    #endregion

    #region 知识点二 成员属性的基本语法
    // 访问修饰符 属性类型 属性名
    // {
    //     get{}
    //     set{}
    // }
    class Person
    {
        private string name;
        private int age;
        private bool sex;
        private int money;
        private float height;

        //属性的命名一般使用 帕斯卡命名法
        public string Name
        {
            //通过这个成员属性 我们可以在外部get到name
            get
            {
                //可以在返回之前添加一些逻辑规则
                //意味这 这个属性可以获取的内容
                return name;
            }

            set
            {
                //可以在设置之前添加一些逻辑规则
                //设置的目的是 如果外部改变了Name 内部也要更改name变量
                // valus 关键字 用于表示 外部传入的值
                name = value;
                //
            }
        }

        #region 知识点四 成员属性中 get和set前可以加访问修饰符
        //注意
        //1 默认不加 会使用属性申明时的访问权限
        //2 加的访问权限要低于属性的访问权限
        //3 不能让get和set的访问权限都低于属性的权限

        //get 加了private 外部就不能访问money了 set加了private就无法在外部修改了
        //通过增加访问修饰符 实现只得不改 和 只改不得
        #endregion

        public int Money
        {
            get
            {
                //属性中可以进行加密处理或者逻辑判断
                //解密操作
                return money - 5;
            }
            set
            {
                //属性中可以进行加密处理或者逻辑判断起到保护作用
                if (value < 0)
                {
                    value = 0;
                    Console.WriteLine("钱不能少于0，强制设置为0了"); 
                }
                //加密
                money = value + 5;
            }
        }
        #region 知识点五 get和set可以只有一个
        //注意
        //只有一个时 没必要在前面加访问修饰符
        //作用 起到安全保护的作用
        #endregion

        public bool Sex
        {
            //如果 get set只有一个 一般都是只有get
            get
            {
                return sex;
            }
        }

        #region 知识点六 自动属性
        //作用 外部能得不能改的特征
        //如果类中有一个特征是只希望外部能得不能改得 又没什么特殊处理
        //那么可以直接使用自动属性
        #endregion
        public float Height
        {
            get;
            private set;
        }
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            //如果没有特殊需求 建议用成员变量减少开销
            //如果有就用成员属性
            Console.WriteLine("成员属性");

            #region 知识点三 成员属性的使用
            Person p = new Person();
            p.Name = "唐老师";//这一步执行set语句块
            Console.WriteLine(p.Name);//这一步执行 get语句块

            p.Money = 1000;
            Console.WriteLine(p.Money);

            Console.WriteLine(p.Sex);

            #endregion

        }
    }
    //总结
    //1 一般保护成员变量的
    //2 成员属性的使用和变量一样 外部用对象点出
    //3 get中需要return内容 set中用value传入
    //4 get和set可以加逻辑处理
    //5 get和set可以加访问修饰符 但是要符合规则
    //6 get和set可以只有一个
    //7 自动属性只有get和set 一般用于外部能得不能改这种情况
}
