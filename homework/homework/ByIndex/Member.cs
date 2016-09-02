using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework.ByIndex
{
/// <summary>
/// 会员类
/// </summary>
class Member
{
    private string account;

    public string Account
    {
        get { return account; }
        set { if (value.Length == 3) { account = value; } else { Console.WriteLine("账号长度必须3位"); } }
    }
    private double balance;

    public double Balance
    {
        get { if (balance >= 0) { return balance; } else { Console.WriteLine("无可用金额"); return 0; } }
        set { balance = value; }
    }
    public Member(string account, double balance)
    {
        this.account = account;
        this.balance = balance;
    }
}

}
