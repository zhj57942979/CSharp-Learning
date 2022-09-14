using System;

namespace Lesson12_条件运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("条件运算符");
            #region 知识点一 条件运算符
            //用于比较两个变量或常量
            //是否大于 >
            //小于<
            //等于== !=
            //大于等于>=
            //小于等于<=
            int a = 1;
            int b = 10;
            bool result = a < b;
            Console.WriteLine(result);

            #endregion
        }
    }
}
