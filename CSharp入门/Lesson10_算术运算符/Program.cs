using System;

namespace Lesson10_算术运算符
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("算术运算符");
            #region 知识点一 赋值符号

            //先看右侧 再看左侧 把右侧值给左侧变量

            #endregion

            #region 知识点二 算数运算符
            // + - * / %
            //默认整数是int 如果用来做除法运算 注意会丢失小数
            float f = 1 / 2f;
            //float 必须要打一个f
            #endregion

            #region 知识点三 算数运算符的优先级
            //乘除取余 优先级高于 加减
            #endregion

            #region 知识点四 算数运算符的 复合运算符
            //固定写法 运算符=
            //+= -= *= /= %=
            int i3 = 1;
            i3 += 2;
            Console.WriteLine(i3);
            #endregion

            #region 算术运算符的自增减
            int a2 = 1;
            a2 += 1;

            //自增运算符
            a2 = 1;
            a2++;//先用再加
            ++a2;//先加再用
            a2 = 1;
            Console.WriteLine(a2++);//1
            Console.WriteLine(++a2);//3

            //自减运算符

            #endregion
        }
    }
}
