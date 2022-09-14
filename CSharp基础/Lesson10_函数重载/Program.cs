using System;

namespace Lesson10_函数重载
{
    class Program
    {
        #region 知识点一 基本概念
        //在同一语句块（class或者struct）中
        //函数名相同
        //参数的数量不同
        //或者
        //参数的数量相同 但参数的类型或顺序不同

        //作用；
        //命名一组功能相似的函数 减少函数名的数量 避免空间的污染
        //提升程序可读性
        #endregion

        #region 知识点二 实例
        //注意
        //重载和返回值类型无关 只和参数类型 个数 顺序有关
        //调用时 程序会自己更具传入的参数类型判断使用哪一种重载

        static int CalcSum(int a, int b)
        {
            return a + b;
        }
        //参数数量不同
        static int CalcSum(int a, int b, int c)
        {
            return a + b + c;
        }
        //数量相同 类型不同
        static float CalcSum(float a, float b)
        {
            return a + b;
        }
        //数量相同 类型不同
        static float CalcSum(int a, float b)
        {
            return a + b;
        }
        //数量相同 顺序不同
        static float CalcSum(float f, int a)
        {
            return a + f;
        }
        //ref out
        static float CalcSum(ref float f, int a)
        {
            return a + f;
        }

        static float CalcSum(int a, int b, params int [] arr)
        {
            return 1;
            //不可用 需要完善
        }

        #endregion

        //总结
        //同一个语句块中 函数名相同 参数数量 类型 顺序不同的函数 就称为函数重载

        static void Main(string[] args)
        {
            Console.WriteLine("函数重载");

            Console.WriteLine(CalcSum(1, 2, 3));
            Console.WriteLine(CalcSum(1, 2));
            Console.WriteLine(CalcSum(1.1f, 2));



        }
    }
}
