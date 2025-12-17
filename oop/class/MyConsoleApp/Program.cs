using System;


public class Teacher
{
    public string Name;
    public int idNo;
    public int Age;

    public void changeDep()
    {
        Console.WriteLine("Enter the new department name:");
        string newDepartment = Console.ReadLine();
        Console.WriteLine($"{Name}'s Department changed to:{newDepartment}");
    }
}


class Program
{
    static void Main()
    {

        JaggedArray demo = new JaggedArray();
        demo.Display();

        Console.WriteLine("Enter Array size:");
        int n = int.Parse(Console.ReadLine());
        string[] courses = new string[n];
        //reading array
        for (int i = 0; i < courses.Length; i++)
        {
            Console.WriteLine("Enter course name:");
            courses[i] = Console.ReadLine();
        }

        //printing the values
        for (int i = 0; i < courses.Length; i++)
        {
            Console.WriteLine($"Course {i + 1}: {courses[i]}");
        }
        //printing using foreach--use only for printing 
        foreach (string course in courses)
        {
            Console.WriteLine($"Course: {course}");
        }

        Teacher teacher1 = new Teacher();

        teacher1.Name = "Sagar KC";
        teacher1.idNo = 50;

        teacher1.changeDep();
    }
}
