using System;

namespace Lesson16_if语句
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("if语句");
            #region 知识点一 作用
            //让顺序执行的代码产生分支
            #endregion

            #region 知识点二 if语句
            //if(bool 类型值=true){   }
            if (true) {
                Console.WriteLine("进入了if语句代码块");
            }
            Console.Write("if语句外的代码");

            int a = 1;
            if (a >0&&a<5) {
                Console.WriteLine("a在0到5之间");
            }

            string name = "唐老师";
            string password = "666";
            if (name == "唐老师" && password == "666") {
                Console.WriteLine("登录 成功");
            }

            if (name == "唐老师") {
                Console.WriteLine("用户名正确");
                if (password == "666") { 
                    Console.WriteLine("密码正确");
                }
            }
            #endregion

            #region 知识点三 if...else语句
            a = 1;
            if (a < 5) {
                Console.WriteLine("满足if条件");
            }
            else
            {
                Console.WriteLine("不满足if条件");
            }
            #endregion

            #region 知识点四 if...else if...else语句
            //作用 产生多条分支 最先满足其中一个条件 就做
            if (a < 5)
            {
                Console.WriteLine("满足if条件");
            }
            else if(a>0){
                Console.WriteLine("a依旧大于0");
            }
            else
            {
                Console.WriteLine("不满足if条件");
            }
            #endregion
        }
    }
}
