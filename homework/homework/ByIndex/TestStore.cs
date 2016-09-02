using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework.ByIndex
{
class TestStore
{
    public TestStore()
    {
        Member mem0 = new Member("da0",0);
        Member mem1 = new Member("da1", 1000);
        Member mem2 = new Member("da2", 2000);
        Store store = new Store(5);
        store[0] = mem0;
        store[1] = mem1;
        store[2] = mem2;
        Console.WriteLine(store["da1"].Balance);
        mem2.Balance = -15;
        store[2] = mem2;
        Console.WriteLine(store[2].Balance);

    }
}
}
