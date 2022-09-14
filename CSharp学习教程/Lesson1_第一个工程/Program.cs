//引用工具包
using System;

namespace Lesson1_第一个工程
{
    class Program
    {
        //面向对象代码相关
        static void Main(string[] args)
        {
            Console.WriteLine("你好世界!");
            Console.WriteLine("唐老师");
            //Write不会换行
            Console.Write("请玩家输入用户名、年龄、班级");
            //等待玩家输入
            Console.ReadLine();
            Console.WriteLine("玩家输入完毕");

            //检测玩家是否按键，只要按了键盘上任意键 就认为输入结束
            Console.Write("请玩家输入喜欢的运动");
            //
            Console.ReadLine();
            Console.WriteLine("哈哈，好巧，我也喜欢这个运动");
            Console.WriteLine("**********");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("*        *");
            Console.WriteLine("**********");
        }
    }
}
