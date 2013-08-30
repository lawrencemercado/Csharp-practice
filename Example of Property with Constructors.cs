using System.IO;
using System;

class MainStudent
{
    public MainStudent(int x, string name)
    {
        StudentNo = x;
        StudentName = name;
    }  
    public int StudentNo
    {
        get; set;
        
    }
    public string StudentName
    {
        get; set;
    }
    static void Main()
    {

    MainStudent stud = new MainStudent(12345, "lawrence");
    //stud.StudentNo = 12345;
   // stud.StudentName = "lawrence";
    Console.WriteLine("Student number : {0}", stud.StudentNo);
    Console.WriteLine("Student name : {0}", stud.StudentName);
    }
}