using System;

namespace Lesson6_特殊引用类型string
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("特殊引用类型string");

            #region 知识点一 复习值和引用类型
            //值类型-他变我不变-存储在栈内存中

            //引用类型-他变我也变-存储在堆内存中
            //string 数组
            #endregion

            #region string的他变我不变
            //string非常特殊  他具备 值类型的特征 他变我不变
            //每次string赋值 都会在堆里自动开新空间
            //string str = "123";
            //string str2 = str;
            //str2 = "345";
            //Console.WriteLine(str);
            #endregion

            //通过断点调试 在监视窗口查看 内存信息
            string str = "123";
            string str2 = str;
            str2 = "345";
            Console.WriteLine(str);
        }
    }
}
