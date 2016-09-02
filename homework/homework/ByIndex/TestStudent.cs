using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace homework.ByIndex
{
    class TestStudent
    {
        public TestStudent()
        {
            Student0 stu = new Student0();
            stu.Age = 121;
            stu.name = "dang";
            stu.Introduction();
            Student1 st1 = new Student1("dangqihe",22);
            Student1 st2 = new Student1("dangqihe", 22,"男","计软本");
            st1.Introduction();
            st2.Introduction();

            ClassDemo clas= new ClassDemo();
            Student stu1 = new Student(1, "张三", 375);
            Student stu2 = new Student(2, "李四", 400);
            Student stu3 = new Student(3, "王五", 425);
            Student stu4 = new Student(4, "薛六", 498);
            clas.AddStudent(stu1);
            clas.AddStudent(stu2);
            clas.AddStudent(stu3);
            clas.AddStudent(stu4);
            Console.WriteLine("班级人数"+clas.Count);
            Student student;
            for (int i = 0; i < clas.Count; i++)
            {
                student=clas[i];
                student.Introduction();
            }
            Console.WriteLine("第2个人的总分" + clas[2].score);
            Console.WriteLine("李四的总分" + clas["李四"].score);
        }
    }
}
