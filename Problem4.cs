using System;

public class Problem2
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter a grade");
        string Grade = Console.ReadLine();
        int intGrade = int.Parse(Grade);
        string result = (intGrade > 49) ? "Passed" : "Failed";
        Console.WriteLine(result);
        
        
    }
}
