//定义一个符号
#define Unity4
#define Unity5
#define Unity2017
#define Unity2019
//取消定义一个符号
#undef Unity4

#define IOS
#define Android
#define PC

using System;

namespace Lesson19_预处理器指令
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("预处理器指令");

            #region 知识点一 什么是编译器
            //编译器是一种翻译程序
            //它用于将源语言程序翻译为目标语言程序

            //源语言程序 某种程序设计语言写成的 比如C# C C++ Java等语言写的程序
            //目标语言程序 二进制数表示的伪机器代码写的程序
            #endregion

            #region 知识点二 什么是预处理器指令
            //预处理器指令 指导编译器 在实际编译开始之前对信息进行预处理
            //预处理指令 都是以#开始
            //预处理器指令不是语句 所以他们不以分号;结束
            //目前我们经常用到的 折叠代码块 就是预处理器指令
            #endregion

            #region 知识点三 常见的预处理器指令
            //1
            //#define
            //定义一个符号 类似一个没有值的变量
            //#undef
            //取消define定义的符号 让其失效
            //两者都是写在脚本文件最前面
            //一般配合 if指令使用 或配合特性

            //2
            //#if
            //#elif
            //#else
            //#endif
            //和if语句规则一样 一般配合#define定义的符号使用
            //用于高速编译器进行编译代码的流程控制

            //如果发现有Unity4这个符号 那么其中包含的代码 就会被编译器翻译
            //可以通过 逻辑或 和 逻辑与 进行多种符号的组合判断

#if Unity4
            Console.WriteLine("版本为Unity4");
#elif Unity2017 && IOS
            Console.WriteLine("版本为Unity2017 IOS");
            //#warning 这个版本 不合法
            //#error 这个版本不准执行
#else
            Console.WriteLine("其他Unity版本");
#endif

            //3
            //#warning
            //#error
            //告诉编译器
            //是报警告还是报错误
            //一般还是配合if使用
            #endregion
        }
    }

    //总结
    //预处理器指令
    //可以让代码还没有编译之前就可以进行一些预处理判断
    //在Unity中会用来进行一些平台或者版本的判断
    //决定不同的版本或者不同的平台使用不同的代码逻辑
}
