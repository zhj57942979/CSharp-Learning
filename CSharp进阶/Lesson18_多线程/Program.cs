using System;
using System.Threading;

namespace Lesson18_多线程
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("多线程");

            #region 知识点一 了解线程前先了解进程
            //进程是计算机中的程序关于某数据集合上的一次运行活动
            //进程之间相互独立 互不干扰
            //进程之间也可以相互访问 操作
            #endregion

            #region 知识点二 什么是线程
            //操作系统能够进行运算调度的最小单位
            //他被包含咋进程中 是进程中的实际运作单位
            //一条线程指进程中一个单一顺序的控制流 一个进程可以并发多个线程
            //目前程序都在主线程中

            //代码从上至下运行的管道
            #endregion

            #region 知识点三 什么是多线程
            //可以通过代码 开启新的线程
            //可以同时运行代码的多条管道 就是多线程
            #endregion

            #region 知识点四 语法相关
            //线程类 Thread
            //需要引用命名空间 using System.Threading
            //1 申明一个新的线程
            //  注意 线程执行的代码 需要封装到一个函数中
            Thread t = new Thread(NewThreadLogic);
            //2 启动线程
            #endregion

            #region 知识点五 线程之间共享数据

            #endregion

            #region 知识点六 多线程对于我们的意义

            #endregion
        }

        static void NewThreadLogic()
        {
            //新开线程 执行的代码逻辑 在该函数语句块中
        }
    }
}
