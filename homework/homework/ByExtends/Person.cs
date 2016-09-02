using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework.ByExtends
{
    class Person
    {
        public string name;
        public int age;
        public string toString()
        {
            string res = "";
            res += "name:" + name;
            res += "\nage:" + age;
            return res;
        }
    }
    class Student : Person
    {
        public int sId;
        public string sClass;
        public string sSchool;
        public Student(int id, string name, int age, string clss, string school)
        {
            base.name = name;
            base.age = age;
            sId = id;
            sClass = clss;
            sSchool = school;
        }
        public string Study()
        {
            string res = "";
            res += "School:" + sSchool;
            res += "\tClass:" + sClass;
            res += "\tId:" + sId;
            res += "\tname:" + name;
            res += "\tage:" + age;
            res += "\n学习不错";
            return res;
        }
    }
    class PersonTest
    {
        public PersonTest()
        {
            Student stu = new Student(3,"党启贺",22,"山师","山东公路技师学院");
            
            Console.WriteLine( stu.Study());
        }
    }
}
