using System;

namespace Lesson6_转义字符
{
    class Program
    {
        static void Main(string[] args)
        {
            #region 知识点一 转义字符的使用
            //什么是转义字符
            //他是字符串的一部分 用来表示一些特殊含义的字符
            //比如在字符串中表现 单引号 引号 空行等
            //string str = "asld "fk";
            #region 固定写法
            //固定写法 \字符
            //常用转义字符
            //单引号
            string str = "\'哈哈哈\'";
            Console.WriteLine(str);
            //双引号
            str = "\"哈哈哈\"";
            Console.WriteLine(str);
            //换行
            str = "1234\n12345";
            Console.WriteLine(str);
            //斜杠 计算机文件路径需要 \ 符号
            str = "哈\\哈哈";
            Console.WriteLine(str);

            //不常用转义字符
            //制表符 （空一个tab键）输出空4格
            str = "哈\t哈哈";
            Console.WriteLine(str);
            //光标退格
            str = "123\b123";
            Console.WriteLine(str);
            //空字符
            str = "1234\01234";
            Console.WriteLine(str);
            //警报音
            str = "\a";
            Console.WriteLine(str);
            #endregion
            #endregion
            #region 知识点二 取消转义字符
            //加入符号@后，后面会取消字符串的转义字符
            string str2 = @"哈哈哈\哈哈哈";
            Console.WriteLine(str2);
            #endregion
        }
    }
}
