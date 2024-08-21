using System;

namespace Student
{
    public class Person
    {
    public string Name{get;set;}
    protected int age ;

    public List<Address>address=new List<Address>();


     public int BirthYear{get;set;}


     public virtual  void Display()
   {
    Console.WriteLine($"Name : {Name} ,Age :{age}");
    foreach(var addr in address)
    {
      Console.WriteLine(addr.city+" "+addr.street);
    }
   }

  public void setAge(int age)
  {
    if(age>=0)
    {
        this.age=age;
        //Display();
    }else{
        Console.WriteLine("Age can't be below 0");
      
    }
  }

  public int getAge()
  {
    return age;
  }


  public void CalculateAge()

  {
   
      var currentDate=DateTime.Today;
      if(currentDate<new DateTime(BirthYear,1,1))
      {
             Console.WriteLine("Birth day can't be in the future");
          
      }else{
   Console.WriteLine((currentDate-new DateTime(BirthYear,1,1)).TotalDays/365) ;
      }
    
  }

public void addAddress(Address addresses)
{
address.Add(addresses);
}
    }
   
   

}