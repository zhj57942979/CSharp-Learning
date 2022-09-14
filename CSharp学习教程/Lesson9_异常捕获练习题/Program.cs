using System;

namespace Lesson9_异常捕获练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("异常捕获练习题");
            #region 练习题一
            try
            {
                string str = Console.ReadLine();
                long l = long.Parse(str);
                Console.WriteLine("你输入的数字为：" + l);
            }
            catch {
                Console.WriteLine("您输入的数字有误,请输入正确数字。");

            }
            #endregion

            #region 练习题二
            try
            {
                Console.WriteLine("请输入用户名");
                string yourName = Console.ReadLine();              
            }
            catch {
                Console.WriteLine("输入格式有误");
            }

            try
            {
                Console.WriteLine("请输入语文成绩");
                string yuWenStr = Console.ReadLine();
                int yuWen = int.Parse(yuWenStr);
            }

            catch {
                Console.WriteLine("语文成绩输入不正确");
            }
            try
            {
                Console.WriteLine("请输入数学成绩");
                int shuXue = int.Parse(Console.ReadLine());
            }

            catch
            {
                Console.WriteLine("数学成绩输入不正确");
            }
            try
            {
                Console.WriteLine("请输入英语成绩");
                int yinYun = int.Parse(Console.ReadLine());
            }

            catch
            {
                Console.WriteLine("英语成绩输入不正确");
            }
            #endregion
        }
    }
}
