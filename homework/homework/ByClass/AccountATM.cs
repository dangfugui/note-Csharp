using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework.ByClass
{
class AccountATM
{
    static double balance = 0; //余额
    /// <summary>
    /// 查询
    /// </summary>
    /// <returns></returns>
    public double Inquire()
    {
        return balance;
    }
    /// <summary>
    /// 存款
    /// </summary>
    /// <param name="deposit"></param>
    /// <returns></returns>
    public double Deposit(double deposit)
    {
        balance += deposit;
        return balance;
    }
    /// <summary>
    /// 取款
    /// </summary>
    /// <param name="withdrawing"></param>
    /// <returns></returns>
    public double Withdrawing(double withdrawing)
    {
        if (balance < withdrawing)
        {
            return 0;
        }
        balance -= withdrawing;
        return balance;
    }
}
}
