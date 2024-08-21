using System;

namespace Student
{
    public class Bike:IDriveable
    {
        public void runsOn()
        {
            Console.WriteLine("Bike has two wheels");
        }
    }
}