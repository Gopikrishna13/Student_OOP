using System;
namespace Student{
public class Circle:Shape{

    public double Radius{get;set;}
        public override void CalculateArea()
        {
           
            Console.WriteLine($"Area of circle is :{Math.PI*Radius*Radius}");
        }
    }
}
