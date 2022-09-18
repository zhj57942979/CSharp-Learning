using System;

namespace Lesson2_变量
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("变量");
            //知识点一 折叠代码
            //作用 逻辑更加清晰
            //他是有#region #endregion配对出现
            //折叠代码
            #region 知识点二 如何申明变量
            //变量
            //申明写法(类型+名字)
            //有符号的整形变量 正负数整数
            //sbyte/int/short/long

            //无符号整形变量
            //byte/uint/ushort/ulong
            //浮点数
            //float/double/decimal
            float f = 0.123456789f;
            decimal de = 0.1234556778m;
            Console.WriteLine(f);
            //特殊类型
            //bool(真假)/string(字符串)/char(单个字符)
            char c = 'a';
            int i = 1;
            Console.WriteLine("int变量i为:" + i);
            i = i + 5;
            Console.WriteLine("int变量i为:" + i);
            double j = 0.5;
            string k = "你好世界";
            #endregion
            #region 为什么那么多变量类型
            //不同类型内存空间不同
            //知识点四 同时申明多个相同类型变量
            int a1 = 1, b1 = 2, c1 = 3;
            Console.WriteLine(a1 + b1 + c1);
            #endregion
            #region 知识点五  变量初始化
            int a2;
            a2 = 1;
            #endregion
        }
    }
}
