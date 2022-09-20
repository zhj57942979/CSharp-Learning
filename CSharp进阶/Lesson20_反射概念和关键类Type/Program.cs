using System;
using System.Reflection;

namespace Lesson20_反射概念和关键类Type
{
    #region 知识点回顾
    //编译器是一种翻译程序
    //它用于将源语言程序翻译为目标语言程序

    //源语言程序: 某种程序设计语言写成的 比如C C# C++ Java等语言写的程序
    //目标语言程序 二进制表示的伪机器代码写的程序
    #endregion

    #region 知识点一 什么是程序集
    //程序集是经由编译器编译得到的 供进一步编译执行的那个中间产物
    //在WINDOWS系统中 它一般表现为后缀为.dll(库文件)或者是.exe(可执行文件)的格式

    //说人话
    //程序集就是我们写的一个代码集合 我们现在写的所以代码
    //最终都会被编译器翻译为一个程序集供别人使用
    //比如一个代码库文件(dll)或者一个可执行文件(exe)
    #endregion

    #region 知识点二 元数据
    //元数据就是用来描述数据的数据
    //这个概念不仅仅用于程序上 在别的领域也有元数据

    //说人话
    //程序中的类 类中的函数 变量等等信息就是 程序的 元数据
    //有关程序以及类型的数据被称为 元数据 他们保存在程序集中
    #endregion

    #region 知识点三 反射的概念
    //程序正在进行时 可以查看其他程序集或者自身的元数据
    //一个运行的程序查看本身或者其他程序的元数据的行为就叫做反射

    //说人话
    //在程序运行时 通过反射可以得到其他程序集或者自己程序集代码的各种信息
    //类 函数 变量 对象、等等 实例化它们 执行它们 操作它们
    #endregion

    #region 知识点四 反射的作用
    //因为反射可以在程序编译后获得信息 所以它提高了程序的拓展性和灵活性
    //1 程序运行时得到所有元数据 包括元数据的特性
    //2 程序运行时 实例化对象 操作对象
    //3 程序运行时 创建新对象 用这些对象执行人物
    #endregion

    class Test
    {
        private int i = 1;
        public int j = 0;
        public string str = "123";

        public Test()
        {

        }

        public Test(int i)
        {
            this.i = i;
        }

        public Test(int i, string str) : this(i)
        {
            this.str = str;
        }

        public void Speak()
        {
            Console.WriteLine(i);
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("反射概念和关键类Type");

            #region 知识点五 语法相关

            #region Type
            //Type (类的信息类)
            //它是反射功能的基础
            //他是访问元数据的主要方式
            //使用Type的成员获取有关类型申明的信息
            //有关类型的成员(如构造函数 方法 字段 属性和类的事件)

            #region 获取Type
            //1 万物之父object中的 GetType() 可以获取对象的Type
            int a = 42;
            Type type = a.GetType();
            Console.WriteLine(type);

            //2 通过typerof关键字 传入类名 也可以得到对象的Type
            Type type2 = typeof(int);
            Console.WriteLine(type2);

            //3 通过类的名字 也可以获取类型
            //  注意 类名必须包括命名空间 不然找不到 Full Name
            Type type3 = Type.GetType("System.Int32");
            Console.WriteLine(type3);

            //上面三个Type指向的内存地址是同一个 每一个类的信息是唯一的

            #endregion

            #region 得到类的程序集信息
            //可以通过Type可以得到类型所在程序集信息
            Console.WriteLine(type.Assembly);
            Console.WriteLine(type2.Assembly);
            Console.WriteLine(type3.Assembly);
            #endregion

            #region 获取类中的所有公共成员
            //首先得到Type
            Type t = typeof(Test);
            //然后得到所有公共成员
            //需要引用命名空间 using System.Reflection;
            MemberInfo[] infos = t.GetMembers();
            for (int i = 0; i < infos.Length; i++)
            {
                Console.WriteLine(infos[i]);
            }
            //通过Type得到所有成员变量的源数据
            #endregion

            #region 获取类的公共构造函数并调用
            //1 获取所有构造函数
            ConstructorInfo[] ctors = t.GetConstructors();
            for (int i = 0; i < ctors.Length; i++)
            {
                Console.WriteLine(ctors[i]);
            }

            //2 获取其中一个构造函数 并执行
            //得构造函数传入 Type数组 数组中内容按顺序是参数类型
            //执行构造函数传入 object数组 表示按顺序传入的参数
            //  2-1得到无参构造
            ConstructorInfo info = t.GetConstructor(new Type[0]);
            //执行无参构造 无参构造 没有参数 传null
            Test obj = info.Invoke(null) as Test;
            Console.WriteLine(obj.j);
            //  2-2得到无参构造

            #endregion

            #endregion

            #region Assembly

            #endregion

            #region Activation

            #endregion

            #endregion
        }
    }
}
