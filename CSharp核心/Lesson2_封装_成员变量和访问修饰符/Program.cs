using System;

namespace Lesson2_封装_成员变量和访问修饰符
{
    #region 知识回顾
    //类和对象
    //class 类名
    //{
    //    //特征 成员变量
    //    //行为 成员方法
    //    //保护特征 成员属性

    //    //构造函数和析构函数
    //    //索引器
    //    //运算符重载
    //    //静态成员
    //}

    // 实例化对象
    // Person 变量名;
    // Person 变量名 = new Person();
    #endregion

    #region 知识点一 成员变量
    //基本规则
    //申明在类语句块中
    //用来描述对象的特征
    //可以是任意变量类型
    //数量不做限制
    //是否赋值根据需求来定

    //性别枚举
    enum E_SexType
    {
        Man,
        Woman,
    }
    //位置结构体
    struct Position
    {

    }
    //宠物类
    class Pet
    {

    }
    class Person
    {
        //特征变量
        //姓名
        public string name;
        //年龄
        public int age;
        //性别
        public E_SexType sex;
        //女朋友
        public Person gridFriend;
        //在类里面可以申明一个自己 如果要申明 不能实例化 实例化就会报错
        //朋友
        public Person[] boyFriend;
        //位置
        public Position p;
        //宠物
        public Pet pet;

    }
    #endregion

    #region 知识点二 访问修饰符
    // private 私有的 自己内部才能访问使用 不写默认 private
    // public  公有的 内部和外部都能访问和使用
    // protected 保护的 自己内部和子类才能访问和使用
    // 目前决定类内部的成员的 访问权限
    #endregion
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("成员变量和访问修饰符");

            #region 知识点三 成员变量的使用和初始值
            //值类型 数字类型 默认值都0 bool类 默认false
            //引用类型 默认值null
            //查看默认值的小技巧
            Console.WriteLine(default(bool));
            #endregion

            Person p = new Person();
            p.age = 10;
            Console.WriteLine(p.age);
        }
    }

    //总结
    //成员变量
    //描述特征
    //类中申明
    //赋值随意
    //默认值 不相同
    //任意类型
    //任意数量

    //访问修饰符
    //public
    //private
    //protected
}
