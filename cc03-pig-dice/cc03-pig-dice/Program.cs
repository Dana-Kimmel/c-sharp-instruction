using System;

namespace cc03_pig_dice {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Let's Play Pig Dice!");
            string choice = "y";
            while (choice.Equals("y")) {
                Console.WriteLine("# of times to play?");
                int numberOfGames = int.Parse(Console.ReadLine());
                Console.WriteLine("Here we go!");
                int max = 0;
                for (int i = 0; i < numberOfGames; i++) {
                    int roll = 0;
                    int total = 0;
                    while (roll != 1) {
                        Random rand = new Random();
                        roll = rand.Next(1, 7);
                        total += roll;
                    }
                    max = Math.Max(max, total);
                    roll = 0;
                    total = 0;

                }
                Console.WriteLine("====================");
                Console.WriteLine("total games: \t" + numberOfGames);
                Console.WriteLine("Max Score: \t" + max);
                Console.WriteLine("====================");
                Console.WriteLine("Play again? (y/n)");
                choice = Console.ReadLine();
            }
            Console.WriteLine("Bye now :)");
        }
        


        }
    }

