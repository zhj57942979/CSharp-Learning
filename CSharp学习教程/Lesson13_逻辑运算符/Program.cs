using System;

namespace Lesson13_逻辑运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("逻辑运算符");
            //与
            //符号 &&

            //或
            //符号 ||

            //非
            //符号 !

            //优先级
            // ! > && > ||

            //逻辑运算符的短路规则
            int i = 1;
            // ||有真则真
            //只要逻辑与 或者 逻辑或 左边满足条件
            bool result = i > 0 || ++i >= 1;
            Console.WriteLine(i); //i=1

            result = i < 0 && i++ > 1;
            Console.WriteLine(i);
        }
    }
}
