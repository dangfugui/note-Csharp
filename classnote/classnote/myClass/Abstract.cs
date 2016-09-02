using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classnote.myClass
{
    abstract class Abstract
    {
        public double basicWage;//基本工资
        public double wage;
        abstract public void Earning();
         public void Show()
         {
             Console.WriteLine("薪水：" + wage);
         }
    }
    class Sales : Abstract
    {
        public double ticeng;//提成
        public Sales(double basicWage, double ticeng)
        {
            base.basicWage = basicWage;
            this.ticeng = ticeng;
        }
        public override void Earning()
        {
            wage = basicWage + ticeng;
        }
    }

    class Manager : Abstract
    {
        public double gradel;//级别
        public Manager(double basicWage, double gradel)
        {
            base.basicWage = basicWage;
            this.gradel = gradel;
        }
        public override void Earning()
        {
            wage = gradel*basicWage;
        }
    }

    class AbstractTest
    {
        public AbstractTest()
        {
            Abstract sales = new Sales(1000,100);
            sales.Earning();
            sales.Show();
            Abstract manager = new Manager(1000,2);
            manager.Earning();
            manager.Show();
        }
    }

}
