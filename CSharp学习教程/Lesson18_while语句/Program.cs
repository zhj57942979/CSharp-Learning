using System;

namespace Lesson18_while语句
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("while语句");
            #region 知识点一 作用
            //不断重复执行
            #endregion

            #region 知识点二 语法
            int a = 1;
            int b = 0;
            //注意变量在哪里声明很有用
            while (a<5) {
                Console.WriteLine("a等于"+a);
                ++a;
                while (b < 10) {
                    Console.WriteLine("b等于"+b);
                    ++b;
                }
            }

            //死循环
            //不停的执行循环中的代码到死为止
            #endregion

            #region 知识点四 流程控制关键词
            //作用 控制循环逻辑的关键词
            //break 跳出循环
            while (true) {
                Console.WriteLine("break之前的代码");
                break;
                Console.WriteLine("break之后的代码");
            }
            Console.WriteLine("循环外的代码");

            int i = 0;
            while (true) {
                ++i;
                Console.WriteLine(i);
                if (i == 10)
                {
                    break;
                }
            }
            Console.WriteLine(i);
            //continue 回到循环开始 继续执行
            int index = 0;
            while (index<20) {
                ++index;
                if (index % 2 == 0)
                {
                    continue;
                }
                Console.WriteLine(index);
            }
            //break 和 continue主要配合循环使用
            //break在switch中和while循环中异曲同工之妙

            #endregion
        }
    }
}
