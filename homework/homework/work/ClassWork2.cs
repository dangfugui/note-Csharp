using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework
{
class ClassWork2
{
    public ClassWork2()
    {
        //MyForeach();
        //BubbleSort();
        MergeArrat();
    }

    public void MyForeach()
    {
        int[] intarr = {9,5,4,2,4,47,6,1,4 };
        foreach (int a in intarr)
        {
            Console.WriteLine(a);
        }
    }

    public void BubbleSort()
    {
        int[] int_arr = {9,6,5,4,1,2,8,7,3,0 };
        for (int a = 0; a < int_arr.Length; a++)
        {
            for (int b = 0; b < int_arr.Length - a-1; b++)
            {
                if (int_arr[b] > int_arr[b + 1])
                {
                    int c = int_arr[b];
                    int_arr[b] = int_arr[b + 1];
                    int_arr[b + 1] = c;
                }
            }
        }
        foreach (int d in int_arr)
        {
            Console.Write(d+"  ");
        }
        Console.WriteLine();
    }
    public void MergeArrat()
    {
        int []arra = new int[] {11,12,13,14,15 };
        int[] arrb = new int[] { 21, 22, 23, 24, 25,26,27 };
        int[] arrc = new int [arra.Length+arrb.Length];
        for (int a = 0; a < arra.Length; a++)
        {
            arrc[a] = arra[a];
        }
        for (int b = 0; b < arrb.Length; b++)
        {
            arrc[arra.Length + b] = arrb[b];
        }
        Console.WriteLine("合并后的一维数组为：");
        foreach (int c in arrc)
        {
            Console.Write(c+"  ");
        }
        int[][] arrarr = new int[2][];
        arrarr[0] = arra;
        arrarr[1] = arrb;
        Console.WriteLine("\n合并后的二维数组为：");
        foreach (int []arr in arrarr)
        {
            foreach (int o in arr)
            {
                Console.Write(o+"  ");
            }
            Console.WriteLine();
        }

    }
}  
}
