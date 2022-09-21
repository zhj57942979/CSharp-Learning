using System;
using System.Collections.Generic;

namespace Lesson23_特殊语法
{
    class Person
    {
        private int money;
        public bool sexy;

        public string Name
        {
            get;
            set;
        }

        public int Age
        {
            get;
            set;
        }

        public Person(int money)
        {
            this.money = money;
        }
    }


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("特殊语法");

            #region 知识点一 var隐式类型
            //var是一种特殊的变量类型
            //它可以用来表示任意类型的变量
            //注意
            //1 var不能作为类的成员 只能用于临时变量申明时
            //  也就是 一般写在函数语句块中
            //2 var必须初始化

            //不确定的时候用var去装
            var i = 5;
            //只要初始化了 类型就定了
            var s = "123";
            var array = new int[] { 1, 2, 3, 4, 5 };
            var list = new List<int>();

            #endregion

            #region 知识点二 设置对象初始值
            //申明对象时
            //可以通过直接写大括号的形式初始化公共成员变量和属性
            //小括号是省略不写的 构造函数调用了
            Person p = new Person(100) { sexy = true, Age = 18, Name = "唐老师" };
            Person p2 = new Person(200) { Age = 18 };
            #endregion

            #region 知识点三 设置集合初始值
            //申明集合对象时
            //也可以通过大括号 直接初始化内部属性

            int[] array2 = new int[] { 1, 2, 3, 4, 5 };
            List<int> listInt = new List<int>() { 1, 2, 3, 4, 5, 6 };
            List<Person> listPerson = new List<Person>()
            {
                new Person(200),
                new Person(10){Age =10},
                new Person(1){sexy= true, Name="唐老师"}
            };
            Dictionary<int, string> dic = new Dictionary<int, string>()
            {
                {1, "123" },
                {2,"222" }
            };
            #endregion

            #region 知识点四 匿名类型
            //var 变量可以申明为自定义的匿名类型

            #endregion

            #region 知识点五 可空类型

            #endregion

            #region 知识点六 空合并操作符

            #endregion

            #region 知识点七 内插字符串

            #endregion

            #region 知识点八 单句逻辑简略写法

            #endregion

        }
    }
}
