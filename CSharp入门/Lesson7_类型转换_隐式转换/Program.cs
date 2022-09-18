using System;

namespace Lesson7_类型转换_隐式转换
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("类型转换_隐式转换");
            //什么是类型转换
            //类型转换 就是在不同变量类型之间互相转换
            //隐式转换基本规则=不同类型之间自动转换
            //大范围装小范围
            #region 知识点一 相同大类型之间的转换

            //有符号 long->int->short->sbyte
            long l = 1;
            int i = 1;
            short s = 1;
            sbyte sb = 1;
            //隐式转换 int隐式转换成了long
            l = i;
            //不能用小范围的类型去装大范围的类型
            //i = l;
            l = i;
            l = s;
            l = sb;
            i = s;
            s = sb;

            //无符号 ulong->uint->ushort->byte

            //浮点数 demical double->float
            decimal de = 1.1m;
            double d = 1.1;
            float f = 1.1f;
            //decimal这个类型没有办法用隐式转换的形式去存贮double和float
            //de = d;
            d = f;

            //特殊类型 bool char string
            //不存在隐式转换
            #endregion

            #region 知识点二不同类型之间的转换
            //无符号装有符号
            //无符号 不能装负数
            byte b2 = 1;
            ushort us2 = 1;
            uint ui2 = 1;
            ulong ul2 = 1;
            //有符号
            sbyte sb2 = 1;
            short s2 = 1;
            int i2 = 1;
            long l2 = 1;

            //无符号装有符号 不能进行隐式转换 前提：范围涵盖
            //有符号转无符号
            //i2 = ui2; ui2正数范围超了
            i2 = b2;

            //浮点数装整数 浮点数可以装载任何整数的
            float f2 = 1.1f;
            decimal de2 = 1.1m;
            f2 = l2;
            f2 = ul2;
            f2 = s2;
            f2 = sb2;
            //double->float->整形
            //decimal可以装整形
            de2 = l2;
            f2 = 1000000000000000000;
            Console.WriteLine(f2); //会通过科学计数法表示

            //整数不能存储浮点数

            //特殊类型和其他类型
            //bool无法相互隐式转换
            bool bo2 = true;
            char c2 = 'A';
            string str2 = "1231";
            //char char没有办法隐式存储其他类型变量
            //c2 = i2;
            //c2 = f2;
            //c2 = ui2;
            //chat类型可以隐式转换成整形和浮点型 ASCII码对应关系
            i2 = c2;
            Console.WriteLine(i2);
            f2 = c2;
            Console.WriteLine(f2);
            ui2 = c2;
            Console.WriteLine(ui2);
            //stfing无法和其他类型互相转换
            #endregion

            //总结
            //高精度大范围装低精度 小范围
            // double-float-整数-char
            //decimal-整数-chat
            //string和bool不参与
        }
    }
}
