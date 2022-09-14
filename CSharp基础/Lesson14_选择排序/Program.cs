using System;

namespace Lesson14_选择排序
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("选择排序");

            #region 知识点一 选择排序基本原理
            // 8 7 1 5 4 2 6 3 9
            //新建中间商
            //依次比较
            //找出极值（最大或最小）
            //放入目标位置
            //比较n轮

            #endregion

            #region 知识点二 代码实现
            int[] arr = new int[] { 8, 7, 1, 5, 4, 2, 6, 3, 9, };

            //第一步 申明一个中间商 来记录索引
            //每一轮开始 默认第一个是极值
            //第五步 比较m轮
            for(int m = 0; m < arr.Length; m++) 
            {
                int index = 0;
                //第二步
                //依次比较
                //-m的目的 是排除上一轮 已经放好位置的数
                for (int n = 1; n < arr.Length-m; n++)
                {
                    //第三步
                    //找出极值 最大值
                    if (arr[index] < arr[n])
                    {
                        index = n;
                    }
                }
                //第四步 放入目标位置
                //length - 1 - 轮数
                //如果当前极值就是目标位置就不用交换
                if (index != arr.Length - 1 - m)
                {
                    int temp = arr[index];
                    arr[index] = arr[arr.Length - 1 - m];
                    arr[arr.Length - 1 - m] = temp;
                }

            }

            //输出验证
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i] + " ");
            }
            #endregion

            //总结
            //新建中间商
            //依次排序
            //一次比较
            //找出极值
            //放入目标位置
            //比较n轮

            //套路写法
            //两层循环
            //外层轮数
            //内层寻找
            //初始索引
            //记录极值
            //内存循环外交换
        }
    }
}
