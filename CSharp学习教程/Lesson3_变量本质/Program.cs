using System;

namespace Lesson3_变量本质
{
    class Program
    {
        static void Main(string[] args)
        {
            //变量

            //有符号的整形变量 正负数整数
            //sbyte/int/short/long

            //无符号整形变量
            //byte/uint/ushort/ulong

            //浮点数
            //float/double/decimal

            //特殊类型
            //bool(真假)/string(字符串)/char(单个字符)

            #region 知识点一 变量存储空间
            //通过sizeof方法获取所占空间
            int sbytesize = sizeof(sbyte);
            Console.WriteLine("sbyte所占字节数" + sbytesize);
            int intsize = sizeof(int);
            Console.WriteLine("sbyte所占字节数" + intsize);
            //其他省略
            #endregion
            #region 知识点二 变量的本质
            //本质就是2进制的0和1
            //1 byte = 8bit
            #endregion
            #region 知识点三 内存空间默写
            //sbyte 1 8, int 4 32, short 2 16, long 8 64.
            //byte 1 4, uint 4 32, ushort 2 16, ulong 8 64.
            //float 4 32, double 8 64, decimal 16 128.
            //char 2 16, bool 1 8, string 不定.
            //11000111 = 1+2+4+64+128 = 199
            #endregion
        }
    }
}
