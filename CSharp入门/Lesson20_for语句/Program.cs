using System;

namespace Lesson20_for语句
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("for语句");
            #region 知识点一 语法
            //for (/*初始表达式*/;/*条件表达式*/;/*增量表达式*/ ) { 
            //    //循环代码逻辑
            //}

            for (int i = 0; i < 10; i++) {
                Console.WriteLine(i);
            }

            for (int i = 0, j = 0; i < 10 && j < 5; i++,j+=1) {
                Console.WriteLine("i" + i);
                Console.WriteLine("j" + j);
            }
            #endregion

            #region 知识点二 嵌套使用
            for(int i = 0; i < 5; i++)
            {
                for(int j = 0; j < 3; j++)
                {
                    Console.WriteLine(i + "_" + j);
                }
            }
            #endregion

            #region 知识点三 特殊写法
            //for循环可以写死循环
            //for(; ; )
            //{
            //    Console.WriteLine("死循环");
            //}

            int k = 0;
            for (; k < 10;)
            {
                ++k;
            }

            for (k = 0; ;) {
                if (k >= 5)
                {
                    break;
                }
            }
            //break也可以与for搭配
            #endregion

            #region 知识点四 对比while循环
            //for循环 一般用来得到准确范围的所有数
            #endregion
        }
    }
}
