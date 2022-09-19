using System;

namespace Lesson9_顺序存储和链式存储
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("顺序存储和链式存储");

            #region 知识点一 数据结构
            //数据结构
            //数据结构是计算机存储 组织数据的方式(规则)
            //数据结构是指相互之间存在一种或多种特定关系的数据元素的集合
            //比如自定义的一个 类 也可以称为一种数据结构 自己定义的数据组合规则

            //不要把数据结构想的太复杂
            //简单点理解 就是人定义的 存储数据 和 表示数据之间关系 的规则而已

            //常用的数据结构 
            //数组 栈 队列 链表 树 图 堆 散列表
            #endregion

            #region 知识点二 线性表
            //线性表是一种数据结构 是由n个具有相同特效的数据元素的有限序列
            //比如数组 ArrayList Stack Queue 链表等等
            #endregion

            //顺序存储和链式存储 是数据结构中两种 存储结构

            #region 知识点三 顺序存储
            //数组 Stack Queue List ArrayList 顺序存储
            //只是数组 Stack Queue的 组织规则不同而已
            //顺序存储
            //用一组地址连续的存储单元 依次存储线性表的各个数据元素
            #endregion

            #region 知识点四 链式存储
            //单向链表 双向链表 循环链表 链式存储
            //链式存储（链接存储）:
            //用一组任意的存储单元存储线性表中的各个数据元素
            #endregion

            //太麻烦了---封装一下再使用
            //LinkedNode<int> node = new LinkedNode<int>(1);
            //LinkedNode<int> node2 = new LinkedNode<int>(2);
            //node.nextNode = node2;
            //node2.nextNode = new LinkedNode<int>(3);
            //node2.nextNode.nextNode = new LinkedNode<int>(4);

            LinkedList<int> link = new LinkedList<int>();
            link.Add(1);
            link.Add(2);
            link.Add(3);
            link.Add(4);
            LinkedNode<int> node = link.head;
            while(node != null)
            {
                Console.WriteLine(node.value);
                node = node.nextNode;
            }
            link.Remove(2);
            node = link.head;
            while (node != null)
            {
                Console.WriteLine(node.value);
                node = node.nextNode;
            }

            link.Remove(1);
            node = link.head;
            while (node != null)
            {
                Console.WriteLine(node.value);
                node = node.nextNode;
            }
            link.Add(99);
            node = link.head;
            while (node != null)
            {
                Console.WriteLine(node.value);
                node = node.nextNode;
            }
        }
    }

    #region 知识点五 自己实现一个最简单的单向链表
    /// <summary>
    /// 单向链表节点
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class LinkedNode<T>
    {
        public T value;
        //这个存储下一个元素是谁 相当于钩子
        public LinkedNode<T> nextNode;

        public LinkedNode(T value)
        {
            this.value = value;
        }
    }

    /// <summary>
    /// 单向链表类 去管理节点 管理添加等等
    /// </summary>
    /// <typeparam name="T"></typeparam>
    class LinkedList<T>
    {
        public LinkedNode<T> head;
        public LinkedNode<T> last;

        public void Add(T value)
        {
            //添加节点 必然是new一个新的节点
            LinkedNode<T> node = new LinkedNode<T>(value);
            if(head == null)
            {
                //引用类型 都指向同一个地址
                head = node;
                last = node;
            }
            else
            {
                last.nextNode = node;
                last = node;
            }
        }

        public void Remove(T value)
        {
            if (head == null)
            {
                return;
            }
            if (head.value.Equals(value))
            {
                head = head.nextNode;
                //如果头节点  被移除 发现头节点变空
                //证明只要一个节点 那尾节点也要清空
                if (head == null)
                {
                    last = null;
                }
                return;
            }
            LinkedNode<T> node = head;
            while (node.nextNode != null)
            {
                if(node.nextNode.value.Equals(value))
                {
                    //让当前找到的扎尔格元素的 上一个节点
                    //指向 自己的下一个节点
                    node.nextNode = node.nextNode.nextNode;
                    break;
                }
                if (node.nextNode.value.Equals(last.value))
                {
                    last = node;
                }
                node = node.nextNode;
            }
        }
    }
    #endregion

    #region 知识点六 顺序存储和链式存储的优缺点
    //从增删查改
    //增 链式存储 计算上 优于 顺序存储 （中间插入时链式不用像顺序一样去移动位置）
    //删 链式存储 计算上 优于 顺序存储 （中间删除时链式不用像顺序一样去移动位置）
    //查 顺序存储 使用上 优于 链式存储 （数组可以直接通过下标得到元素 链式需要遍历）
    //改 顺序存储 使用上 优于 链式存储 （数组可以直接通过下标修改元素 链式需要遍历）
    #endregion

}
