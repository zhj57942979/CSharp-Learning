using System;
using System.Threading;

namespace Lesson18_多线程
{
    class Program
    {
        static bool isRunning = true;

        static object obj = new object();

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
            //  新线程 将要执行的代码逻辑 被封装到了一个函数语句块中
            Thread t = new Thread(NewThreadLogic);

            //2 启动线程
            t.Start();

            //3 设置为后台线程
            //当前台线程都结束了的时候 整个程序就结束了 即使还有后台线程正在运行
            //后台线程不会防止应用程序的进程被终止掉
            //如果不设置为后台线程 可能导致进程无法正常关闭
            t.IsBackground = true;

            //4 关闭释放一个线程
            //如果开启的线程中不是死循环 是能够结束的逻辑 那么 不用刻意去关闭它
            //如果是死循环 想要终止这个线程 有两种方式
            //4.1 死循环中bool标识
            //Console.ReadKey();

            //isRunning = false;

            //Console.ReadKey();
            //4.2 通过线程提供的方法(注意在.Net core版本中无法终止 会报错)
            //终止线程
            //try
            //{
            //    t.Abort();
            //    t = null;
            //}
            //catch
            //{

            //}

            //5 线程休眠
            //让线程休眠多少毫秒 1s = 1000ms
            //在哪个线程里执行 就休眠哪个线程
            //Thread.Sleep(1000);
            #endregion

            #region 知识点五 线程之间共享数据
            //多个线程使用的内存是共享的 都属于该应用程序（进程）
            //所以要注意 当多线程 同时操作同一片内存区域时可能会出问题
            //可以通过加锁的形式避免问题

            //lock
            //当我们在多个线程想要访问同样的东西 进行逻辑处理时
            //为了避免不必要的逻辑差错
            //lock(引用类型对象)

            while (true)
            {
                lock (obj)
                {
                    Console.SetCursorPosition(0, 0);
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write("•");
                }
            }
            #endregion

            #region 知识点六 多线程对于我们的意义
            //可以用多线程专门处理一些复杂耗时的逻辑
            //比如 寻路 网络通信等等
            #endregion
        }

        static void NewThreadLogic()
        {
            //新开线程 执行的代码逻辑 在该函数语句块中

            while (isRunning)
            {
                //Thread.Sleep(1000);
                //Console.WriteLine("这是一个新开线程");
                Console.SetCursorPosition(10, 5);
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("‣");
            }

        }
    }
}
