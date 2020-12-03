using System;

namespace ch05_01_dice_roller {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Dice Roller!");
            
            Console.WriteLine("Roll the dice? (y/n)");
            String choice = Console.ReadLine();
            while (choice.Equals("y") || choice.Equals("Y")) {
               
                int die1 = GetDiceRoll();
                int die2 = GetDiceRoll();
                String message = "Die 1: " + die1 + "\nDie 2: " + die2 + "\nTotal: " + (die1 + die2);
                PrintExtraMessage(die1, die2);
                Console.WriteLine(message);

                Console.WriteLine("Roll again? (y/n)");
                choice = Console.ReadLine();
            }
 
            }
        private static int GetDiceRoll() {
            var r = new Random();
            int diceRoll = r.Next(6) + 1;
            return diceRoll;

 
                }
        private static void PrintExtraMessage(int dice1, int dice2) {
            if (dice1 + dice2 == 2) {
                Console.WriteLine("Snake eyes!");
            } else if (dice1 + dice2 == 12) {
                Console.WriteLine("Box cars!");
            }
        }
    }
}
