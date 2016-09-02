using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework.ByExtends
{
    /// <summary>
    /// 电器类
    /// </summary>
    class Electric
    {
        public double w;//功率
        public double u;//电压
        public double i;//电流
        public string type;//交直流类型
        public virtual void Work()
        {
            Console.WriteLine("Electric->Work()电器开始工作");
        }
    }
    class Television : Electric
    {
        public string kind; //种类
        public string maxVol;//最大声音
        public override void Work()
        {
            Console.WriteLine("Television->Work()电视开始工作");
        }
        public string toString()
        {
            string res = "";
            res += "种类："+kind;
            res += "\n最大声音：" + maxVol;
            res += "\n功率：" + w;
            res += "\n电压：" + u;
            res += "\n电流：" + i;
            res += "\n交直流类型：" + type;
            return res;
        }
    }
    class Freezer : Electric
    {
        public double capacity=0;
        public override void Work()
        {
            Console.WriteLine("Freezer->Work()冰箱开始工作");
        }
    }
    class ElectricText
    {
        public ElectricText()
        {
            Electric tv = new Television();
            Electric freezer = new Freezer();
            ((Television)tv).Work();
            ((Freezer)freezer).Work();
            Television tele = new Television();
            tele.type = "交流电";
            tele.i=2;
            tele.u=220;
            tele.w=440;
            tele.maxVol = "50";
            tele.kind = "超薄";
            Console.WriteLine(tele.toString());
        }
        
    }
}
