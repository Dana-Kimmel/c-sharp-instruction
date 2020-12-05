using System;
using System.Collections.Generic;

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

            choice = GetString("\nCommand: \n");


        }
    }
}
