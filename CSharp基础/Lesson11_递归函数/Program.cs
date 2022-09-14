using System;

namespace Lesson11_递归函数
{
    class Program
    {

        #region 知识点一 基本概念
        //递归函数就是让函数自己调用自己

        //一个正确的递归函数
        //必须要有结束调用的条件
        //用于条件判断的 这个条件 必须改变达到停止的目的

        #endregion

        #region 知识点二 实例
        //递归函数打印0到10
        static void Fun(int a)
        {
            //第四步 结束条件
            if(a>10)
            {
                return;
            }
            //第二步 完成要求
            Console.WriteLine(a);
            //第三步 完成一个递归的变化 作为条件判断
            ++a;
            //第一步 构造递归
            Fun(a);
        }



        #endregion

        #region 练习
        //阶乘
        static int JieCheng(int a)
        {
            if (a == 1)
            {
                return 1;
            }
            else return a * JieCheng(a - 1);

        }

        //二分之一的幂函数

        #endregion



        static void Main(string[] args)
        {
            Console.WriteLine("递归函数");
            Fun(0);
            Console.WriteLine(JieCheng(5));
        }
    }
}
