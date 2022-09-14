using System;

namespace Lesson9_异常捕获
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("异常捕获");
            #region 知识点一 异常捕获的作用

            string str = Console.ReadLine();
            //parse转字符串为数值类型时必须合法合规
            int i = int.Parse(str);

            //通过对异常捕获的学习 避免代码报错时候 程序卡死

            #endregion

            #region 知识点二 基本语法
            try
            {
                //把希望进行异常捕获的代码放到try中
                //如果报错了，会执行catch中代码来捕获异常

            }
            catch (Exception e)
            {
                //具体的报错跟踪(Exception e)

            }
            //可选部分
            finally 
            {
                //不管有没有出错都会执行其中代码

            }



            #endregion

            #region 实践
            try
            {
                string str2 = Console.ReadLine();
                int i2 = int.Parse(str);
                Console.WriteLine(i);
            }
            catch (Exception e)
            {
                Console.WriteLine("请输入合法数字");

            }
            finally 
            {
                Console.WriteLine("执行完毕"); 
            }
            #endregion
        }
    }
}
