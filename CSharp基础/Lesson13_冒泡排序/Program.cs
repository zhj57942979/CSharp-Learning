using System;

namespace Lesson13_冒泡排序
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("冒泡排序");

            #region 知识点一 排序的基本概念
            //排序是计算机内经常进行的一种操作 其目的是将一组无序的记录调整为有序的记录序列
            //常用的排序例子
            // 8 7 1 5 3 2 4
            //把上面的一组无序序列 变为有序 升序或降序 序列的过程
            // 1 2 3 4 5 7 8 升序
            // 8 7 5 4 3 2 1 降序

            //在程序中 序列一般 存储在数组当中
            //所以 排序往往是对 数组进行排序
            int[] arr = new int[] { 8, 7, 1, 5, 4, 2, 6, 3, 9, };
            //把数组里面的内容变为有序的
            #endregion

            #region 知识点二 冒泡排序基本原理
            // 8 7 1 5 4 2 6 3 9
            //两两相邻
            //不停比较
            //不停交换
            //比较n轮
            #endregion

            #region 知识点三 代码实现
            //第一步 如何比较数组中两两相邻的数
            //从头开始
            //第n个数和第n+1个数 比较

            //第三步 如何换m轮
            //for(int m =0; m < arr.Length; m++)
            //{
            //    //进行一次循环 就需要比较一轮
            //    for(int n = 0; n< arr.Length-1; n++)
            //    {
            //        //如果 第n个数 比n+1个数 大 就交换位置
            //        if (arr[n] > arr[n + 1])
            //        {
            //            //第二步 交换位置
            //            //中间商不赚差价
            //            int temp = arr[n];
            //            arr[n] = arr[n + 1];
            //            arr[n + 1] = temp;
            //        }
            //    }
            //}


            //第四步 优化
            //1 确定位置的数字 不用再次比较 
            //  确定了一轮后 极值（最大或者最小）已经放到了对应的位置
            //  所以 每完成n轮 后面位置的数 就不再比较
            //  n < arr.Length - 1 - m
            //for (int m = 0; m < arr.Length; m++)
            //{
            //    //进行一次循环 就需要比较一轮
            //    for (int n = 0; n < arr.Length - 1 - m; n++)
            //    {
            //        //如果 第n个数 比n+1个数 大 就交换位置
            //        if (arr[n] > arr[n + 1])
            //        {
            //            //第二步 交换位置
            //            //中间商不赚差价
            //            int temp = arr[n];
            //            arr[n] = arr[n + 1];
            //            arr[n + 1] = temp;
            //        }
            //    }
            //}

            //2 特殊情况优化
            bool isSort = false;
            for (int m = 0; m < arr.Length; m++)
            {
                isSort = false;
                //进行一次循环 就需要比较一轮
                for (int n = 0; n < arr.Length - 1 - m; n++)
                {
                    //如果 第n个数 比n+1个数 大 就交换位置
                    if (arr[n] > arr[n + 1])
                    {
                        isSort = true;
                        //第二步 交换位置
                        //中间商不赚差价
                        int temp = arr[n];
                        arr[n] = arr[n + 1];
                        arr[n + 1] = temp;
                    }
                }
                if (isSort == false)
                {
                    break;
                }
            }
            //当一轮结束过后 如果没有一次交换 就不再比较

            //输出验证
            for (int i = 0; i < arr.Length; i++)
            {
                Console.WriteLine(arr[i]);
            }

            #endregion
        }
    }
}
