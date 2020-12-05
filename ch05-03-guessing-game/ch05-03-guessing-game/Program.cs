using System;

namespace ch05_03_guessing_game {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the Guess the Number Game!");
            Console.WriteLine("++++++++++++++++++++++++++++++++++++");
			var r = new Random();
			int numToGuess = r.Next(100);

			int userGuess = 0;
			int numGuesses = 0;
			while (userGuess != numToGuess) {
				numGuesses++;
				userGuess = GetInt("Enter a number between 1 and 100: ", 1, 100);
				
				if (userGuess > (10 + numToGuess)) {
					Console.WriteLine("Way to high!");
				} else if (userGuess > numToGuess) {
					Console.WriteLine("Too high!");
				} else if (userGuess < (numToGuess - 10)) {
					Console.WriteLine("Way too low!");
				} else if (userGuess < numToGuess) {
					Console.WriteLine("Too low!");
				} else {
					Console.WriteLine("You got it in " + numGuesses + " tries!");
				}

			}
		}
		public static int GetInt(String prompt, int min, int max) {
			int n = 0;
			Boolean success = false;
			while (!success) {
				Console.Write(prompt);
				n = int.Parse(Console.ReadLine());
				if (n <= min) {
					Console.WriteLine("Error! Number must be greater than " + min + ".");
				} else if (n >= max) {
					Console.WriteLine("Error! Number must be less than " + max + ".");
				} else {
					success = true;
				}
			}
			return n;
		}

		}
	}

