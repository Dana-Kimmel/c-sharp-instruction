using System;

namespace ch03_02_travel_time_calculator {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Travel Time Calculator!");

            String choice = "y";
            while(choice.Equals("y")) {

                Console.WriteLine("Enter miles: ");
                double miles = Double.Parse(Console.ReadLine());

                Console.WriteLine("Enter miles per hour: ");
                double mph = Double.Parse(Console.ReadLine());

                int hours = (int) ((int) miles / mph);
                int min = (int)(((miles / mph) * 60) % 60);

                Console.WriteLine("Estimated travel time: ");
                Console.WriteLine("---------------------");
                Console.WriteLine("Hours: " + hours);
                Console.WriteLine("Minutes: " + min);

                Console.WriteLine("Continue? (y/n) ");
                choice = Console.ReadLine();

                
            }
            Console.WriteLine("Bye now :)");
        }
    }
}
