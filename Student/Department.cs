using System;

namespace Student{
    public class Department
    {
        public string Dep_name{get;set;}
        public List<Teacher>teachers=new List<Teacher>();


        public void addTeacher(Teacher teacher)
        {
            teachers.Add(teacher);
        }

        public void Display()
        {
            Console.WriteLine($"Department Name : {Dep_name}");

            foreach(var teacher in teachers)
            {
                Console.WriteLine($"Teacher Name :{teacher.name}, TeacherID:{teacher.ID}");
            }
        }
    }
}