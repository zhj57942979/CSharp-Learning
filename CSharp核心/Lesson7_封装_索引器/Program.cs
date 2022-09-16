using System;

namespace Lesson7_封装_索引器
{
    #region 知识回顾
    //特征 成员变量
    //行为 成员方法
    //初始化调用 构造方法
    //释放时调用 析构方法
    //保护成员变量 成员属性
    #endregion

    #region 知识点一 索引器基本概念
    //基本概念
    //让对象可以像数组一样通过索引访问其中元素 使程序看起来更直观 更容易编写
    #endregion

    #region 知识点二 索引器语法
    //访问修饰符 返回值 this[参数类型 参数名, 参数类型 参数名......]
    // {
    //      内部的写法和规则和成员属性相同
    // }
    class Person
    {
        private string name;
        private int age;
        private Person[] friends;

        private int[,] array;//二维数组

        #region 知识点五 索引器可以重现
        //重载的概念 函数名相同 参数类型 数量 顺序不同
        public int this[int i, int j]
        {
            //还需要初始化
            get
            {
                return array[i, j];
            }
            set
            {
                array[i, j] = value;
            }
        }

        public string this [string str]
        {
            get
            {
                switch (str)
                {
                    case "name":
                        return this.name;
                    case "age":
                        return age.ToString();
                }
                return " ";
            }
        }
        #endregion

        public Person this[int index]
        {
            get
            {
                //可以写逻辑的 根据需求来处理这里面的内容
                #region 知识点四 索引器可以写逻辑
                if(friends == null || friends.Length - 1 < index)
                {
                    return null;
                }
                #endregion
                return friends[index];
            }
            set
            {
                //value代表传入的值
                //可以写逻辑
                if(friends == null)
                {
                    friends = new Person[] { value };
                }
                else if(index > friends.Length - 1)
                {
                    //自己定的规则 如果索引越界 就默认把最后一个朋友顶掉
                    friends[friends.Length-1] = value;
                }
                friends[index] = value;
            }
        }
    }
    #endregion

    //总结
    //索引器对于我们来说的主要作用
    //可以让我们以中括号的形式范围自定义类中的元素 规则自己定 访问时和数组一样
    //比较适用于 在类中有数组变量时使用 可以方便的访问和进行逻辑处理

    //固定写法
    //访问修饰符 返回值 this[参数列表]
    //get 和 set语句块
    //可以重载

    //注意 结构体里也是支持索引器

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("索引器");

            #region 知识点三 索引器的使用
            Person p = new Person();
            //以此来得到其中的一个朋友
            p[0] = new Person();
            p[0, 0] = 10;
            #endregion
        }
    }
}
