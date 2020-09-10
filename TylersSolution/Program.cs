using System;
using static System.Console;

namespace TylersSolution
{
    class Program
    {
        private const string softwareName = "CITP - Computer Club Granola Sales Calculator";

        private const int barsPerCase = 12;
        private const float costPerCase = 5.00f;
        private const float studentGovtTax = 0.1f;

        private void Initialize()
        {
            DisplayInstructions();

            int casesSold = GetCasesSold();
            float pricePerBar = GetPricePerBar();
            float earnedTotal = ComputeProceeds(casesSold, pricePerBar);

            // I know named variables aren't necessary but it was in the chapter so I wanted to include it.
            DisplayResults(
                earnedTotal: earnedTotal, 
                casesSold: casesSold, 
                pricePerBar: pricePerBar);
        }

        /// <summary>
        /// Displays results of the computation and user input.
        /// </summary>
        private void DisplayResults(int casesSold, float pricePerBar, float earnedTotal)
        {
            WriteLine($"The total number of cases sold was: {casesSold}");
            WriteLine($"The price per granola bar was: ${pricePerBar}");
            WriteLine($"After taxes, the computer club received ${earnedTotal:F2} in proceeds.");
            WriteLine();
            WriteLine("Press any key to exit...");

            ReadKey();
        }

        /// <summary>
        /// Compute the proceeds of the computer club.
        /// </summary>
        /// <param name="casesSold"></param>
        /// <param name="pricePerBar"></param>
        /// <returns></returns>
        private float ComputeProceeds(int casesSold, float pricePerBar)
        {
            WriteLine();

            // Calculate how much money was raised total.
            float totalProceedsRaised = casesSold * (pricePerBar * barsPerCase);

            // Calcuate how much money was raised after the cost of the cases.
            float totalProceedsBeforeTax = totalProceedsRaised - (casesSold * costPerCase);

            // Return the calculated total proceeds after tax.
            return totalProceedsBeforeTax - (totalProceedsBeforeTax * studentGovtTax);
        }

        /// <summary>
        /// Fetch the price/granola bar from the user.
        /// </summary>
        /// <returns></returns>
        private float GetPricePerBar()
        {
            Write("Enter the price/granola bar: ");
            return Convert.ToSingle(ReadLine());
        }

        /// <summary>
        /// Fetch the number of cases sold by the user.
        /// </summary>
        /// <returns></returns>
        private int GetCasesSold()
        {
            Write("Enter the number of cases sold: ");
            return Convert.ToInt32(ReadLine());
        }

        /// <summary>
        /// Display instruuctions to the user and a summary about the program.
        /// </summary>
        private void DisplayInstructions()
        {
            WriteLine($"Thanks for using the {softwareName}!");
            WriteLine("When prompted, please enter the value necessary. Please press the Enter key when you're ready.");
            WriteLine();

            ReadLine();
        }

        static void Main(string[] args) => new Program().Initialize();
    }
}
