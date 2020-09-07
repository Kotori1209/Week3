using System;
using static System.Console;

namespace Charlie
{
    class Program
    {
        static void Main()
        {

            // Print welcome message
            WriteLine("Welcome to the LCC Computer Club Fundraiser Calculator!");

            // Print final proceeds
            CalculateCentsProfit(GetPricePerBar(), GetCasesSold());

        }

        // Method to get the number of cases sold from the user
        static int GetCasesSold()
        {
            Write("Please enter the number of cases sold: ");
            int casesSold = Convert.ToInt32(Console.ReadLine());
            return casesSold;
        }

        // Method to get the price each bar was sold for from the user
        static int GetPricePerBar()
        {
            Write("Please enter the price per bar in cents: ");
            int barPrice = Convert.ToInt32(Console.ReadLine());
            return barPrice;
        }
        // Method to calculate the final proceeds. Prints output at each step.
        static double CalculateCentsProfit(int barPrice, int casesSold)
        {
            // Set constants
            int barsPerCase = 12;
            int costPerCase = 500;
            double sgaCut = 0.1;
            
            // Calculate gross revenue
            int grossRevenue = casesSold * (barPrice * barsPerCase);

            // Subtract costs
            int netRevenuePreFees = grossRevenue - (casesSold * costPerCase);

            // Subtract SGA fees
            double netRevenuePostFees = netRevenuePreFees - (netRevenuePreFees * sgaCut);

            // Output steps
            WriteLine("{0} cases were sold.", casesSold);
            WriteLine("Each case had {0} bars, which were sold at a price of {1} cents per bar.", barsPerCase, barPrice);
            WriteLine("Total income: {0:C}", grossRevenue / 100);
            WriteLine("Each of the {0} cases cost us {1:C}", casesSold, costPerCase / 100);
            WriteLine("Net income: {0:C}", netRevenuePreFees / 100);
            WriteLine("SGA takes a {0:P} cut of net income", sgaCut);
            WriteLine("Total Proceeds: {0:C}", netRevenuePostFees / 100);

            return netRevenuePostFees;
        }
    }
}
