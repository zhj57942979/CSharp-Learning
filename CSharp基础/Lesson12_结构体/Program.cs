using System;

namespace Lesson12_结构体
{
    #region 知识点一 基本概念
    //结构体 是一种自定义变量类型 类似枚举需要自己定义
    //他是数据和函数的集合
    //在结构体中 可以申明各种变量和方法

    //作用 用来表现存在关系的数据集合 比如结构体表现学生 动物 人类等等
    #endregion

    #region 知识点二 基本语法
    //结构体一般写在namespace语句块中
    //结构体 关键字 struct

    //struct 自定义结构体名
    //{
    //    //第一部分
    //    //变量

    //    //第二部分
    //    //构造函数 可选

    //    //第三部分
    //    //函数
    //}
    //注意 结构体名字 的规范是 帕斯卡命名法

    #endregion

    #region 知识点三 实例
    //表现学生数据的结构体
    struct Student
    {
        //变量
        //在结构体中申明的变量 不能直接初始化
        //变量类型 可以写任意类型 包括结构体 但是不能是自己的结构体
        //年龄
        public int age;
        //性别
        public bool sex;
        //学号
        public int number;
        //姓名
        public string name;

        //构造函数
        #region 知识点六 结构体的构造函数
        //基本概念
        //1 没有返回值
        //2 函数名必须和结构体名相同
        //3 必须有参数
        //4 如果申明了构造函数 那么必须在其中对所有变量数据初始化

        //构造函数 一般是用于在外部方便初始化
        public Student(int age,bool sex,int number, string name)
        {
            //新的关键词 this
            //代表自己
            this.age = age;
            this.sex = sex;
            this.number = number;
            this.name = name;
        }
        #endregion

        //函数方法
        //表现这个数据结构的行为

        //注意 在结构体中的方法 目前不需要static 关键字
        public void Speak()
        {
            //函数中可以直接使用结构体中声明的变量
            Console.WriteLine("我的名字是{0},我今年{1}岁", name, age);
        }//可以根据需求 写无数个函数
    }


    #endregion


    #region 知识点五 访问修饰符
    //修饰结构体中变量和方法 是否能被外部使用
    //public 可以被外部访问
    //private 只能在内容使用
    //默认不写为private
    #endregion


    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("结构体");

            #region 知识点四 结构体的使用
            //变量类型 变量名;
            Student s1;
            s1.age = 10;
            s1.sex = false;
            s1.number = 1;
            s1.name = "唐老师";
            s1.Speak();

            Student s2 = new Student(11, true, 2, "小红");
            s2.Speak();
            #endregion

            //总结
            //结构体 struct
            //访问修饰符 public private
            //构造函数 没有返回值 可以重载 this

            //注意
            //结构体中变量不能初始化

        }
    }
}
