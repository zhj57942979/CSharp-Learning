using System;

namespace Lesson2_练习题
{

    class Person
    {
        public string name;
        public int height;
        public int age;
        public string place;    
    }

    #region 练习题三
    //定义一个学生类 有姓名 学号 年龄 同桌
    class Student
    {
        public string name;
        public int number;
        public int age;
        public Student deskmate;
    }
    #endregion

    #region 练习题四
    //定义一个班级类
    class Class
    {
        public string name;
        public int capacity;
        public Student[] students;
    }
    #endregion

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("练习题");

            #region 练习题一
            //3p public private protected
            #endregion

            #region 练习题二
            Person p1 = new Person();
            p1.age = 11;
            p1.height = 172;
            p1.name = "小明";
            p1.place = "成都";
            #endregion

            //Student s = new Student();
            //s.name = "小刚";
            //s.age = 17;
            //s.number = 1;
            
            //Student s1 = new Student();
            //s.deskmate = s1;
            //s1.deskmate = s;

            //Class c = new Class();
            //c.name = "Unity";
            //c.capacity = 999999;
            //c.students = new Student[] { s, s1 };

            #region 练习题五
            //Person p = new Person();
            //p.age = 10;
            //Person p2 = new Person();
            //p2.age = 20;
            //请问p.age为多少 ...10
            #endregion

            #region 练习题六
            //Person p = new Person();
            //p.age = 10;
            //Person p2 = p;
            //p2.age = 20;
            //请问p.age是多少....20
            #endregion

            #region 练习题七
            //Student s3 = new Student();
            //s3.age = 10;
            //int age = s3.age;//int age存在栈中 而不堆里
            //age = 20;
            //请问s.age为多少.....10
            #endregion

            #region 练习题八
            Student s = new Student();
            s.deskmate = new Student();
            s.deskmate.age = 10;
            Student s2 = s.deskmate;
            s2.age = 20;
            Console.WriteLine(s.deskmate.age);
            //请问s.deskmate.age为多少.....20

            #endregion
        }
    }
}
