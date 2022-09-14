using System;

namespace Lesson8
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 括号强转
            //将高精度强制转换成低精度
            //语法 变量类型 变量名 = （变量类型）变量;
            //注意 精度问题 范围问题

            //相同大类的整形
            //有符号整形
            sbyte sb = 1;
            short s = 1;
            int i = 40000;
            long l = 1;
            //括号强转 可能会出现范围问题 造成的异常
            s = (short)i;
            Console.WriteLine(s);
            i = (int)l;
            sb = (sbyte)s;

            //无符号整形
            byte b = 1;
            uint ui = 1;
            b = (byte)ui;

            //浮点数之间
            float f = 1.1f;
            double d = 1.1123456789123456789f;
            f = (float)d;
            Console.WriteLine(f);//精度问题

            //无符号和有符号
            //一定要注意范围，不然会出现异常
            uint ui2=1;
            int i2 = 1;
            ui2 = (uint)i2;
            Console.WriteLine(ui2);

            //浮点和整形 精度问题 会直接抛弃小数点后数字
            i2 = (int)1.74f;
            Console.WriteLine(i2);

            //char和数值类型
            i2 = 'A';
            char c = (char)i2;
            Console.WriteLine(c);

            //bool和string 不能转
            bool bo = true;
            //int i3 = (bool)bo;
            string str = "1234";
            //int i4 = (string)str;

            #endregion

            #region 知识点二 Parse法
            //作用 把字符串类型转换为对应类型
            //语法 变量类型.Parse("字符串")
            //注意 字符串必须可以转换 否则报错

            //有符号
            string str2 = "123";
            int i4 = int.Parse(str);
            Console.WriteLine(i4);
            //字符串浮点数无法转成int
            //i4 = int.Parse("123.15");
            //Console.WriteLine(i4);

            //值的范围必须 式变量类型可以存储的值
            short s3 = short.Parse("12345");
            Console.WriteLine(s3);
            //另一种写法
            Console.WriteLine(sbyte.Parse("1"));
            //无符号
            //浮点数
            //特殊类型


            #endregion

            #region 知识点三 Convert法
            //作用 更准确将各个类型互相转换
            //语法 Convert.To目标类型(变量或者常量)

            //转字符串 合法合规同parse
            int a = Convert.ToInt32("12");
            Console.WriteLine(a);
            //精度比括号强转高一点 会四舍五入
            a = Convert.ToInt32(1.2345f);
            Console.WriteLine(a);
            //可以转换bool类型 0或1
            a = Convert.ToInt32(true);
            //可以转char类型
            a = Convert.ToInt32('A');

            //每个类型都存在对应 Convert方法
            //ToSByte ToInt16...
            float f5 = Convert.ToSingle("11.2");
            bool bo5 = Convert.ToBoolean("True");

            #endregion

            #region 知识点四 其他类型转string
            //作用：拼接打印
            //语法: 变量.toString();
            //所有类型都适用
            string str6 = 1.ToString();

            //字符串拼接时，自动调用tostring
            Console.WriteLine("12345" + 1 + true);

            #endregion
        }
    }
}
