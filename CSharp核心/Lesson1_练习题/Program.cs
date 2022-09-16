using System;

namespace Lesson1_练习题
{

    class GameObject
    {

    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("练习题");

            #region 练习题一
            //将下面的事物进行分类 可重复
            //机器人 机器 猫 张阿姨 隔壁老王 汽车 飞机 向日葵 菊花 太阳 星星
            //机器
            //人
            //动物
            //植物 
            //星球
            #endregion

            #region 练习题二
            //GameObject A = new GameObject();
            //GameObject B = A;
            //B = null;
            //B等于null 只是B在栈中不再指向堆 A不会变
            #endregion

            #region 练习题三 
            GameObject A = new GameObject();
            GameObject B = A;
            B = new GameObject();
            //A 和 B没有关系
            #endregion
        }
    }
}
