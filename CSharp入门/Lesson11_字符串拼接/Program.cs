using System;

namespace Lesson11_字符串拼接
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("字符串拼接");
            #region 知识点一 字符串拼接1
            //用+号来进行拼接
            string str = "123";
            str = str + "456";
            Console.WriteLine(str);
            Console.WriteLine(str+1);
            //1234561

            //复合运算符+=
            str = "123";
            str += "1" + 4 + true;
            Console.WriteLine(str);

            str += 1 + 2 + 3 + 4;//先=右后左是10
            Console.WriteLine(str);
            str += ""+1 + 2 + 3 + 4;
            Console.WriteLine(str);
            str += 1 + 2 +""+ 3 + 4;
            Console.WriteLine(str);

            str = "123";
            str = str + 1 + 2 + 3;

            //字符串拼接只有+号，没有++号或者-号。
            #endregion

            #region 知识点二 字符串拼接2
            //固定语法
            //string.Format("待拼接的内容",内容1,内容2,...)
            //拼接内容固定规则
            //想要被拼接的内容用占位符替代(数字) 数字；0到n,依次向后。
            string str2;
            str2 = string.Format("我是{0}，我今年{1}岁", "唐老师", 18);
            Console.WriteLine(str2);
            #endregion

            #region 知识点三 控制台打印拼接
            Console.WriteLine("我是{0}，我今年{1}岁了", "唐老师", 18);

            #endregion
        }
    }
}
