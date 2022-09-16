using System;

namespace Lesson22_面向对象相关_万物之父中的方法
{
    class Test
    {
        public int i = 1;
        public Test2 t2 = new Test2();

        public Test Clone()
        {
            return MemberwiseClone() as Test;
        }

        public override bool Equals(object obj)
        {
            return base.Equals(obj);
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }
        
    }

    class Test2
    {
        public int i = 2;

    }
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("万物之父中的方法");

            #region 知识回顾
            //万物之父 object
            //所有类型的基类 是一个引用类型
            //可以利用里氏替换原则装载一切对象
            //存在装箱拆箱
            #endregion

            #region 知识点一 object中的静态方法
            //静态方法 Eauqals 判断两个对象是否相等
            //最终的判断权 交给左侧对象的Equals方法
            //不管值类型引用类型都会按照左侧对象Equals方法的规则来进行比较----指虚方法
            //Console.WriteLine(object.Equals(1, 1));
            //Test t = new Test();
            //Test t2 = new Test();
            //不同引用类型 false
            //Console.WriteLine(object.Equals(t, t2));
            //静态方法ReferenceEquals
            //比较两个对象是否是相同的引用 主要是用来比较引用类型的对象
            //值类型对象返回值始终是false
            //Console.WriteLine(object.ReferenceEquals(t,t2));
            #endregion

            #region 知识点二 object中的成员方法
            //普通方法GetType
            //该方法在反射相关知识点中是非常重要的方法 之后我们会具体的讲解这里的Type类型，
            //该方法的主要作用就是获取对象允许的类型Type
            //通过Type结合反射相关知识点可以做很多关于对象的操作
            Test t = new Test();
            Type type = t.GetType();

            //普通方法MemberwiseClone
            //该方法用于获取对象的浅拷贝对象 口语化的意思就是会返回一个新的对象
            //但是新对象中的引用变量会和老对象中一致。
            Test t2 = t.Clone();
            Console.WriteLine("克隆对象后");
            Console.WriteLine("t.i = " + t.i);
            Console.WriteLine("t.t2.i = " + t.t2.i);
            Console.WriteLine("t2.i = " + t2.i);
            Console.WriteLine("t2.t2.i = " + t2.t2.i);

            t2.i = 20;
            t2.t2.i = 21;
            Console.WriteLine("改变克隆体信息后");
            Console.WriteLine("t.i = " + t.i);
            Console.WriteLine("t.t2.i = " + t.t2.i);
            Console.WriteLine("t2.i = " + t2.i);
            Console.WriteLine("t2.t2.i = " + t2.t2.i);
            #endregion

            #region 知识点三 object中的虚方法
            //虚方法Equals
            //默认实现还是比较两者是否为同一个引用 即相当于ReferenceEquals
            //但是微软在所有值类型的基类System.ValueType中重写了该方法 用来比较值相等。
            //我们也可以重写该方法 定义自己的比较相等的规则

            //虚方法GetHashCode
            //该方法是获取对象的哈希码
            //（一种通过算法算出的 表示对象的唯一编码 不同对象哈希码有可能一样 具体值根据）
            //我们可以通过重写该函数来自己定义对象的哈希码算法 正常情况下 我们使用的极少，基本不用。

            //虚方法oString
            //该方法用于返回当前对象代表的字符串 我们可以重写它定义我们自己的对象转字符串规则，
            //该方法非常常用 当我们调用打印方法时 默认使用的就是对象的ToString方法后打印出来的内容。

            Random r = new Random();
            Console.WriteLine(t);
            #endregion
        }
    }
}
