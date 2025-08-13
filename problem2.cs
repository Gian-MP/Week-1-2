using System;

public class Problem2
{
    public static void Main(string[] args)
    {
        int number = Convert.ToInt32(Console.ReadLine());
        if (number > 0){
            Console.WriteLine("The number " + number + " is positive");
        }
            else{
                Console.WriteLine("The number " + number + " is negative");
            }
        
    }
}
