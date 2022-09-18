using System;

namespace Lesson8_显式转换
{
    class Program
    {
        static void Main(string[] args)
        {
            int tang = '唐';
            Console.WriteLine(tang);
            int lao = '老';
            Console.WriteLine(lao);
            int shi = '狮';
            Console.WriteLine(shi);
            Console.WriteLine(tang+lao+shi);
            Console.WriteLine("唐老师的数字编号："+tang + lao + shi);
        }
    }
}
