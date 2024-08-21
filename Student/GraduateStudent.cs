using System;

namespace Student{

    public class GraduateStudent:student
    {
        public override void Study()
        {
            base.Study();
            Console.WriteLine($"Name:{Name}, Age:{age},ID{StudentID} is a graduate");
        }
    }
}