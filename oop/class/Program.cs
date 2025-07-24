
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
        Console.WriteLine($"{Name}'s Department changed to: {newDepartment}");
    }
}


class Program
{
    static void Main()
    {
        Teacher teacher1 = new Teacher();

        teacher1.Name = "Aparajita Nepal";
        teacher1.idNo = 50;  

        teacher1.changeDep();
    }
}
