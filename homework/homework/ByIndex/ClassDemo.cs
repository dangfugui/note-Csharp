using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework.ByIndex
{
    class ClassDemo
    {
        private int count;

        public int Count
        {
            get { return count; }
        }
        List<Student> students=new List<Student>();
        public void AddStudent(Student student){
            students.Add(student);
            count++;
        }
        public Student this[int index]
        {
            get { return students.ElementAt(index); }
    
        }
        public Student this[string name]
        {
            get
            {
                foreach (Student stu in students)
                {
                    if (stu.name == name)
                    {
                        return stu;
                    }
                }
                return null;
            }

        }
    }
    class Student
    {
        public long sid;
        public string name;
        public double score;
        public Student(long sid, string name, double score)
        {
            this.sid = sid;
            this.name = name;
            this.score = score;
        }
         public void Introduction()
        {
            Console.WriteLine("学号：" + sid + "\t姓名：" + name + "\t总分：" + score );
        }
    }
}
