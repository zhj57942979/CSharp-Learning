using System;

namespace Lesson10_封装_运算符重载
{
    #region 知识点一 基本概念
    //概念
    //让自定义类和结构体
    //能够使用运算符

    //使用关键字
    //operator

    //特点
    //1 一定是一个公共的静态方法
    //2 返回值写在operator前
    //3 逻辑处理自定义

    //作用
    //让自定义类和结构体 对象可以进行运算
    //注意
    //1 条件运算符需要成对实现
    //2 一个符号可以多个重载
    //3 不能使用ref和out
    #endregion

    #region 知识点二 基本语法
    //public static 返回类型 operator 运算符(参数列表)
    #endregion

    #region 知识点三 实例
    class Point
    {
        //二维坐标
        public int x;
        public int y;

        public static Point operator +(Point p1, Point p2)
        {
            Point p = new Point();
            p.x = p1.x + p2.x;
            p.y = p1.y + p2.y;
            return p;
        }
        //重载
        public static Point operator +(Point p1, int value)
        {
            Point p = new Point();
            p.x = p1.x + value;
            p.y = p1.y + value;
            return p;
        }
        //交换顺序重载 只能使用一个或者两个参数
        public static Point operator +(int value, Point p1)
        {
            Point p = new Point();
            p.x = p1.x + value;
            p.y = p1.y + value;
            return p;
        }

        #region 可重载的运算符
        #region 算数运算符
        //注意 符号需要一个参数还是两个参数
        public static Point operator -(Point p1, Point p2)
        {
            return null;
        }
        public static Point operator *(Point p1, Point p2)
        {
            return null;
        }
        public static Point operator /(Point p1, Point p2)
        {
            return null;
        }
        public static Point operator %(Point p1, Point p2)
        {
            return null;
        }
        public static Point operator ++(Point p1)
        {
            //自增
            return null;
        }
        public static Point operator --(Point p1)
        {
            //自减
            return null;
        }
        #endregion

        #region 逻辑运算符
        //只允许逻辑非 ！
        public static bool operator !(Point p1)
        {
            return false;
        }
        #endregion

        #region 位运算符 
        //注意 符号需要两个参数还是一个参数
        public static Point operator |(Point p1, Point p2)
        {
            return null;
        }
        public static Point operator &(Point p1, Point p2)
        {
            return null;
        }
        public static Point operator ^(Point p1, Point p2)
        {
            return null;
        }
        public static Point operator ~(Point p1)
        {
            return null;
        }
        public static Point operator <<(Point p1,int num)
        {
            return null;
        }
        public static Point operator >>(Point p1, int num)
        {
            return null;
        }
        #endregion

        #region 条件运算符
        //1 返回值一般是bool值 也可以是其他的
        //2 相关符号必须配对实现 有写大于符号就要重载小于符号
        // > < >= <= == !=
        #endregion

        #endregion

        #region 不可重载的运算符
        //逻辑与 && 逻辑或 ||
        //索引符 []
        //强转运算符 ()
        //特殊运算符
        //点 . 三目运算符 ?: 赋值符号=

        #endregion
    }


    #endregion

    #region 知识点五 可重载和不可重载的运算符

    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("运算符重载");

            #region 知识点四 使用

            Point p = new Point();
            p.x = 1;
            p.y = 2;
            Point p2 = new Point();
            p2.x = 2;
            p2.y = 3;

            Point p3 = p + p2;

            Point p4 = p3 + 2;

            Point p5 = 2 + p4;


            #endregion
        }
    }

    //注意
    //参数的数量
    //条件运算符的配对实现
    //一个符号可以多个重载
    //不能用ref和out
}
