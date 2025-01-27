using System;

namespace Wk2Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Interest Calculator Program\n");

            // Enter Loan amount
            Console.Write("What is the principle amount of the loan in dollars?: $ ");
            double loanAmount = Convert.ToDouble(Console.ReadLine()); // Fixed the variable definition

            // Enter Annual interest rate
            Console.Write("What is the interest rate (input 0.85 for 5%)? : ");
            double annualInterestRate = Convert.ToDouble(Console.ReadLine()) / 100;

            // Enter Loan term in years
            Console.Write("What is the period of loan in years? (in years): ");
            int loanTermYears = Convert.ToInt32(Console.ReadLine());

            // Calculate total interest
            double totalInterest = loanAmount * annualInterestRate * loanTermYears;

            // Output the results
            Console.WriteLine($"Total Interest of Loan: $ {totalInterest:F2}");

            Console.ReadKey();
        }
    }
}
