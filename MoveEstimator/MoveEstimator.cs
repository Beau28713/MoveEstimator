/*
 Write a program named MoveEstimator that prompts a
user for and accepts estimates for the number of 
hours for a job and the number of miles involved 
in the move and displays the total moving fee.
 */
using System;
using static System.Console;
using System.Globalization;
class MoveEstimator
{
    static void Main()
    {
        Console.WriteLine("Malcolm Movers charges a base rate of $200 per move plus $150 per hour and $2 per mile.");

        Console.WriteLine("Please enter the estimated milage for the move");

        string miles = Console.ReadLine();

        Console.WriteLine("Please enter the estimated time of the move in hours.");

        string hours = Console.ReadLine();

        Console.WriteLine("You have specified there is {0} miles and {1} hours in this move.", miles, hours);

        double totalPrice = 200 + ((Convert.ToInt32(miles) * 2) + (Convert.ToInt32(hours) * 150));

        WriteLine("Total: : {0}", totalPrice.ToString("C", CultureInfo.GetCultureInfo("en-US")));

    }
}
