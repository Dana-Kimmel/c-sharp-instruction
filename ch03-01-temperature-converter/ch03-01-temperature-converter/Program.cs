using System;

namespace ch03_01_temperature_converter {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Temperature Converter!");
            
            String choice = "y";
            while(choice.Equals("y")) {
                Console.WriteLine("Enter degrees in Fahrenheit: ");
                double degreeFahrenheit = Double.Parse(Console.ReadLine());

                double degreeCelsius = (degreeFahrenheit - 32) * 5 / 9;
                double degreeCelsiusRounded = Math.Round(degreeCelsius, 2);

                Console.WriteLine("Degrees in Celsius: " + degreeCelsiusRounded);

                Console.WriteLine("Continue? (y/n)");
                choice = Console.ReadLine();
                
            }
            Console.WriteLine("Bye now :)");
        }
    }
}
