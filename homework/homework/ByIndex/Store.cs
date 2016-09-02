using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework.ByIndex
{
    /// <summary>
    /// 网店类
    /// </summary>
class Store
{
    private Member[] member;
    public Store(int size)
    {
        member = new Member[size];
    }
    /// <summary>
    /// 会员索引器
    /// </summary>
    /// <param name="index">索引号</param>
    /// <returns>会员</returns>
    public Member this[int index]
    {
        get { return member[index]; }
        set { member[index] = value; }
    }
    public Member this[string account]
    {
        get {
            foreach(Member item in member){
                if (item.Account == account)
                {
                    return item;
                }
            }
            return null;
        }
        set
        {
            for (int i=0;i<member.Length;i++)
            {
                if (member[i].Account == account)
                {
                    member[i] = value;
                }
            }
        }

    }
}
}
