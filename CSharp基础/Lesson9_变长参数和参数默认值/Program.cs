using System;

namespace Lesson9_变长参数和参数默认值
{
    class Program
    {

        #region 知识点一 函数语法复习
        //static void 函数名(参数类型 参数1, 参数类型 参数2.......)
        // {
        //     return 返回值
        // }
        // 静态关键词 可选 目前必须写
        //返回值 没有返回值填void 可以填写任意类型变量
        //函数名 帕斯卡命名法
        //参数可以是0到n个 前面可以加 ref和out用来传递想要在函数内部改变内容的变量
        //如果返回值不是void 那么必须有return对应类型的内容 return可以打断函数语句块中的逻辑 直接停止后面的逻辑


        #endregion

        #region 知识点二 变长参数关键词
        //举例 函数要计算n个参数的和
        //static int Sum(int a, int b, int c, ...)
        //变长参数关键词 params

        static int Sum(params int[] arr)
        {
            int sum = 0;
            for(int i = 0; i < arr.Length; i++)
            {
                sum += arr[i];

            }
            return sum;
        }

        //params int[] 意味着可以传入n个int参数 n可以等于0 传入的参数会存在arr数组中
        //注意
        //params关键字后面必为数组
        //数组的类型可以是任意的类型

        //函数参数可以有别的参数和  params关键词修饰的参数
        //函数参数中只能最多出现一个params关键字 并且一定实在最后一组参数 前面可以有n个其他参数
        static void Eat(string name, params string[] things) 
        {
            
        }

        #endregion

        #region 知识点三 参数默认值
        //有参数默认值的参数 一般称为可选参数
        //作用是 当调用函数时可以不传入参数，不传就会使用默认值作为参数的值

        static void Speak(string str = "我没什么话可说")
        {
            Console.WriteLine(str);
        }

        //注意
        //支持多参数默认值 每个参数都可以有默认值
        //如果要混用 可选参数 必须写在 普通参数后面

        static void Speak2(string test, string name="唐老师",string str = "我没什么话可说")
        {
            Console.WriteLine(test+name+str);
        }
        #endregion

        //总结
        //params 后面必须是数组 只能是同一类型的变量
        //参数默认值（可选参数）不传参数用默认 传了参数用传的参数

        static void Main(string[] args)
        {
            Console.WriteLine("变长参数和参数默认值");

            Console.WriteLine(Sum(1,2,3,4,5,6,7));

            Speak();//有默认值就打印默认值
            Speak("123123");
            Speak2("你好啊,");
        }
    }
}
