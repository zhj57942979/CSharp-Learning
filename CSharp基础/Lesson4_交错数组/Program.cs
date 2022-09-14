using System;

namespace Lesson4_交错数组
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("交错数组");
            #region 知识点一 基本概念
            //交错数组 是数组的数组 每个维度的数量可以不同

            //注意 二维数组每行列数相同 交错数组每行列数不同
            #endregion

            #region 知识点二 数组的申明
            //变量类型[][] 交错数组名;
            int[][] arr1;

            //变量类型[][] 交错数组名 = new 变量类型[行数][];
            int[][] arr2 = new int[3][];

            //变量类型[][] 交错数组名 = new 变量类型[行数][]{一维数组1,一维数组2,...};
            int[][] arr3 = new int[3][]
            {
                new int[]{1,2,3 },
                new int[]{1,2, },
                new int[]{1 },
            };

            //变量类型[][] 交错数组名 = new 变量类型[][]{一维数组1,一维数组2,...};
            int[][] arr4 = new int[][]
            {
                new int[]{1,2,3 },
                new int[]{1,2, },
                new int[]{1 },
                };
            //变量类型[][] 交错数组名 = {一维数组1,一维数组2,...};
            int[][] arr5 = {
                new int[]{1,2,3 },
                new int[]{1,2, },
                new int[]{1 },
            };
            #endregion

            #region 数组的使用
            int[][] array = { new int[] { 1, 2, 3 }, new int []{4,5 } };
            //数组的长度
            //行
            Console.WriteLine(array.GetLength(0));
            //得到某一行的列数
            Console.WriteLine(array[0].Length);

            //获取交错数组中的元素
            Console.WriteLine(array[0][1]);

            //修改交错数组中的元素
            array[0][1] = 88;
            Console.WriteLine(array[0][1]);

            //遍历交错数组
            Console.WriteLine("**********");
            for (int i = 0; i < array.GetLength(0); i++) {
                for (int j = 0; j < array[i].Length; j++) {
                    Console.WriteLine(array[i][j]);
                }
            }

            //增加查找
            #endregion

            //所有的变量类型都可以申明为交错数组
        }
    }
}
