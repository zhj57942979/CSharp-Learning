using System;

namespace Lesson3_二维数组
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("二维数组");
            #region 知识点一 基本概念
            //二位数组通过两个下标来确定元素数组
            //行和列
            #endregion

            #region 知识点二 二位数组的申明
            //变量类型[,] 二维数组变量名;
            int[,] arr;//之后进行初始化

            //变量类型[,] 二位数组变量名 = new 变量行{行,列};
            int[,] arr2 = new int[3,3];

            //变量类型[,] 二位数组变量名 = new 变量行[行,列]{,}{,};
            int[,] arr3 = new int[3, 3] { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };

            //变量类型[,] 二位数组变量名 = new 变量行[行,列]{,}{,};
            int[,] arr4 = new int[,] { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };


            #endregion

            #region 知识点三 二位数组的使用
            //int[,] arr4 = new int[,] { { 1, 2, 3 }, { 1, 2, 3 }, { 1, 2, 3 } };
            //二维数组的长度
            //分别获取行和列的长度
            Console.WriteLine(arr4.GetLength(0));
            Console.WriteLine(arr4.GetLength(1));

            //获取 二维数组中的元素
            //注意不要越界
            Console.WriteLine(arr4[0, 1]);
            Console.WriteLine(arr4[2, 2]);

            //修改二维数组的元素
            arr4[0, 0] = 999;
            Console.WriteLine(arr4[0, 0]);

            //遍历二维数组
            for (int i = 0; i < arr4.GetLength(0); i++) {
                for (int j = 0; j < arr4.GetLength(1); j++) {
                    Console.WriteLine(arr4[i, j]);
                }
            }

            //增加数组的元素
            //数组申明初始化后 不能增加删除了
            Console.WriteLine("**************");
            int[,] array2 = new int[4, 3];
            for (int i = 0; i < arr4.GetLength(0); i++)
            {
                for (int j = 0; j < arr4.GetLength(1); j++)
                {
                    array2[i, j] = arr4[i, j];
                }
            }
            arr4 = array2;

            //删除数组的元素

            //查找数组的元素
            //遍历+条件判断

            #endregion

            //游戏中一般用来存储矩阵 在控制台小游戏中可以用二维数组来表示地图格子
        }
    }
}
