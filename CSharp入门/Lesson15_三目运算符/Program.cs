using System;

namespace Lesson15_三目运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("三目运算符");
            #region 知识点一 基本语法
            //套路 3个空位 2个符号！！d
            //语法 空位   ? 空位       : 空位
            //信息 bool类型 ? bool类型为真返回的内容 : bool类型为假的返回内容
            //三目运算符 会有返回值，后面两个返回值类型必须一致，并且必须使用!

            #endregion

            #region 具体使用
            //简单逻辑类型
            string str = true ? "条件为真" : "条件为假";
            Console.WriteLine(str);

            int a = 5;
            str = a < 1 ? "a大于1" : "a不满足条件";
            Console.WriteLine(str);

            int i = a > 1 ? 123 : 234;

            #endregion
        }
    }
}
