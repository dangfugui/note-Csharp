using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace classnote.myClass
{
    /// <summary>
    /// 运输接口
    /// </summary>
    public interface Transportation
    {
        /// <summary>
        /// 计算运费
        /// </summary>
        double compute();
    }
    /// <summary>
    /// 卡车
    /// </summary>
    class Truck : Transportation
    {
        // 重量
        public double weight;
        // 运输里程
        public double mileage;
        // 运费
        public double expense;
        public Truck(double weight,double mileage)
        {
            this.weight = weight;
            this.mileage = mileage;
        }
        // 计算运费
        public double compute()
        {
            if (weight > 60)
            {
                return -1;
            }
            expense = weight * mileage * 120;
            return expense;
        }
    }
    class Train : Transportation
    {
        // 重量
        public double weight;
        // 运输里程
        public double mileage;
        // 运费
        public double expense;
        public Train(double weight, double mileage)
        {
            this.weight = weight;
            this.mileage = mileage;
        }
        // 计算运费
        public double compute()
        {
            if (mileage <= 900)
            {
                expense = weight * mileage * 250;
            }
            else if (mileage > 900)
            {
                expense = weight * mileage * 300;
            }
            return expense;
        }
    }

    class Aircraft : Transportation
    {
        // 重量
        public double weight;
        // 运输里程
        public double mileage;
        // 运费
        public double expense;
        public Aircraft(double weight, double mileage)
        {
            this.weight = weight;
            this.mileage = mileage;
        }
        // 计算运费
        public double compute()
        {
            if (mileage > 500)
            {
                expense = weight * mileage * 750;
            }
            else
            {
                return -1;
            }
            return expense;
        }
    }

    class TransportationTest
    {
        // 重量
        public double weight;
        // 运输里程
        public double mileage;
        public TransportationTest()
        {
            Console.WriteLine("请输入货物重量");
            weight = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入运输里程");
            mileage = double.Parse(Console.ReadLine());
            Console.WriteLine("请输入运输方式:\t1.卡车\t2.火车\t3.飞机");
            string tran = Console.ReadLine();
            switch (tran)
            {
                case "1":
                    {
                        Transportation truck = new Truck(weight,mileage);
                        Console.WriteLine("运费是：" + truck.compute());
                        break;
                    }
                case "2":
                    {
                        Transportation train = new Train(weight, mileage);
                        Console.WriteLine("运费是：" + train.compute());
                        break;
                    }
                case "3":
                    {
                        Transportation aircraft = new Aircraft(weight, mileage);
                        Console.WriteLine("运费是：" + aircraft.compute());
                        break;
                    }
            }

        }
    }

}
