using System;

namespace Lesson3_成员方法
{
    #region 知识点一 成员
    //基本概念
    //成员方法 用来表现对象行为
    //1 申明在类语句块中
    //2 是用来表述对象的行为的
    //3 规则和函数申明规则相同
    //4 受到访问修饰符规则的影响
    //5 返回值参数不做限制
    //6 方法数量不做限制

    //注意
    //1 成员方法不要加static关键字
    //2 成员方法 必须实例化对象 再通过对象来使用 相当于该对象执行了某个行为
    //3 成员方法 受到访问修饰符影响
    #endregion

    class Person
    {
        /// <summary>
        /// 说话的行为
        /// </summary>
        /// <param name="str">说话的内容</param>
        public void Speak(string str)
        {
            Console.WriteLine("{0}说：{1}", name, str);
        }

        public void  AddFriend(Person p)
        {
            if(friends == null)
            {
                friends = new Person[] { p };
            }
            else
            {
                //扩容 新建一个数组
                Person[] newFriends = new Person[friends.Length + 1];
                //搬家
                for(int i = 0; i < friends.Length; i++)
                {
                    newFriends[i] = friends[i];
                }
                //新数组最后加一个人
                newFriends[newFriends.Length - 1] = p;
                friends = newFriends;
            }
        }

        /// <summary>
        /// 判断是否成年
        /// </summary>
        /// <returns></returns>
        public bool IsAdult()
        {
            return age >= 18;
        }

        public string name;
        public int age;
        //朋友们
        public Person[] friends;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            #region 知识点二 成员方法的申明
            //2 成员方法 必须实例化出对象 再通过对象来使用 相当于该对象执行了某个行为
            Person p = new Person();
            p.age = 20;
            p.name = "唐老师";
            p.Speak("我爱你");

            if (p.IsAdult())
            {
                p.Speak("我要耍朋友");
            }

            Person p2 = new Person();
            p2.name = "火山哥";
            p2.age = 16;

            p.AddFriend(p2);

            for(int i = 0; i < p.friends.Length; i++)
            {
                Console.WriteLine(p.friends[i].name);
            }
            #endregion

            //总结
            //成员方法
            //描述行为
            //类中申明
            //任意数量
            //返回值和参数根据需求决定
        }
    }
}
