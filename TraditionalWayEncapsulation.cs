using System.IO;
using System;

class MainStudent
{
    static void Main()
    {
      Student s = new Student();
      s.setSname("Lawrence Christopher J. Mercado");
      s.setSno(2009014580);
      Console.WriteLine("Student Number: {0}", s.getSno());
      Console.WriteLine("Student Name: {0}", s.getSname())  ;   
    }
}

using System;

public class Student
{
    
    private int sno = -1;
    public void setSno(int StudNo)
    {
        sno = StudNo;      
    }
    public int getSno()
    { 
        return sno;
    }
    
    private string sname = "";
    
    public void setSname(string StudName)
    {
        sname = StudName;
    }
    
    public string getSname()
    {
        return sname;
    }
}