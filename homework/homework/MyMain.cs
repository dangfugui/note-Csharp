using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using homework.ByClass;
using homework.ByIndex;
using homework.ByExtends;
using homework.ByInterface;
using homework.ByException;
namespace homework
{
    class myMain
    {
        static void Main(string[] args)
        {
            //HomeWork1 hw1 = new HomeWork1();
            //ClassWork1 cw1 = new ClassWork1();
            //ClassWork3 cw3 = new ClassWork3();
           // TestATM atm = new TestATM();  //ATM机
           // GuessMachine guess = new GuessMachine();        //商品抽奖
           // CalculateArea area = new CalculateArea();//计算圆的面积
           // TestStore testStore = new TestStore();        //商店
           // new TestCat();    //黑白猫
          //  new TestStudent();    //学生
          //  new ElectricText(); //电器
            //new PersonTest();   //学生
          //  new AnimalTest();   //动物园测试
           // new ShapeTest();        //继承 接口计算圆面积
           // new IdDateSeriesTest(); //接口 生产序列数
            new ExceptionTest1().overflowtest();//异常测试
            Console.ReadLine();
        }
    }
}
