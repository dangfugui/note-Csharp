using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework.ByException
{
    class ExceptionTest1
    {
        public bool isRun = true;

        public void test()
        {
            try
            {
                Console.WriteLine(1);
                if (1 == 1)
                {
                    throw new Exception("1234异常");
                }
                Console.WriteLine(2);
            }
            catch (Exception e)
            {
                Console.WriteLine(3);
                Console.WriteLine(e.Message);//1234异常
            }
            finally
            {
                Console.WriteLine(4);
            }
            Console.WriteLine(5);
        }

        public void test2()
        {
            try
            {
                int[] arr = { 1, 2, 3, 4, 5 };
                Console.WriteLine(arr[5]);
            }
            catch(Exception e)
            {
                Console.WriteLine("异常信息>>>>>"+e.Message);
                Console.WriteLine("异常e.GetType>>>>>" + e.GetType());
            }
        }
        public void overflowtest()
        {
            try
            {
                run();
            }
            catch (OverflowException e)
            {
                isRun = false;
                Console.WriteLine("异常信息>>>>>" + e.Message);
                Console.WriteLine("异常e.GetType>>>>>" + e.GetType());
            }
        }
        public void run()
        {
            try
            {
                if (isRun)
                {
                    run();
                }
            }
            catch (OverflowException e)
            {
                isRun = false;
                throw e;
            }
        }
    }
}
