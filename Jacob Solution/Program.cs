#region About this program

/*Group
 * Group Number: Group #1
 * Group Members: Jacob B, Charles B, Tyler D, Bozhou C, Cyrus C
 */


/*Info
 * Programmer: Jacob Brookhouse
 * Date: 09/07/2020
 * Purpose: Console app that calculates granola bar sales for the computer club.
 *          Calculates how many are sold and sold for, percentage of sales to 
 *          government association, and total profit. Let's user enter 
 *          ammount sold and for how much.
 *          
 * Class: CITP 180
 * Assignment: Chapter 3 - Programming Excercise 8
 */

#endregion

using System;
using static System.Console;

namespace Jacob_Solution
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declare main variables
            int casesSold;
            double pricePerBar;
            double profits;
            double proceeds;
            double totalIncome;

            // Create new WelcomeWriter, used to dispaly instructions
            WelcomeWriter Instructions = new WelcomeWriter();

            // Display the instructions
            Write(Instructions);

            // Pause so it does not call for you to enter values
            ReadLine();

            // Call methds and return their values 
            casesSold = GetCasesSold();
            pricePerBar = GetPricePerCase();
            profits = GetProfit(casesSold, pricePerBar);
            proceeds = GetProceeds(profits);
            totalIncome = GetTotal(proceeds, profits);

            // Output
            WriteLine("Cases Sold: " + casesSold);
            WriteLine("Price Per Bar: {0:C}", pricePerBar);
            WriteLine("Income(Gross): {0:C}", profits);
            WriteLine("SGA Fee(10%): {0:C}", proceeds);
            WriteLine("Total Income: {0:C}", totalIncome);

            // Pause so you can read output
            ReadLine();
        }

        // Method that gets number of cases sold
        public static int GetCasesSold()
        {
            // Return ammount of sold cases
            int cSold;
            WriteLine("Enter cases sold: ");
            cSold = int.Parse(Console.ReadLine());
            WriteLine(Environment.NewLine);
            return cSold;
        }

        // Method that gets the price per case
        public static double GetPricePerCase()
        {
            // Return price per bar by entered value
            double perBar;
            WriteLine("Enter the price per bar: ");
            perBar = double.Parse(Console.ReadLine());
            WriteLine(Environment.NewLine);
            return perBar;
        }

        // Method that gets the profit
        public static double GetProfit(int casesSold, double pricePerBar)
        {
            // Return profit by making it equal to $5/case, multiply by how many bars a case
            // Then minus case price multiplied by sold cases
            const double CASE_PRICE = 5.00;
            double profit;
            profit = ((pricePerBar * 12) - CASE_PRICE) * casesSold;
            return profit;
        }

        // Method that gets the proceedes
        public static double GetProceeds(double profit)
        {
            // Return proceeds by making it equal to the 10% then multiply the profit
            const double STU_GOV_FEES = .10;
            return (profit * STU_GOV_FEES);
        }

        // Method that gets total after proceeds
        public static double GetTotal(double proceeds, double profit)
        {
            // Return total by subtracting proceeds from profit
            return (profit - proceeds);
        }
       
    }

    // Wrote class that is used to just disply instructions
    class WelcomeWriter
    {
        public override string ToString()
        {
            // The instructions/info
            return Environment.NewLine + "Welcome to our app that will calculate your sales for the Computer Club" + Environment.NewLine +
                "Please enter your sales values, cases sold and bar price on the next screen!" + Environment.NewLine +
                "To continue press 'enter'" +
                Environment.NewLine;
        }
    }
}
