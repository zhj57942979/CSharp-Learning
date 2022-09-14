using System;

namespace Lesson2_数组
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("数组");
            #region 知识点一 基本概念
            //数组是存储一组相同类型数据的集合
            //数组分为一维，多维，交错数组
            //一般情况，一维数组简称数组
            #endregion

            #region 知识点二 申明
            //变量类型[] 数组名
            //只是申明一个数组，并没有开房
            //学过的变量类型都可以
            int[] arr1;
            arr1 = new int[2];

            //变量类型[] 数组名= new 变量类型[数组长度]
            int[] arr2 = new int[5];//相当于开了5个房间，默认为0

            //变量类型[] 数组名= new 变量类型[数组长度]{内容1.内容2.内容3...}
            int[] arr3 = new int[5] { 1, 2, 3, 4, 5 };//后面内容必须填满

            //变量类型[] 数组名= new 变量类型[]{内容1.内容2.内容3...}
            int[] arr4 = new int[] { 1, 2, 3, 4 };//通过大括号的内容来规定数组长度

            //变量类型[] 数组名={内容1.内容2.内容3...}
            int[] arr5 = { 1, 2, 3, 4, 5, 6 };//后面的数组必须和变量类型相同


            #endregion

            #region 知识点三 数组的使用
            int[] array = { 1, 2, 3, 4, 5 };
            //数组长度
            Console.WriteLine(array.Length);
            //获取数组中的元素
            //数组中的下标和索引，他们从0开始
            //!!!!!注意下标不能越界 范围0到length-1
            Console.WriteLine(array[0]);
            Console.WriteLine(array[2]);
            Console.WriteLine(array[4]);
            //修改数组中的元素 注意元素类型
            array[0] = 99;
            Console.WriteLine(array[0]);
            //遍历数组
            Console.WriteLine("********");
            for (int i = 0; i < array.Length; i++) {
                Console.WriteLine(array[i]);
            }
            //增加数组的元素
            //数据初始化后不饿能直接添加元素
            Console.WriteLine("********");
            int[] array2 = new int[6];
            //将array搬到array2
            for (int i = 0; i < array.Length; i++)
            {
                array2[i] = array[i];
                Console.WriteLine(array2[i]);
            }
            array = array2;
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            array[5] = 999;
            //删除数组的元素
            //初始化之后是不能直接删除元素的
            //搬家的原理删除

            //查找数组中的元素
            int a = 3;
            for (int i = 0; i < array.Length; i++) {
                if (array[i] == a) {
                    Console.WriteLine("与a相等的数组位置是：" + i);
                    break;
                }
            }
            #endregion

        }
    }
}
