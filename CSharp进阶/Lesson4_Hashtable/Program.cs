using System;
using System.Collections;

namespace Lesson4_Hashtable
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hashtable");

            #region 知识点一 Hashtable的本质
            //Hashtable(又称散列表) 是基于键的 哈希代码 组织起来的 键/值对
            //他的主要作用是提高数据 查询 的效率
            //使用键来访问集合中的元素
            #endregion

            #region 知识点二 申明
            //需要引用命名空间 System.Collections
            Hashtable hashtable = new Hashtable();
            #endregion

            #region 知识点三 增删查改

            #region 增
            //括号前面是键 后面是存储的对象
            hashtable.Add(1, "123");
            hashtable.Add("123", 2);
            hashtable.Add(true, false);
            hashtable.Add(false, false);

            //注意 不能出现相同键
            #endregion

            #region 删
            //1 只能通过键去删除
            hashtable.Remove(1);

            //2 删除不存在的键 没反应
            hashtable.Remove(2);

            //3 或者直接清空
            hashtable.Clear();
            hashtable.Add(1, "123");
            hashtable.Add(2, "1234");
            hashtable.Add(3, "123");
            hashtable.Add("123123", 12);
            #endregion

            #region 查
            //1 通过键查看值
            //  找不到会返回空
            Console.WriteLine(hashtable[1]);
            Console.WriteLine(hashtable[4]);//null
            Console.WriteLine(hashtable["123123"]);

            //2 查看是否存在
            //根据键检测
            if (hashtable.Contains(2))
            {
                Console.WriteLine("存在键为2的键值对");
            }
            if (hashtable.ContainsKey(2))
            {
                Console.WriteLine("存在键为2的键值对");
            }

            //根据值检测
            if (hashtable.ContainsValue(12))
            {
                Console.WriteLine("存在值为12的键值对");
            }
            #endregion

            #region 改
            //只能改 键对应的值内容 无法修改键
            Console.WriteLine(hashtable[1]);
            hashtable[1] = 100.5f;
            Console.WriteLine(hashtable[1]);
            #endregion

            #endregion

            #region 知识点四 遍历
            //得到键值对 对数
            Console.WriteLine(hashtable.Count);

            //1 遍历所有键
            foreach (object item in hashtable.Keys)
            {
                Console.WriteLine("键"+item);
                Console.WriteLine("值"+hashtable[item]);
            }
            //2 遍历所有值
            foreach (object item in hashtable.Values)
            {
                Console.WriteLine("值:"+item);
            }
            //3 键值对一起遍历
            foreach(DictionaryEntry item in hashtable)
            {
                Console.WriteLine("键: " + item.Key + "值: " + item.Value);
            }
            //4 迭代器遍历法
            IDictionaryEnumerator myEnumerator = hashtable.GetEnumerator();
            bool flag = myEnumerator.MoveNext();
            while (flag)
            {
                Console.WriteLine("键: " + myEnumerator.Key + "值: " + myEnumerator.Value);
                flag = myEnumerator.MoveNext();
            }
            #endregion

            #region 知识点五 装箱拆箱
            //由于用万物之父来存储数据 自然存在装箱拆箱
            //当往其中进行值类型存储时就是在装箱
            //当将值类型对象取出来转换使用时 就存在拆箱
            #endregion

        }
    }
}
