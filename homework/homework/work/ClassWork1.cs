using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework
{
class ClassWork1
{
    public ClassWork1(){
        int home=-1;
        while (home != 0)
        {
            Console.WriteLine("1:判断字符大小写\n2:大小数字游戏\n3：绘制金字塔\n4:季节判断\n0:退出");
            try
            {
                home = Int32.Parse(Console.ReadLine());
            }
            catch { home = 0;  }
            if (home == 1) Caps();
            else if (home == 2) Game();
            else if (home == 3) Pyramid();
            else if (home == 4) Season();
        }
    }
    public void Caps(){
        Console.WriteLine("请输入一个字母，判断大小写");
        int c = Console.Read();
        if (c >= (int)'a' && c <= (int)'z')
        {
            Console.WriteLine((char)c+"\t是小写字符");
        }
        else if (c >= (int)'A' && c <= (int)'Z')
        {
            Console.WriteLine((char)c + "\t是大写字符");
        }
    }

    public void Game()
    {
        Console.WriteLine("游戏规则：随机产生一个1-100的整数，把他猜出来");
        Random rnd = new Random();
        int ans = rnd.Next(1, 100);
        int myans=-1;
        while (myans != ans)
        {
             Console.WriteLine("请输入你计算的答案");
             myans =Int32.Parse( Console.ReadLine());
             if (myans > ans)
             {
                 Console.WriteLine("你计算的答案:{0}\t太大了/(ㄒoㄒ)/~~",myans);
             }
             else if (myans < ans)
             {
                 Console.WriteLine("你计算的答案:{0}\t太小了%>_<%", myans);
             }
             else if (ans == myans)
             {
                 Console.WriteLine("恭喜你回答正确O(∩_∩)O");
             }
        }
    }
    public void Pyramid()
    {
        Console.WriteLine("绘制金字塔：请输入金字塔的高度");
        int height = Int32.Parse(Console.ReadLine());
        for (int h = 1; h <= height; h++)
        {
            string row = "";
            for (int blank = 0; blank < height - h; blank++)
            {
                row += " ";
            }
            for(int star=0;star<=((h-1)*2);star++){
                row += "*";
            }
            Console.WriteLine(row);
        }
    }

    public void Season()
    {
        Console.WriteLine("请输入月份判断季节");
        int mon = Int32.Parse(Console.ReadLine());
        int season = mon / 4;
        switch (season){
            case 0:
            {
                Console.WriteLine("春天");
                break;
            }
            case 1:
            {
                Console.WriteLine("夏天");
                break;
            }
            case 2:
            {
                Console.WriteLine("秋天");
                break;
            }
            case 3:
            {
                Console.WriteLine("冬天");
                break;
            }
        }
           
        
    }

   
}
}
