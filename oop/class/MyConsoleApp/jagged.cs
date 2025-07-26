using System;

public class JaggedArray
{
    public void Display()
    {
        // Creating a jagged array for theater seating
        string[][] seats = new string[4][];

        seats[0] = new string[] { "A1", "A2", "A3", "A4" };
        seats[1] = new string[] { "B1", "B2", "B3", "B4", "B5" };
        seats[2] = new string[] { "C1", "C2" };
        seats[3] = new string[] { "D1", "D2", "D3" };

        // Displaying the seating
        for (int i = 0; i < seats.Length; i++)
        {
            for (int j = 0; j < seats[i].Length; j++)
            {
                Console.Write(seats[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}
