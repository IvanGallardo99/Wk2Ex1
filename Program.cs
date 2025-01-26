using System;
   
namespace Wk2Ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Loan Interest Calculator\n");

            // Enter Loan amount
            Console.Write("Enter the loan amount: $ ");
                 t.ToDouble(Console.ReadLine());

            // Enter Annual interest rate
            Console.Write("Enter the annual interest rate (in %): ");
            double annualInterestRate = Convert.ToDouble(Console.ReadLine()) / 100;

            // Enter Loan term in years
            Console.Write("Enter the loan term (in years): ");
            int loanTermYears = Convert.ToInt32(Console.ReadLine());

            // Calculate total interest
            double totalInterest = loanAmount * annualInterestRate * loanTermYears;

            // Calculate total payment
            double totalPayment = loanAmount + totalInterest;

            // Output the results
            Console.WriteLine("\n--- Loan Details ---");
            Console.WriteLine($"Loan Amount:          $ {loanAmount:F2}");
            Console.WriteLine($"Annual Interest Rate: {annualInterestRate * 100:F2} %");
            Console.WriteLine($"Loan Term:            {loanTermYears} years");
            Console.WriteLine($"Total Interest:       $ {totalInterest:F2}");
            Console.WriteLine($"Total Payment:        $ {totalPayment:F2}");

            Console.WriteLine("\nPress any key to exit.");
            Console.ReadKey();
        }
    }
}
