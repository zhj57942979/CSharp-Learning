using System;

namespace Lesson10_练习题
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("练习题");
            //面积公式
            //周长公式
            float r = 5;
            const float PI = 3.1415926f;
            float mianJi = PI * r * r;
            float zhouChang = 2 * PI * r;
            Console.WriteLine("圆的周长是" + zhouChang);
            Console.WriteLine("圆的面积是" + mianJi);

        }
    }
}
