using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ClassLibrary;
namespace test
{
    class Program
    {
        enum Week
        {
            Monday = 1,
            Tuesday = 2,
            Wednesday = 3,
            Sunday = 0,
            Everyday = 1　　//成员的值可以设置成一样的，但是成员不行
        }
       static void Main(string[] args)
        {
            MyNote mynote = new MyNote();
            Week w = Week.Monday;
            w = (Week)Enum.Parse(typeof(Week),"3",true);
            Console.WriteLine(w);
            Console.ReadLine();
        }
    }
}

