using System;

namespace Lesson8_ref和out
{
    class Program
    {            
        #region 知识点一  ref out的原因
        //学习原因
        //他们可以解决在函数内部改变外部传入的内容 里面变了 外面也要变

        static void ChangeValue(int value)
        {
            value = 3;
        }

        static void ChangeArrayValue(int[] arr)
        {
            arr[0] = 99;
        }

        static void ChangeArray(int[] arr)
        {
            arr = new int[] { 10, 20, 30 };
        }

        #endregion

        #region 知识点二 ref和out的使用
        //函数参数的修饰符
        //
        static void ChangeValueRef(ref int value)
        {
            value = 3;
        }

        static void ChangeArrayRef(ref int[] arr)
        {
            arr = new int[] { 10, 20, 30 };
        }


        //out
        static void ChangeValueOut(out int value)
        {
            value = 98;
        }

        #endregion

        #region 知识点三 ref和out的区别
        //ref传入的变量必须初始化 out不用
        //out传入的变量必须在内部赋值 ref不用

        #endregion

        static void Main(string[] args)
        {
            Console.WriteLine("ref和out");
            int a;
            //ChangeValueRef(ref a); //会报错
            ChangeValueOut(out a);



            //int a = 1;
            //ChangeValue(a);
            //Console.WriteLine(a);
            ////值类型

            //ChangeValueRef(ref a);
            //Console.WriteLine(a);

            //ChangeValueOut(out a);
            //Console.WriteLine(a);




            //int[] arr2 = { 1, 2, 3 };
            //ChangeArrayValue(arr2);
            //Console.WriteLine(arr2[0]);
            ////引用类型

            //ChangeArray(arr2);
            ////arr新指向一个堆 但是不是arr2指向新空间
            //Console.WriteLine(arr2[0]);

            //ChangeArrayRef(ref arr2);
            ////arr新指向一个堆 但是不是arr2指向新空间
            //Console.WriteLine(arr2[0]);



        }
    }
}
