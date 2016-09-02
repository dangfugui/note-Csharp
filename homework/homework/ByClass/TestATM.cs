using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework.ByClass
{
class TestATM
{
    public TestATM()
    {
        AccountATM account = new AccountATM();
        while (true)
        {
            Console.WriteLine("1.查询余额\n2.存款\n3.取款\n4.退出");
            string type=Console.ReadLine();
            switch (type)
            {
                case "1":
                    {
                        Console.WriteLine("查询余额为：" + account.Inquire());
                        break;
                    }
                case "2":
                    {
                        Console.WriteLine("请输入存款金额：");
                        double aa = double.Parse(Console.ReadLine());
                        if (account.Deposit(aa)>0)
                        {
                            Console.WriteLine("存款成功");
                        }
                        
                        break;
                    }
                case "3":
                    {
                        Console.WriteLine("请输入取款金额：");
                        double bb = double.Parse(Console.ReadLine());
                        if (account.Withdrawing(bb) == 0)
                        {
                            Console.WriteLine("余额不足");
                        }
                        else
                        {
                            Console.WriteLine("取款成功");
                        }
                        break;
                    }
                default:
                    {
                        return ;
                    }
            }
        }
    }
}
}
