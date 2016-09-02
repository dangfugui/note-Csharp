#define DEBUG       //预处理
//#undef DEBUG      //不预处理
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classnote
{   
    /// <summary>
    /// 我的笔记
    /// </summary>
    class MyNote
    {
        const Double PI = 3.1415926;            //常量
        readonly string name = "dangqihe"+PI;      //只读

        public void Show()
        {
           Type();         //数据类型
           TestString();   //字符串类
           TestMath();         //数学类
           TestChar();
           Define();       //预处理
           myEnum();       //枚举类型*/
           MyArray();      //数组
        }
        /// <summary>
        /// 数据类型
        /// </summary>
        public void Type()
        {
            Console.WriteLine("++++++++++++++++++++MyNote->type() start++++++++++++++++++++");
            string d = new string('d',10);
            Console.WriteLine(d);
            Console.WriteLine(123.GetType());   //System.Int32
            Console.WriteLine(123U.GetType());  //System.UInt32
            Console.WriteLine(123L.GetType());  //System.Int64
            Console.WriteLine(123UL.GetType()); //System.UInt64
            Console.WriteLine(PI.GetType());    //System.Double
            Console.WriteLine('c'.GetType());   //System.Char
            Console.WriteLine("string".GetType());//System.String
            Console.WriteLine("{0}，{1}",123,"string");//占位符
            for (int i = 0; i < 10; i++)
            {
                Console.Write("{0},", i);           
            }
            Console.WriteLine();
            Console.WriteLine("--------------------MyNote->type() end----------------------");
            
        }
        /// <summary>
        /// 字符串类
        /// </summary>
        public void TestString()
        {
            Console.WriteLine("++++++++++++++++++++MyNote->testString() start++++++++++++++++++++");
            string str = "党启贺";
            Console.WriteLine("'党启贺'.IndexOf('启')\t"+str.IndexOf("启")); //查找子串位置
            Console.WriteLine("'党启贺'.Substring(1, 2)\t" + str.Substring(1, 2));//取子串
            Console.WriteLine("'党启贺'.CompareTo('党')\t" + str.CompareTo("党"));//字符串比较
            Console.WriteLine("'党启贺'.ToCharArray()\t" + str.ToCharArray());     //
            Console.WriteLine("--------------------MyNote->testString() end----------------------");
        }
        /// <summary>
        /// 数学类
        /// </summary>
        public void TestMath() 
        {
            Console.WriteLine("++++++++++++++++++++MyNote->math() start++++++++++++++++++++");
            double d = -123.456;
            Console.WriteLine("Math.Abs(-123.456) \t" + Math.Abs(d));       //绝对值
            Console.WriteLine("Math.Max(123,456) \t"+Math.Max(123,456));    //最大值
            Console.WriteLine("Math.Min(123, 456) \t"+Math.Min(123, 456));  //最小值
            Console.WriteLine("Math.Round(d) \t" + Math.Round(d));          //四舍五入
            Console.WriteLine("Math.Sqrt(9) \t" + Math.Sqrt(9));            //开根
            Console.WriteLine("Math.Pow(10,3) \t" + Math.Pow(10,3));        //次方
            Console.WriteLine("--------------------MyNote->math() end----------------------");
        }
        /// <summary>
        /// 字符串使用
        /// </summary>
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
        /// <summary>
        /// Define 的使用
        /// </summary>
        public void Define()
        {
            #region
            Console.WriteLine("++++++++++++++++++++MyNote->define() start++++++++++++++++++++");
            #if DEBUG
            Console.WriteLine("#if DEBUG;;;#endif");
            #endif
            Console.WriteLine("--------------------MyNote->define() end----------------------");
            #endregion
        }

        enum Week
        {
            Sunday,Monday,Tuesday,Wednesday,Thursday,Friday,Saturday//成员的值可以设置成一样的，但是成员不行
        }
        /// <summary>
        /// 枚举类型
        /// </summary>
        public void myEnum()
        {
            Console.WriteLine("++++++++++++++++++++MyNote->myEnum()枚举类型 start++++++++++++++++++++");
            Week w = Week.Monday;
            Console.WriteLine(w);
            w = (Week)Enum.Parse(typeof(Week), "Sunday", true);  //类型转换
            Console.WriteLine("把字符串转换成枚举类型"+w);
            foreach (string i in Enum.GetNames(typeof(Week)))
            {
                Console.WriteLine("遍历Week枚举类型：Enum.GatNames()"+i);
            }
            foreach (int i in Enum.GetValues(typeof(Week)))
            {
                Console.WriteLine("遍历Week枚举类型：Enum.GatValues()" + i);
            }
            Console.WriteLine("GetName(,1)\t{0}",Enum.GetName(typeof(Week),1));     //得到枚举类型的第二个名字
            Console.WriteLine("ToObject(,1)\t{0}",Enum.ToObject(typeof(Week), 1));  //得到Week的第二个枚举
            int a = 123;
            double d = a;
            Console.WriteLine(d);
            d = 123.456;
            int b = (int)d;
            Console.WriteLine(b);
            Console.WriteLine("--------------------MyNote->myEnum()() end----------------------");
        }
        /// <summary>
        /// 数组
        /// </summary>
        public void MyArray()
        {
            Console.WriteLine("++++++++++++++++++++MyNote->MyArray数组 start++++++++++++++++++++");
            string[]str_arr = {"arr0","arr1","arr2","arr3" };
            foreach(string str in str_arr){     //遍历数组
                Console.WriteLine(str);
            }
            int l = 5;              //int [] nums;  nums=new int[5]{1,2,3,4,5};
            int [] nums=new int[l];     //动态初始化
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = i;
                Console.WriteLine("nums:"+i);
            }
            int row = 2, col = 3;
            string[,] strss= new string[row,col];       //二维数组
            for (int a = 0; a < row; a++)
                for (int b = 0; b < col; b++)
                {
                    strss[a, b] = "strss[" + a + "," + b + "]";
                    Console.WriteLine(strss[a,b]);
                }
            string [][]jag =new string[3][];             //不规则数组
            jag[0]=new string[3]{"jag[0][0]","jag[0][1]","jag[0][2]"};
            jag[1] = new string[4] { "jag[1][0]", "jag[1][1]", "jag[1][2]", "jag[1][3]" };
            jag[2] = new string[2] { "jag[2][0]", "jag[2][1]" };
            foreach (string[] item in jag)
            {
                foreach (string str in item)
                {
                    Console.Write(str);
                }
                Console.WriteLine();
            }
            Array intarr = Array.CreateInstance(typeof(int),10); //定义数组
            Array intarr2 = Array.CreateInstance(typeof(int), 10); //定义数组
            for (int i = 0; i < intarr.Length; i++)
            {
                intarr.SetValue(i,i);
                intarr2.SetValue(i, i);//数组赋值
            }
            Array.Clear(intarr2,2,3);   //清理数组
            Console.WriteLine(ArrayToString(intarr2) + "清理数组 Array.Clear(intarr2,2,5); ");
            Console.WriteLine( ArrayToString(intarr));     //数组取值
            Array.Reverse(intarr,1,3);                  //反转数组部分
            Console.WriteLine(ArrayToString(intarr)+"反转后 Array.Reverse(intarr,1,3)" );
            intarr.CopyTo(intarr2, 0); 
            Console.WriteLine(ArrayToString(intarr2) + "复制 intarr.CopyTo(intarr2, 0);");
            Array.Sort(intarr);
            Console.WriteLine(ArrayToString(intarr) + "排序后 Array.Sort(intarr)");
            Console.WriteLine(Array.LastIndexOf(intarr, 5) + "\t\t查找 Array.LastIndexOf(intarr,5)");     //查找
            Console.WriteLine("{0}  Rank  {1}",intarr.ToString(),intarr.Rank);      //获取维数
            Console.WriteLine("--------------------MyNote->MyArray() end----------------------");
        } 
        string ArrayToString(Array arr)
        {
            string res = "Array{";
            for (int i = 0; i < arr.Length; i++)
            {
                res+=arr.GetValue(i)+",";
            }
            res += "} length="+arr.Length;
       
            return res;
        }


         ~MyNote()
        {
            Console.WriteLine("析构函数 类被回收时用");
        }
    }
}
