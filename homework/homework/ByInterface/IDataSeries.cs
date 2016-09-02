using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework.ByInterface
{
    public interface IDataSeries
    {
        int GetNext();    //返回下一个系列数字
        void Reset();      //重新开始
        void SetInit(int i);  //设置系列数字的开始值
    }
    class FiveSeries:IDataSeries
    {
        int num = 0;
        public int GetNext()
        {
            num += 5;
            return num;
        }
        public void SetInit(int i)
        {
            num = i;
        }
        public void Reset()
        {
            num = 0;
        }
    }
    class IdDateSeriesTest{
        public IdDateSeriesTest()
        {
            FiveSeries five = new FiveSeries();
            five.SetInit(10);
            Console.WriteLine("下一个系列数字："+five.GetNext());
        }
    }
}
