using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework.ByExtends
{
    class Animal
    {
        public string type;
        public virtual void Eat(string food)
        {
            Console.WriteLine("动物开始吃"+food);
        }

    }
    class Lion:Animal
    {
        public Lion(){
             type = "狮子";
        }
        public override void Eat(string food)
        {
            Console.WriteLine("狮子开始吃"+food);
        }
    }
    class Monkey : Animal
    {
        public Monkey()
        {
            type = "猴子";
        }
        public override void Eat(string food)
        {
            Console.WriteLine("猴子开始吃" + food);
        }
    }
    class Pigeon : Animal
    {
        public Pigeon()
        {
            type = "鸽子";
        }

        public override void Eat(string food)
        {
            Console.WriteLine("鸽子开始吃" + food);
        }
    }
    class Feeder
    {
        public Lion lion = new Lion();
        public Monkey monkey =new Monkey();
        public Pigeon pigeon = new Pigeon();
        public void feeding(Animal animal,string food)
        {
            Console.WriteLine("动物园管理员开始饲养"+animal.type);
            animal.Eat(food);
        }
    }
    class AnimalTest
    {
        public Lion lion = new Lion();
        public Monkey monkey = new Monkey();
        public Pigeon pigeon = new Pigeon();
        Feeder feeder = new Feeder();
        public AnimalTest()
        {
            feeder.feeding(lion,"肉");
            feeder.feeding(monkey,"香蕉");
            feeder.feeding(pigeon,"米粒");
        }
    }
}
