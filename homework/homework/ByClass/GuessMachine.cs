using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace homework.ByClass
{//
class GuessMachine
{
    Dictionary<string, double> commodity = new Dictionary<string, double>();
    public GuessMachine()
    {
        Initialize();
        Guess();
    }
    /// <summary>
    /// 预定义商品信息
    /// </summary>
    public void Initialize()
    {
        Commodity phone = new Commodity();
        commodity.Add("小米手机",1999);
        commodity.Add("小米平板", 999);
        commodity.Add("iPhone", 4999);
        commodity.Add("乐视电视", 3999);
        commodity.Add("神秘大奖", 1999);
    }
    /// <summary>
    /// 猜测商品
    /// </summary>
    public void Guess()
    {
        Random ran = new Random();
        int r = ran.Next(0, 5);
        Console.WriteLine("恭喜你抽中\"{0}\"价格猜猜猜活动，请输入猜测价格：", commodity.ElementAt(r).Key);
        while (true)
        {
            double d=double.Parse(Console.ReadLine());
            if (d > commodity.ElementAt(r).Value)
            {
                Console.WriteLine("猜多了");
            }
            else if (d < commodity.ElementAt(r).Value)
            {
                Console.WriteLine("猜少了");
            }
            else if (d == commodity.ElementAt(r).Value)
            {
                Console.WriteLine("恭喜答对价格，\"{0}\"归你了", commodity.ElementAt(r).Key);
                break;
            }
        }
    }
}

class Commodity
{
    public string name="";
    public double price=0;
}

}//
