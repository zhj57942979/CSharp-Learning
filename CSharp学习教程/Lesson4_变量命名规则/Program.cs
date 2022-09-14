using System;

namespace Lesson4_变量命名规则
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("变量命名规则");
            #region 知识点一 必须遵守规则
            //最好用英文或者拼音来取名
            #endregion
            #region 知识点二 常用命名规则
            //驼峰命名法 首字母小写，之后单词首字母大写（变量）
            string myName = "唐老师";
            string yourName = "你的名字";

            //帕斯卡命名法 所有单词首字母都大写（函数，类）
            string MyName = "ClassName";

            int print = 1;
            #endregion
        }
    }
}
