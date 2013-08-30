using System.IO;
using System;
class MainStudent
{
    public static void Main()
    {
        Student s = new Student();
        
        s.StudNo = 200914580;
        s.StudName = "Lawrence Mercado";
        Console.WriteLine("Student No: {0}",s.StudNo);
        Console.WriteLine("Student Name: {0}", s.StudName);
    }
}

using System;

public class Student
{
    
public int StudNo
{
    get;
    set;
    
}

public string StudName
{
    get;
    set;
}
      
    
}


