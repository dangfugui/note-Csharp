using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework.ByIndex
{
    class Student0
    {
        public string name;
        private int age;
        public int Age
        {
            get { return age; }
            set { if (value >= 16) { age = value; } else { Console.WriteLine("年龄不能小于16"); } }
        }

        public void Introduction(){
            Console.WriteLine("姓名：" + name + "\t年龄：" + age);
        }

    }
    class Student1
    {
        public string name;
        public int age;
        public string sex;
        public string major;
        public Student1(string name,int age)
        {
            this.name = name;
            this.age = age;
            sex = "男";
            major = "计算机";
        }
        public Student1(string name, int age, string sex, string major)
        {
            this.name = name;
            this.age = age;
            this.sex = sex;
            this.major = major;
        }
        public void Introduction()
        {
            Console.WriteLine("姓名：" + name + "\t年龄：" + age + "\t性别：" + sex + "\t专业：" + major);
        }
    }
}
