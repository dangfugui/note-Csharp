using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classnote
{
class MyClass
{
    public const double PI = 3.1415926;//常量
    /// <summary>
    /// 封装字段
    /// </summary>
    private int age;
    private string[] myclass;
    public int Age
    {
        get { return age; }
        set { if (value > 0) { age = value; } else { age = 18; } }
    }
    /// <summary>
    /// 构建函数
    /// </summary>
    public MyClass(int size)
    {
        myclass = new string[size];
    }
    public void test()
    {
        MyClass mycl = new MyClass(5);
        mycl.Age = -15;
        Console.WriteLine(mycl.Age);     //18
        mycl[1] = "myclass1";
        mycl[2] = "myclass2";
        Console.WriteLine(mycl[2]);     //myclass2
    }
    /// <summary>
    /// 索引器
    /// </summary>
    /// <param name="index">下标</param>
    /// <returns>string 内容</returns>
    public string this[int index] {
        get {
            return myclass[index];
        }
        set {
            myclass[index] = value;
        }
    }



    /// <summary>
    /// 演示方法重载  
    /// 不同参数类型  参数个数 参数类型顺序都可个区分 编译器自动自动选择
    /// </summary>
    /// <param name="i">求绝对值</param>
    /// <returns>绝对值</returns>
    public int Abs(int i){
        return (i > 0) ? i : -i;
    }
    public double Abs(double d)
    {
        return (d > 0) ? d : -d;
    }
    /// <summary>
    /// 引用类型参数
    /// </summary>
    /// <param name="i"></param>
    public void Abs(ref int i)
    {
        if (i < 0) {
            i = -i;
        }
    }

    /// <summary>
    /// 析构函数 被堆回收时执行
    /// </summary>
    ~MyClass()
    {
        Console.WriteLine("MyClass被回收");
    }

}
}
