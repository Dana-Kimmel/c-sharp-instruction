using System;

namespace ch04_table_of_powers {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Squares and Cubes table!");
            String choice = "y";
            while (choice.Equals("y")) {
                Console.Write("Enter an integer: ");
                int num = Int32.Parse(Console.ReadLine());
                Console.WriteLine("\nEnter an integer: ");
                Console.WriteLine("======   =======  =====");
                for (int i = 1; i <= num; i++) {
                    Console.WriteLine(i + "\t " + (i * i) + "\t  " + (i * i * i));
                    
                }
                Console.WriteLine("Continue ? (y/n) ");
                choice = Console.ReadLine();
            }

            Console.WriteLine("Bye now :)");
        }
    }
}
