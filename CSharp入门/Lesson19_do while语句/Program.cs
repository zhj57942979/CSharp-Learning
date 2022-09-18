using System;

namespace Lesson19_do_while语句
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("do...while循环");

            #region 知识点一 基本语法
            //while 先判断再执行
            //do while 先斩后奏 先至少执行一次再判断
            //do
            //{
            //    //do while 循环语句
            //} while (true);
            #endregion

            #region 知识点二 实际使用
            do
            {
                Console.WriteLine("do while循环语句 ");
            } while (false);

            int a = 1;
            do
            {
                Console.WriteLine(a);
                ++a;
            } while (a < 2);
            //do while 只用较少

            #endregion

            #region 知识点三 嵌套使用
            do
            {
                if (true)
                {
                    Console.WriteLine("111");
                }
                continue;
                //continue与while组合 执行一次
            } while (false);
            #endregion

        }
    }
}
