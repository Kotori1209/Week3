// CITP-180 Week 3 Group Exercise
// Programmer: Bozhou Chen
// Date: 9/10/2020
// Purpose: Computes the amount of money
//          the computer club will receive
//          from proceeds of their granola bar sales project.
using System;
using static System.Console;

namespace Wk3GroupExBC
{
    public class ProfitCalculator
    {
        public static void Main(string[] args)
        {
            double profits;
            DisplayInstructions();
            profits = ComputeMoney();
            DisplayResults(profits);
            ReadKey();
        }  // end of Main()

        public static void DisplayInstructions()
        {
            WriteLine("A case, contains 12 bars, is purchased at a price of $5.00.");
            WriteLine("Your club is also required to give the student government association " +
                      "10% of your earnings.");
            WriteLine();
            WriteLine("Input the number of cases sold and the sale price per bar, then");
            WriteLine("This program will calculate the amount of money your club will receive.");
            WriteLine();
            return;
        }
        public static double ComputeMoney()
        {
            string inputValue;
            int caseNum;
            double salePrice;
            Write("Please enter the number of cases sold: ");
            inputValue = ReadLine();
            caseNum = int.Parse(inputValue);
            Write("Please enter the sale price per bar: $");
            inputValue = ReadLine();
            salePrice = double.Parse(inputValue);

            return (12 * salePrice * (double)caseNum - 5 * (double)caseNum);
        }
        public static void DisplayResults(double profits)
        {
            WriteLine();
            Write("The gross profit before student goverment association is ");
            WriteLine("{0:C}", profits);
            Write("The net profit of your club is: ");
            WriteLine("{0:C}", 0.9 * profits);
            return;
        }
    }  // end of class
}  // end of namespace
