using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classnote.myClass
{
    class Extends
    {
        public Out out1 = new Out("Extends.out1 父类字段");
        public static Out out2 = new Out("Extends.out1 父类静态字段");
        public string father = "Extend.father 父类字段";
        public Extends()
        {
            Console.WriteLine("extends->extends 父类构造方法");
        }
        public void Info()
        {
            Console.WriteLine("Extends->Info() 父类Info方法");
        }
        public virtual void Over()
        {
            Console.WriteLine("Extends->Over() 父类虚方法");
        }
    }
    class myExtends : Extends
    {
        public Out out3 = new Out("Extends.out1 子类字段");
        public static Out out5 = new Out("Extends.out1 子类静态字段");
        public myExtends()
            : base()
        {
            Console.WriteLine("MyExtends->MyExtends 子类构造方法");
        }
        new public void Info()
        {
            base.Info();//先调用父类Info方法
            Console.WriteLine("myExtends->Info() 子类Info方法");
        }
        public override void Over()
        {
            Console.WriteLine("myExtends->Over() 子类覆盖父类方法");
        }
    }
    class Out{
        public Out(string info){
            Console.WriteLine(info);
        }
    }
    class ExtendsTest
    {
        public ExtendsTest()
        {
            myExtends myext = new myExtends();
            Extends extends = new Extends();
            myext.Info();       //base父类 子类Info
            ((Extends)myext).Info();//父类Info
            //((myExtends)extends).Info();不能转换
            ((Extends)myext).Over();    //同样是子类方法
            Console.WriteLine(myext.father);
        }
    }
}
