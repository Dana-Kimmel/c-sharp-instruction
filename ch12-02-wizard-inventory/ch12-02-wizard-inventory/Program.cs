using System;
using System.Collections.Generic;
using System.Linq;

namespace ch12_02_wizard_inventory {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("The Wizard Inventory game!");

            List<string> wizardItems = new List<string>();
            wizardItems.Add("wooden staff");
            wizardItems.Add("wizard hat");
            wizardItems.Add("cloth shoes");

            Console.WriteLine("The Wizard Inventory Game\n");
            Console.WriteLine("COMMAND MENU");
            Console.WriteLine("show - Show all items\ngrab - Grab an item\nedit - Edit an item");
            Console.WriteLine("drop - Drop an item\nexit - Exit program");

            string choice;

            choice = util.MyConsole.GetString("\nCommand: \n");

			while (!choice.Equals("exit")) {
				if (choice.Equals("show")) {
					ShowAll(wizardItems);
					choice = util.MyConsole.GetString("\nCommand: \n");
				}
				if (choice.Equals("grab")) {
					GrabItem(wizardItems);
					choice = MyConsole.GetString("\nCommand: \n");

				} else if (choice.Equals("edit")) {
					EditItem(wizardItems);
					choice = MyConsole.GetString("\nCommand: \n");
				} else if (choice.Equals("drop")) {
					DropItem(wizardItems);
					choice = MyConsole.GetString("\nCommand: \n");
				} else if (choice.Equals("exit")) {
					Console.WriteLine("Bye now :)");
				} else {
					Console.WriteLine("Invalid");
					choice = MyConsole.GetString("\nCommand: \n");
				}
			}
		}
		public static void ShowAll(List<String> wizardItems) {
			int itemCounter = 1;
			foreach (String wizardItem in wizardItems) {
				Console.WriteLine(itemCounter++ + ".  " + wizardItem);

			}
		}
		public static List<String> GrabItem(List<String> wizardItems) {
			if (wizardItems.Count >= 4) {
				Console.WriteLine("You can't carry any more items. Drop something first.");
			} else {
				String addedItem = MyConsole.GetString("Name: ");
				wizardItems.Add(addedItem);
				Console.WriteLine(addedItem + " was added.");
			}
			return wizardItems;
		}
		public static List<String> EditItem(List<String> wizardItems) {
			int enterNumber = MyConsole.GetInt("Number: ");
			enterNumber--;
			String editItem = MyConsole.GetString("Updated name: ");
			wizardItems.(enterNumber, editItem);
			enterNumber++;
			Console.WriteLine("Item number " + enterNumber + " was updated");
			return wizardItems;
		}

		public static List<String> DropItem(List<String> wizardItems) {
			int enterNumber = MyConsole.GetInt("Number: ");
			enterNumber--;
			String itemDropped = wizardItems.set(enterNumber);
			Console.WriteLine(itemDropped + " was dropped");
			return wizardItems;
		}



	}
}
}
