using System;

namespace ch04_factorial_calculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Factorial Calculator!");
            String choice = "y";
            while (choice.Equals("y")) {
                Console.WriteLine("\nEnter an integer that's greater than 0 and less than 21: ");
                int num = Int32.Parse(Console.ReadLine());
                long factorial = 1;
                for (int i = 1; i <= num; i++) {
                    factorial *= i;
                }
                Console.WriteLine("The factorial of " + num + " is " + factorial);
                Console.WriteLine("Continue? (y/n) ");
                choice = Console.ReadLine();

            }
            Console.WriteLine("Bye now :) ");

        }
    }
}
