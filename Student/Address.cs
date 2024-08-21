using System;

namespace Student{
    public class Address
    {
        public string city{get;set;}
        public string street{get;set;}

        public Address(string city,string street)
        {
             this.city=city;
             this.street=street;
        }
    }
}