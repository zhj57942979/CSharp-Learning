using System;

namespace Lesson12_委托
{
    #region 知识点一 委托是什么
    //委托是 函数（方法）的容器
    //可以理解为表示函数（方法）的变量类型
    //用来 存储 传递函数（方法）
    //委托的本质是一个类 用来定义函数（方法）的类型 （返回值和参数的类型）
    //不同的 函数（方法）必须对应和各自“格式”一致的委托
    #endregion

    #region 知识点二 基本语法
    //关键字 delegate
    //语法 访问修饰符 delegate 返回值 委托名(参数列表);

    //写在哪里
    //可以申明在namespace和class语句块中
    //更多的写在 namespace 中

    //简单记忆委托语法 就是 函数申明语法前面加一个delegate关键字
    #endregion

    #region 知识点三 定义自定义委托
    //访问修饰符默认不写 为public 在别的命名空间中也能使用
    //private 其他命名空间就不能用了
    //一般使用public

    //申明了一个可以用来存储无参无返回值函数的容器
    delegate void MyFun();
    //同一语句块中 委托名不能重名
    //表示用来装载或传递 返回值为int 有一个int参数的函数的 委托 容器规则
    public delegate int MyFun2(int a);

    //委托是支持 泛型的 可以让返回值和参数 可变 更方便我们的使用
    delegate T MyFun3<T, K>(T v, K k);
    #endregion

    #region 知识点四 使用定义好的委托
    //委托变量是函数的容器

    //委托常用在
    //1 作为类的成员
    //2 作为函数的参数
    class Test
    {
        public MyFun fun;
        public MyFun2 fun2;

        public Action action;

        public void TestFun(MyFun fun, MyFun2 fun2)
        {
            //先处理一些别的逻辑 当这些逻辑处理完了 再执行传入的函数
            int i = 1;
            i *= 2;
            i += 2;

            //fun();
            //fun2(2);
            //this.fun = fun;
            //this.fun2 = fun2;
        }

        #region 增
        public void AddFun(MyFun fun, MyFun2 fun2)
        {
            this.fun += fun;
            this.fun2 += fun2;
        }
        #endregion

        #region 删
        public void RemoveFun(MyFun fun, MyFun2 fun2)
        {
            //将函数从容器中移出来
            this.fun -= fun;
            this.fun2 -= fun2;
        }
        #endregion
    }
    #endregion

    #region 知识点五 委托变量可以存储多个函数(多播委托)

    //作用
    //可以在我们处理逻辑的时候 先处理一些逻辑过后 再批量处理别人想做的事

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("委托");
            //专门用来装载 函数的 容器
            MyFun f = new MyFun(Fun);
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            f.Invoke();

            MyFun f2 = Fun;
            Console.WriteLine("1");
            Console.WriteLine("2");
            Console.WriteLine("3");
            Console.WriteLine("4");
            Console.WriteLine("5");
            f2();

            MyFun2 f3 = new MyFun2(Fun2);
            Console.WriteLine(f3(1));

            MyFun2 f4 = Fun2;
            Console.WriteLine(f4.Invoke(3));

            Test t = new Test();

            t.TestFun(Fun, Fun2);

            Console.WriteLine("*****************");
            //如何用委托存储多个函数
            MyFun ff = null;
            ff += Fun;
            ff += Fun3;
            ff();
            //移除容器中指定的函数
            ff -= Fun;
            //多减去 不会报错
            ff();
            //清空容器
            //ff = null;

            #region 知识点六 系统定义好的委托
            //使用系统自带委托 需要引用 using System;
            //无参无返回值的
            Action action = Fun;
            action += Fun3;
            action();

            //可以指定返回值的泛型委托
            Func<string> funcString = Fun4;
            Func<int> funInt = Fun5;

            //可以传n个参数的 系统提供了1到16个参数的委托
            Action<int, string> action2 = Fun6;
            action2(1,"123321");

            //可以传n个参数的 并且有返回值的 系统也提供了16个
            //参数在前 返回值在后 一个int参数 一个int返回值
            Func<int, int> fun2 = Fun2;
            #endregion
        }

        static void Fun()
        {
            Console.WriteLine("张三做了什么");
        }

        static void Fun3()
        {
            Console.WriteLine("李四做了什么");
        }

        static string Fun4()
        {
            return "111";
        }

        static int Fun5()
        {
            return 1;
        }

        static void Fun6(int i, string s)
        {
            Console.WriteLine("传入参数不返回");
        }

        static int Fun2(int value)
        {
            Console.WriteLine("Fun2运行返回value");
            return value;
        }
    }

    //总结
    //简单理解 委托 就是装载 传递函数的容器而已
    //可以用委托变量 来存储函数或者传递函数的
    //系统其实已经提供了很多委托给我们用
    //Action 没有返回值 参数个数0-16
    //Func 有返回值 参数个数0-16
}
