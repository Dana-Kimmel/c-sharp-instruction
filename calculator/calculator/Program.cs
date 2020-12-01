using System;

namespace calculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Area and Perimeter Calculator!");

            String choice = "y";
            while (choice.Equals("y")) {

                Console.WriteLine("Enter length: ");
                int length = Int32.Parse(Console.ReadLine());

                Console.WriteLine("Enter width: ");
                int width = Int32.Parse(Console.ReadLine());

                int area = width * length;
                int perimeter = (2 * width) + (2 * length);

                Console.WriteLine("Area: " + area + "\n" + "Perimeter: " + perimeter);

                Console.WriteLine("Continue? (y/n)");
                choice = Console.ReadLine();

                Console.WriteLine("Bye now :)");
            }
             
        }
    }
}
