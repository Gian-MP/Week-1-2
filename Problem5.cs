using System;

public class Problem
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Input ['A'] to calculate a circle's area, ['P' or 'p'] to calculate a circles Circumference and ['X' or 'x'] to end the program");
        string choice = Console.ReadLine();
        
        switch(choice){
            case "A":
                Console.WriteLine("Enter the radius");
                string Radius = Console.ReadLine();
                int intRadius = int.Parse(Radius);
                double Area = 3.14 * intRadius * intRadius;
                Console.WriteLine("The area of your circle is " + Area);
                break;
                
            case "P":
                Console.WriteLine("Enter the radius");
                string Radius2 = Console.ReadLine();
                int intRadius2 = int.Parse(Radius2);
                double Circumference = 2 * 3.14 * intRadius2;
                Console.WriteLine("The Circumference of your circle is " + Circumference);
                break;
            
            case "X":
                Console.WriteLine("Thank you for using our program");
                break;
        }
    }
}
