// See https://aka.ms/new-console-template for more information
using System;


namespace Student
{
    public class Program
    {
        public static void Main(String[]args)
        {
        //     Person person=new Person(){Name="ABC"};
        //    person.Name="ABC";
           //person.age=25;
        //     person.setAge(20);
        //     person.addAddress(new Address("Jaffna","KKS"));
        //     person.addAddress(new Address("Batticalo","Town"));
        //    person.Display();

        //   student stu=new student(){Name="SGK",StudentID=1190};
        //    stu.setAge(26);
        //    stu.EnrollCourse(new Course("Maths"));
        //    stu.EnrollCourse(new Course("Science"));
        //    stu.Display();
        //   stu.calculateDOB(1997);
        //   stu.calculateDOB("ABC",1997);

        //   GraduateStudent grad=new GraduateStudent(){Name="Stark",StudentID=01180};
        //   grad.setAge(27);

        //   Circle circle=new Circle(){Radius=20};
        //   circle.CalculateArea();

        //   Rectangle rect=new Rectangle(){length=10,width=20};
        //   rect.CalculateArea();

        // Car car=new Car();
        // car.runsOn();

        // Bike bike=new Bike();
        // bike.runsOn();

        // Person stu_1=new Person(){BirthYear=2997};
        // stu_1.CalculateAge();


        Department dep=new Department(){Dep_name="CSE"};
        dep.addTeacher(new Teacher("RRR",1));
        dep.addTeacher(new Teacher("AAA",2));
        dep.Display();
        }
    }
    
}