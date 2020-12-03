using System;

namespace ch04_04_common_divisor_calculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Greatest Common Divisor Finder!");
            String choice = "y";
            while (choice.Equals("y") || (choice.Equals("Y"))) {
                Console.WriteLine("Enter first number: ");
                int firstNumber = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second number: ");
                int secondNumber = int.Parse(Console.ReadLine());

                int gCD = CalculateGreatestCommonDivisor(firstNumber, secondNumber);
                Console.WriteLine("Greatest common divisor " + gCD);

                Console.WriteLine("Continue? (y/n)");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Bye now :)");
        }
        public static int CalculateGreatestCommonDivisor(int x, int y) {
            while (x != 0) {
                while (y >= x) {
                    y = y - x;
                }
                int tmp = x;
                x = y;
                y = tmp;
            }
            return y;
        }
    }
}
