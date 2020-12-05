using System;
using System.Collections.Generic;
using System.Text;

namespace ch07_product_manager.business {
    class MyConsole {
        public static string GetString(string prompt) {
            Console.WriteLine(prompt);
            string s = Console.ReadLine();
            return s;

        }
        public static int GetInt(string prompt) {

            int n = 0;
            bool success = false;
            while (!success) {
                Console.Write(prompt);
                try {
                    n = int.Parse(Console.ReadLine());
                    success = true;
                } catch (Exception e) {
                    Console.WriteLine("Error! Invalid integer. Try again." + e);
                }

            }
            return n;
        }
        public static int GetInt(String prompt, int min, int max) {
            int n = 0;
            bool success = false;
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
        public static double GetDouble(String prompt) {
            double n = 0;
            bool success = false;
            while (!success) {
                Console.Write(prompt);
                try {
                    n = double.Parse(Console.ReadLine());
                    success = true;
                } catch (Exception e) {
                    Console.WriteLine("Error! Invalid integer. Try again." + e);
                }

            }
            return n;
        }
            public static double GetDouble(String prompt, double min, double max) {
                double n = 0;
                bool success = false;
                while (!success) {
                    Console.Write(prompt);
                    n = double.Parse(Console.ReadLine());
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
