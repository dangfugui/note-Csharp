using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework
{
    class HomeWork1
    {
        public HomeWork1()
        {
            Console.WriteLine("请输入倒序前的字符串：");
            string str1 = Console.ReadLine();
            Console.WriteLine(Inverted(str1));
            Console.WriteLine("请输入需要去除空格的字符串：");
            string str2 = Console.ReadLine();
            Console.WriteLine(TrimBlank(str2));
            Console.WriteLine("请输入需要分解的路径：");
            string str3 = Console.ReadLine();
            ResolvePath(str3);
            TestChar();
        }
        /// <summary>
        /// 倒序字符串
        /// </summary>
        /// <param name="str">倒序前的字符串</param>
        /// <returns>倒序的字符串</returns>
        public string Inverted(string str)
        {
            string ans="";
            char[] arr=str.ToCharArray();
            /*for (int i = arr.Length-1; i>=0; i--)
            {
                ans += arr[i];
            }*/
            Array.Reverse(arr);
            ans =new string(arr);
            return ans;
        }
        /// <summary>
        /// 去除字符串中的空格
        /// </summary>
        /// <param name="str">需要去除空格的字符串</param>
        /// <returns>去除空格的字符串</returns>
        public string TrimBlank(string str)
        {
            string ans="";
            char[] arr = str.ToCharArray();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] != ' ')
                {
                    ans += arr[i];
                }
            }
                return ans;
        }
        /// <summary>
        ///分解路径 文件名 后缀名
        /// </summary>
        /// <param name="str">需要分解的文件路径</param>
        public void ResolvePath(string str)
        {
            string name;
            string suffix;
            string path;
            path = str.Substring(0,str.LastIndexOf('\\'));
            name = str.Substring(str.LastIndexOf('\\')+1,str.Length-str.LastIndexOf('\\')-1);
            suffix = name.Substring(name.IndexOf('.'),name.Length-name.IndexOf('.'));
            Console.WriteLine("path is:{0}\name is:{1}\nsuffix id:{2}",path,name,suffix);
        }
        public void TestChar()
        {
            string str = "danqihe";
            char[] arr = str.ToCharArray();     //转char数组
            Array.Reverse(arr);                 //翻转
            Console.WriteLine(arr);             
            Console.WriteLine(arr.Max());       //最大的字母
            Console.WriteLine(arr.Min());       //最小的字母
            Console.WriteLine(arr.Length);      //长度
            Console.WriteLine(arr.GetHashCode());//hash码
            char c = 'a';
             Console.WriteLine(c.Equals('a'));   //比较

        }
    }
}
