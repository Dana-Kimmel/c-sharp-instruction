using System;
namespace ch03_03_interest_calculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Interest Calculator!");
            String choice = "y";
            while (choice.Equals("y")) {
                Console.WriteLine("Enter loan amount: ");
                double loanAmount = Double.Parse(Console.ReadLine());
                Console.WriteLine("Enter interest rate: ");
                double interestRate = Double.Parse(Console.ReadLine());
                double interest = loanAmount * interestRate;
                double interestRounded = Math.Round(interest, 2);
                Console.WriteLine("Loan amount: " + loanAmount.ToString("C"));
                Console.WriteLine("Interest rate: " + interestRate.ToString("P"));
                Console.WriteLine("Interest: " + interestRounded.ToString("C"));
                Console.WriteLine("Continue? (y/n)");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Bye now :)");
        }
    }
}
    