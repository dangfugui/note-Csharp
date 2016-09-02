using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using classnote.myClass;
using classnote.myFile;
namespace classnote
{
    class MyMain
    {
        static void Main()
        {
            //new MyNote().MyArray();;   //上课笔记
            Application.EnableVisualStyles();     //图形化计算器
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new View());
            //MyMath math = new MyMath();
            //Console.WriteLine( math.multiple("*/=+-") );
           // Console.WriteLine(Math.Pow(4,0.5));
            //Collections coll = new Collections();
            //coll.myList();
           // new MyClass(5).test();
            //new ExtendsTest();  //类的继承
           // new AbstractTest();   //抽象
           // new TransportationTest();//接口
           // new ExceptionTest();//异常
            //new MyFile();       //文件
            Console.ReadLine();
        }
    }
}
