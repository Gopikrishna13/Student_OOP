using System;

namespace Student{
    public class Rectangle : Shape{

       public double length{get;set;}
       public double width{get;set;}

        public override void CalculateArea()
        {
            Console.WriteLine($"Area of Rectangle : {length*width}");
        }
    }
}