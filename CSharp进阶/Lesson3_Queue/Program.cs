using System;
using System.Collections;

namespace Lesson3_Queue
{
    class Test
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Queue");

            #region 知识点一 Queue本质
            //Queue是一个C#为我们封装好的的类
            //他的本质也是object[] 数组 只是封装了特殊的存储规则

            //Queue是队列存储容器
            //队列是一种先进先出的数据结构
            //先存入的数据先获取 后存入的数据后获取
            //先进先出
            #endregion

            #region 知识点二 申明
            //需要引用命名空间 System.Collections
            Queue queue = new Queue();
            #endregion

            #region 知识点三 增取查改

            #region 增
            queue.Enqueue(1);
            queue.Enqueue("123");
            queue.Enqueue(1.4f);
            queue.Enqueue(new Test());
            #endregion

            #region 取
            //队列中不存在删除的概念
            //只有取的概念 取出先加入的对象
            object v = queue.Dequeue();
            Console.WriteLine(v);
            v = queue.Dequeue();
            Console.WriteLine(v);
            #endregion

            #region 查
            //1 查看队列头部元素但不会移除
            v = queue.Peek();
            Console.WriteLine(v);
            v = queue.Peek();
            Console.WriteLine(v);

            //2 查看元素是否存在于队列中
            if (queue.Contains(1.4))
            {
                Console.WriteLine("队列中存在1.4f");
            }
            #endregion

            #region 改
            //队列无法改变其中的元素 只能进出队列
            //实在要改 只能清除
            queue.Clear();
            queue.Enqueue("急急急");
            queue.Enqueue("我是急急国王");
            queue.Enqueue("哈哈哈");
            #endregion

            #endregion

            #region 知识点四 遍历
            //1 长度
            Console.WriteLine(queue.Count);
            //2 用foreach遍历
            foreach(object item in queue)
            {
                Console.WriteLine(item);
            }
            //3 还有一种遍历方式
            //  将队列转换为object数组
            object[] array = queue.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }
            //4 循环出列
            while (queue.Count > 0)
            {
                object o = queue.Dequeue();
                Console.WriteLine(o);
            }
            Console.WriteLine(queue.Count);
            #endregion

            #region 知识点五 装箱拆箱
            //由于用万物之父来存储数据 自然存在装箱拆箱
            //当往其中进行值类型存储时就是在装箱
            //当将值类型对象取出来转换使用时 就存在拆箱
            #endregion
        }
    }
}
