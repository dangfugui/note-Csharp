using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


namespace homework.ByClass
{
class CalculateArea
{
    public CalculateArea()
    {
        //Console.WriteLine(Area(3,4,5));
        double[] arr = new double[]{1,2,3};
        Console.WriteLine(quadratic(arr));
    }

    /// <summary>
    /// 计算圆的面积
    /// </summary>
    /// <param name="r">半径</param>
    /// <returns>圆的面积</returns>
    public double Area(double r)
    {
        return Math.PI * r * r;
    }
    /// <summary>
    /// 计算矩形面积
    /// </summary>
    /// <param name="length">长</param>
    /// <param name="width">宽</param>
    /// <returns>矩形面积</returns>
    public double Area(double length, double width)
    {
        return length * width;
    }
    /// <summary>
    /// 计算三角形面积
    /// </summary>
    /// <param name="a">边长A</param>
    /// <param name="b">边长B</param>
    /// <param name="c">边长C</param>
    /// <returns>三角形面积</returns>
    public double Area(double a,double b,double c)
    {
        double p = (a + b + c) / 2;
        double ans = Math.Sqrt(p*((p-a)*(p-b)*(p-c)));
        return ans;
    }
    /// <summary>
    /// 判断大小
    /// </summary>
    /// <param name="a">第一个数值</param>
    /// <param name="b">第二个数值</param>
    /// <returns>较大的数值</returns>
    public double Max(double a,double b)
    {
        return (a > b) ? a : b;
    }
    /// <summary>
    /// 判断字符串大小
    /// </summary>
    /// <param name="a">第一个字符串</param>
    /// <param name="b">第二个字符串</param>
    /// <returns>字典排序较大的字符串</returns>
    public string Max(string a, string b)
    {
        if (string.Compare(a, b) > 0)
        {
            return a;
        }
        return b;
    }
    /// <summary>
    /// 求数组元素的平方和
    /// </summary>
    /// <param name="arr">数组</param>
    /// <returns>数组元素的平方和</returns>
    public double quadratic(double[] arr)
    {
        double ans = 0;
        foreach (double i in arr)
        {
            ans += i * i;
        }
        return ans;
    }
}
}
