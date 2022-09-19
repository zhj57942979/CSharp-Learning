using System;
using System.Collections.Generic;

namespace Lesson11_泛型栈和队列
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("泛型栈和队列");

            #region 知识点一 回顾数据容器

            #region 变量
            //无符号
            //byte ushort uint ulong
            //有符号
            //sbyte short int long
            //浮点数
            //float double decimal
            //特殊
            //char bool string
            #endregion

            #region 复杂数据容器
            //枚举 enum
            //结构体 struct
            //数组（一维 二维 交错） [] [,] [][]
            //类
            #endregion

            #region 数据集合
            //using System.Collections;

            //ArrayList object数据列表
            //Stack 栈 先进后出
            //Queue 队列 先进先出
            //Hashtable 哈希表 键值对
            #endregion

            #region 泛型数据集合
            //using  System.Collections.Generic;

            //List 列表 泛型队列
            //Dictionary 字典 泛型哈希表
            //LinkedList 双向链表
            //Stack 泛型栈
            //Queue 泛型队列
            #endregion

            #endregion

            #region 知识点二 泛型栈和队列
            //命名空间 using  System.Collections.Generic;
            //使用上 和之前的Stack 和 Queue 一模一样
            Stack<int> stack = new Stack<int>();
            Queue<object> queue = new Queue<object>();

            //增删查改 F12 和之前数据集合中一样
            #endregion

        }
    }
}
