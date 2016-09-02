using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework.ByClass
{
class Calculator
{
    /// <summary>
    /// 加
    /// </summary>
    public double add(double a,double b)
    {
        return a + b;
    }
    /// <summary>
    /// 减
    /// </summary>
    public double minus(double a, double b)
    {
        return a - b;
    }
    /// <summary>
    /// 乘
    /// </summary>
    public double multiple(double a, double b)
    {
        return a * b;
    }
    /// <summary>
    /// 除
    /// </summary>
    public double divide(double a, double b)
    {
        if (b == 0)
        {
            return 0;
        }
        return a / b;
    }
}
}
