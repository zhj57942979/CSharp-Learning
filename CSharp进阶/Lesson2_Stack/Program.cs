using System;
using System.Collections;

namespace Lesson2_Stack
{
    class Test
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Stack");
            #region 知识点一 Stack的本质
            //Stack 是一个C#为我们封装好的类
            //它的本质也是object[]数组 只是封装了特殊的存储规则

            //Stack是栈存储容器 栈是一种先进后出的数据结构
            //先存入的数据后获取 后存入的数据先获取
            //栈是先进后出
            #endregion

            #region 知识点二 申明
            //需要引用命名空间 System.Collections
            Stack stack = new Stack();
            #endregion

            #region 知识点三 增取查改

            #region 增
            //压栈
            stack.Push(1);
            stack.Push("123");
            stack.Push(true);
            stack.Push(1.2f);
            stack.Push(new Test());

            //栈的增取都只能一个一个放
            #endregion

            #region 取
            //栈中不存在删除的概念
            //只有取的概念
            //弹栈
            object v = stack.Pop();
            Console.WriteLine(v);

            v = stack.Pop();
            Console.WriteLine(v);
            #endregion

            #region 查
            //1 栈无法查看指定位置的 元素
            //  只能查看栈顶的内容
            //Peek()查看栈顶的内容 但是不把他弹出来
            v = stack.Peek();
            Console.WriteLine(v);
            v = stack.Peek();
            Console.WriteLine(v);

            //2 查看元素是否存在于栈中
            if (stack.Contains("123"))
            {
                Console.WriteLine("123在栈中");
            }
            #endregion

            #region 改
            //栈无法改变其中的元素 只能压（存）和弹（取）
            //实在要改 只能清空
            stack.Clear();

            stack.Push("1");
            stack.Push(2);
            stack.Push("急急急");
            #endregion

            #endregion

            #region 知识点四 遍历
            //1 长度
            Console.WriteLine(stack.Count);
            //栈不能通过for遍历

            //2 用foreach遍历
            //  而且遍历出来的顺序 也是从栈顶到栈底
            foreach(object item in stack)
            {
                Console.WriteLine(item);
            }

            //3 还有一种遍历方式
            //  将栈转换为object数组
            //  遍历出来的顺序 也是从栈顶到栈底
            object[] array = stack.ToArray();
            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine(array[i]);
            }

            //4 循环弹栈
            while (stack.Count > 0)
            {
                object o = stack.Pop();
                Console.WriteLine(o);
            }
            Console.WriteLine(stack.Count);
            #endregion

            #region 知识点五 装箱拆箱
            //由于用万物之父来存储数据 自然存在装箱拆箱
            //当往其中进行值类型存储时就是在装箱
            //当将值类型对象取出来转换使用时 就存在拆箱
            #endregion
        }
    }
}
