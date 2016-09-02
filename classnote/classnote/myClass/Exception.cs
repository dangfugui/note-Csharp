using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classnote.myClass
{
    class ExceptionTest
    {
        public ExceptionTest()
        {
            test();
        }

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
    }
}
