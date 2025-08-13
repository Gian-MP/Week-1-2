using System;

public class Problem3
{
    public static void Main(string[] args)
    {
        Console.WriteLine("Enter your age: ");
        string Age = Console.ReadLine();
        int intAge = int.Parse(Age);
        Console.WriteLine("Enter your Income: ");
        string Income = Console.ReadLine();
        int intIncome = int.Parse(Income);
        
        if (intAge > 24 && intAge <36 && intIncome > 49999){
            Console.WriteLine("You are a young professional");
        }
        else if (intAge > 35 && intAge <56 && intIncome > 69999){
            Console.WriteLine("You are a Middle-Aged professional");
        }
        
        else if (intAge > 56 && intIncome < 30000){
            Console.WriteLine("You are a Senior Citizen");
        }
        
        else{
            Console.WriteLine("Others");
        }
    }
}
