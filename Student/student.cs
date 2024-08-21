using System;

namespace Student{

    public  class student : Person
    {
        public int StudentID{get;set;}

        public List<Course>courses=new List<Course>();

        public void calculateDOB(int year)
        {
              Console.WriteLine(2024-year);
        }

        public void calculateDOB(String name,int year)
        {
            Console.WriteLine($"{name},{year}");
        }

        public override void Display()
        {
            base.Display();//Display the output from the base class
            Console.WriteLine($"Name:{Name}, Age:{age},ID:{StudentID}");
            foreach(var course in courses)
            {
                   Console.WriteLine(course.courseName);
            }
        }

        public virtual void  Study()
        {
          Console.WriteLine($"Name:{Name}, Age:{age},ID{StudentID} is still studying");
        }


        public void EnrollCourse(Course course)
        {
               courses.Add(course);
        }
    }
}