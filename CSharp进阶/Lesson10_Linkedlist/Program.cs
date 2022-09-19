using System;
using System.Collections.Generic;

namespace Lesson10_Linkedlist
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Linkedlist");

            #region 知识点一 LinkedList
            //LinkedList是一个C#为我们封装好的类
            //他的本质是一个可变类型的泛型双向链表
            #endregion

            #region 知识点二 申明
            //需要引用命名空间
            //using System.Collections.Generic
            LinkedList<int> linkedList = new LinkedList<int>();
            LinkedList<string> linkedList2 = new LinkedList<string>();
            //链表对象 需要掌握两个类
            //一个是链表本身 一个是链表节点类   LinkedListNode
            #endregion

            #region 知识点三 增删查改

            #region 增
            //1 在链表尾部添加元素
            linkedList.AddLast(10);
            //2 在链表头部添加元素
            linkedList.AddFirst(20);
            //3 在某一个节点之后添加一个节点
            //  要指定节点 先得得到一个节点
            LinkedListNode<int> n = linkedList.Find(20);
            linkedList.AddAfter(n, 15);
            //4 某一个节点之前添加一个节点
            linkedList.AddBefore(n, 11);
            #endregion

            #region 删
            //1 移除头节点
            linkedList.RemoveFirst();
            //2 移除尾节点
            linkedList.RemoveLast();
            //3 移除指定节点
            //  无法通过位置直接移除
            linkedList.Remove(20);
            //4 清空
            linkedList.Clear();

            linkedList.AddLast(1);
            linkedList.AddLast(2);
            linkedList.AddLast(3);
            linkedList.AddLast(4);
            #endregion

            #region 查
            //1 头节点
            LinkedListNode<int> first = linkedList.First;
            //2 尾节点
            LinkedListNode<int> last = linkedList.Last;
            //3 找到指定值得节点
            //  无法直接通过下标获取中间元素
            //  只有遍历查找指定位置元素
            LinkedListNode<int> node = linkedList.Find(3);
            Console.WriteLine(node.Value);
            //4 判断是否存在
            if (linkedList.Contains(1))
            {
                Console.WriteLine("链表中存在1");
            }
            #endregion

            #region 改
            //要先得再改 得到节点 再改变其中的值
            Console.WriteLine(linkedList.First.Value);
            linkedList.First.Value = 10;
            Console.WriteLine(linkedList.First.Value);
            #endregion

            #endregion

            #region 知识点四 遍历
            //1 foreach遍历
            foreach (int item in linkedList)
            {
                Console.WriteLine(item);
            }

            //2 通过节点遍历
            //  从头到尾
            Console.WriteLine("****************");
            LinkedListNode<int> nowNode = linkedList.First;
            while (nowNode != null)
            {
                Console.WriteLine(nowNode.Value);
                nowNode = nowNode.Next;
            }
            //  从尾到头
            Console.WriteLine("****************");
            nowNode = linkedList.Last;
            while (nowNode != null)
            {
                Console.WriteLine(nowNode.Value);
                nowNode = nowNode.Previous;
            }
            #endregion

        }
    }
}
