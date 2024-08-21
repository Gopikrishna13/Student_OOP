using System;

namespace Student{
    public class Teacher{
        public string name{get;set;}
        public int ID{get;set;}


        public Teacher(string name,int id)
        {
            this.name=name;
            ID=id;
        }
    }
}