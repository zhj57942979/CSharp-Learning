using System;

namespace Lesson5_值类型和引用类型
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("值类型和引用类型");
            #region 知识点一 变量类型的复习
            //无符号整形
            //byte ushort ulong uint
            //有符号整形
            //sbyte short int long
            //浮点数
            //float double decimal
            //特殊类型
            //bool char string

            //复杂数据类型
            //enum 枚举
            //数组（一维，二维，交错）

            //把以上学过的类型 分成 值类型和引用类型

            //值类型: 其他 结构体（未学习）
            //引用类型: string 数组 类(未学习)
            #endregion

            #region 知识点二 值类型和引用类型的区别
            //值类型
            int a=10;
            //引用类型
            int[] arr = new int[] { 1, 2, 3, 4 };

            //申明一个b让其等于a
            int b = a;
            //申明一个arr2让其等于arr
            int[] arr2 = arr;
            Console.WriteLine("a={0},b={1}", a, b);
            Console.WriteLine("arr[0]={0},arr2[0]={1}", arr[0], arr2[0]);

            b = 20;
            arr2[0] = 5;
            Console.WriteLine("修改后，a={0},b={1}", a, b);
            Console.WriteLine("修改后，arr[0]={0},arr2[0]={1}", arr[0], arr2[0]);
            //引用类型指向地址 arr和arr2指向堆空间中同一个数组

            //内存区域不同 存储方式不同
            //值类型存储在栈空间 -系统分配 自动回收 小而快
            //引用类型存储在堆空间 -手动申请和释放 大而慢

            //new 在堆空间申请了新空间
            arr2 = new int[] { 99, 3, 2, 1 };
            Console.WriteLine("修改后，arr[0]={0},arr2[0]={1}", arr[0], arr2[0]);
            #endregion
        }
    }
}
