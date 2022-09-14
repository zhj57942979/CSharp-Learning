using System;

namespace Lesson14_位运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("位运算符");
            //位运算符 主要用数值类型来进行计算
            //将数值转换为2进制 再进行位运算
            #region 知识点一 位与&
            //规则 连接两个数值进行位运算 将数值转为2进制
            //对位运算 有0则0
            int a = 1;//001
            int b = 5;//101
            int c = a & b;
            //  001
            //& 101
            //  001
            Console.WriteLine(c);
            #endregion

            #region 知识点二 位或 |
            int a1 = 1;//001
            int b1 = 3;//011
            int c1 = a1 + b1;
            //  001
            //| 011
            //  011
            Console.WriteLine(c1);
            #endregion

            #region 知识点三 异或 ^
            //对位运算 相同为0 不同为1
            a = 1;
            b = 5;
            //  001
            //^ 101
            //  100
            Console.WriteLine(a ^ b);
            #endregion

            #region 知识点四 位取反 ~
            //对位运算 0变1 1 变0
            a = 1;
            // 0000 0000 0000 0000 0000 0000 0000 0101
            // 1111 1111 1111 1111 1111 1111 1111 1010
            b = 5;
            Console.WriteLine(~a);

            #endregion

            #region 知识点五 左移<< 和右移>>
            //左移几位 右侧加几个0
            //右移几位 右侧去掉几个数
            a = 5;//101
            c = a << 5;
            //1位 1010
            //2位 10100
            //5位 1010 0000 = 160
            Console.WriteLine(c);

            c = a >> 2;
            // 101
            //1位 10
            //2位 1
            Console.WriteLine(c);
            #endregion
        }
    }
}
