using System;
using System.Collections;
using System.Linq;
using System.Text;

namespace homework
{
class ClassWork3
{
    public ClassWork3()
    {
        /*Console.WriteLine("请输入要转换成几进制");
        int jinzi = Int32.Parse(Console.ReadLine());
        Console.WriteLine("请输入要转换成{0}进制的数：",jinzi);
        int zuanhuan = Int32.Parse(Console.ReadLine());
        Console.WriteLine(Conversion(jinzi,zuanhuan));*/
        Console.WriteLine("请输入要转换的金额：");
        while (true){
        Console.WriteLine(Capita(Console.ReadLine()));
        }
    }
    public string Conversion(int jinzi,int zuanhuan)
    {
        int yu = zuanhuan % jinzi;
        int ans = zuanhuan / jinzi;
        if (ans == 0)
            return yu+"";
        return Conversion(jinzi,ans)+yu;
    }

    public string Capita(string str)
    {
        String ans="";
        //一、二、三、四、五、六、七、八、九、十、百、千、万
        //壹、贰、叁、肆、伍、陆、柒、捌、玖、拾、佰、仟、万
        Hashtable hash = new Hashtable();
        hash.Add("0", "");
        hash.Add("1", "壹");
        hash.Add("2", "贰");
        hash.Add("3", "叁");
        hash.Add("4", "肆");
        hash.Add("5", "伍");
        hash.Add("6", "陆");
        hash.Add("7", "柒");
        hash.Add("8", "捌");
        hash.Add("9", "玖");
        int len=str.Length;
        char[] arr = str.ToCharArray();     //转char数组
        for (int i=0;i<str.Length;i++)
        {
            ans+=hash[""+arr[i]];
            Console.WriteLine(i + ">>" + arr[i] + "---" + (len - i));
            if (i==len-1) { continue; }
            switch ((len - i)%4)
            {
                case 1: { ans += "万"; break; }
                case 0: { if(arr[i-1]!=0)ans += "仟"; break; }
                case 3: { ans += "佰"; break; }
                case 2: { ans += "拾"; break; }
            }
        }
        return ans;
    }

}
}
