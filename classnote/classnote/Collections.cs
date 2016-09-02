using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace classnote
{//必须引using System.Collections;
class Collections
{
    /// <summary>
    ///数组
    /// </summary>
    public void myarrayList()
    {
        Console.WriteLine("++++++++++++++++++++Collections->ArrayList() start++++++++++++++++++++");
        ArrayList aList = new ArrayList();
        ArrayList aList2 = new ArrayList();
        for (int i = 0; i < 10; i++)
        {
            aList.Add(i);           //添加  返回索引值
        }
        foreach (int a in aList)
        {
            Console.Write(a + " ");
        }
        aList.Insert(5,55555);      //把55555插入到第五个位置
        Console.WriteLine();
        foreach (int a in aList)
        {
            Console.Write(a + " ");
        }
        aList.Remove(2);            //移除内容为2 的元素
        aList.RemoveAt(0);          //移除在0位置 的元素
        aList.Sort();               //排序
        aList.Reverse();            //反转顺序
        Console.WriteLine();
        Object[] obj = aList.ToArray();
        for (int a = 0; a < obj.Length;a++ )
        {
            Console.Write(obj[a] + " ");
        }
        Console.WriteLine("\n--------------------Collections->ArrayList() end----------------------");
        
    }
    /// <summary>
    /// 哈希数组
    /// </summary>
    public void myHashtable()
    {
        Console.WriteLine("++++++++++++++++++++Collections->hashtable() start++++++++++++++++++++");
        Hashtable hash = new Hashtable();
        hash.Add("name","dangqihe");        //添加元素
        hash.Add("id", 201311020103);
        hash.Add("age", 23);
        hash.Remove("age");                 //移除元素
        foreach (DictionaryEntry entry in hash)     //遍历元素
        {
            Console.WriteLine(entry.Key+"--"+entry.Value);
        }
        Console.WriteLine("--------------------Collections->hashtable() end----------------------");
    }
    /// <summary>
    /// 栈  先入后出
    /// </summary>
    public void myStack()
    {
        Stack stack = new Stack();
        stack.Push("111");          //压栈
        stack.Push("222");  
        stack.Push("333");
        Console.WriteLine(stack.Pop()); //出栈
        Console.WriteLine(stack.Peek());//获取栈顶值
        Console.WriteLine("--------------------Collections->() end----------------------");
    }
    

    /// <summary>
    /// 队列  先入先出
    /// </summary>
    public void myQueue()
    {
        Queue queue = new Queue();
        queue.Enqueue("111");       //入队
        queue.Enqueue("222");
        queue.Enqueue("333");
        Console.WriteLine(queue.Dequeue()); //出队
        Console.WriteLine(queue.Peek());    //查询队头
    }
    /// <summary>
    /// List数组
    /// </summary>
    public void myList()
    {
        List<int> arr=new List<int>();
        arr.Add(1);
        int[] a = {2,3,4,5};
        arr.AddRange(a);
        Console.WriteLine(arr.Count);           //返回数组大小
        Console.WriteLine(arr.IndexOf(3));      //查找
    }
    /// <summary>
    /// 泛型 哈希数组
    /// </summary>
    public void myDictionary()
    {
        Dictionary<string, string> dic = new Dictionary<string, string>();
        dic.Add("name", "dangqihe");
        dic.Add("sax", "男");
        //dic.ElementAt(1).
        Console.WriteLine(dic["name"]);
    }
    /// <summary>
    /// 泛型 栈
    /// </summary>
    public void myStack2()
    {
        Stack<int> sta=new Stack<int>();
        sta.Push(2);        //进栈
        sta.Push(4);        
        sta.Peek();     //查栈
        sta.Pop();      //出栈
    }
    /// <summary>
    ///泛型 队列
    /// </summary>
    public void myQueue2()
    {
        Queue <int> sta =new Queue<int>();
        sta.Enqueue(4);     //进队
        sta.Enqueue(45);
        sta.Peek();     //查队
        sta.Dequeue();    //出队
        
    }
}
}
