using System;
using System.Collections;

namespace Lesson1_ArrayList
{

    class Test
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("ArrayList");

            #region 练习题回顾
            //C#核心中 索引器的练习题
            //自定义一个整形数组类 该类中有一个整形数组变量
            //为它封装增删查改的方法
            #endregion

            #region 知识点一 ArrayList的本质
            //ArrayList是一个C#为我们封装好的类
            //他的本质是一个object类型的数组
            //ArrayList类帮助我们实现了很多方法
            //比如数组的增删查改
            #endregion

            #region 知识点二 申明
            //需要引用命名空间using System.Collection
            ArrayList array = new ArrayList();
            #endregion

            #region 知识点三 增删查改

            #region 增
            array.Add(1);
            array.Add("123");
            array.Add(true);
            array.Add(new object());
            array.Add(new Test());
            array.Add(1);

            ArrayList array2 = new ArrayList();
            array2.Add(123);
            //范围增加 （批量增加 把另一个list容器里面的内容加到后面）
            array.AddRange(array2);

            //插入指定位置
            array.Insert(1, "1234567");
            Console.WriteLine(array[1]);
            #endregion

            #region 删

            //Remove会从头到尾开始遍历 删除第一个 移除指定元素
            array.Remove(1);
            //移除指定位置的元素
            array.RemoveAt(2);
            //清空
            //array.Clear();

            #endregion

            #region 查
            //得到指定位置的元素
            Console.WriteLine(array[0]);

            //查看元素是否存在
            if (array.Contains("123"))
            {
                Console.WriteLine("存在123");
            }

            //正向查找元素位置 从头开始找 返回找到的第一个
            //找到的返回值 是位置 如果找不到 返回值是-1
            int index = array.IndexOf(true);
            Console.WriteLine(index);

            Console.WriteLine(array.IndexOf(false));

            //反向查找元素位置
            //返回时从头开始的索引值
            index = array.LastIndexOf(true);
            Console.WriteLine(index);
            #endregion

            #region 改
            Console.WriteLine(array[0]);
            array[0] = "999";
            Console.WriteLine(array[0]);
            #endregion

            #endregion

            #region 遍历
            //长度
            Console.WriteLine(array.Count);
            //容量--ADD自动扩容---因此数组扩容是会有垃圾产生
            //避免产生过多的垃圾
            Console.WriteLine(array.Capacity);
            Console.WriteLine("***************");
            for (int i = 0; i < array.Count; i++)
            {
                Console.WriteLine(array[i]);
            }
            Console.WriteLine("***************");
            //迭代器遍历
            foreach (object item in array)
            {
                Console.WriteLine(item);
            }

            #endregion

            #region 知识点四 装箱拆箱
            //ArrayList本质上是一个可以自动扩容的object数组
            //由于用万物之父来存储数据 自然存在装箱拆箱
            //当往其中进行值类型存储时就是在装箱 当将值类型对象取出来转换使用时 就存在拆箱
            //所以ArrayList尽量少用 之后我们会学习更好的数据容器

            int i = 1;
            array[0] = i;//装箱
            i = (int)array[0];//拆箱
            #endregion

        }
    }
}
