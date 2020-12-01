using System;

namespace ch02_pr2_GradeConverter {
    class Program {
        static void Main(string[] args) {
            Console.WriteLine("Welcome to the letter grade converter");
           
            String choice = "y";
            while (choice.Equals("y")) {
                Console.WriteLine("Enter numerical grade: ");
                int numericalGrade = Int32.Parse(Console.ReadLine());
                String letterGrade = " ";

                if (numericalGrade >= 88) {
                    letterGrade = "A";
                } else if (numericalGrade >= 80) {
                    letterGrade = "B";
                } else if (numericalGrade >= 67) {
                    letterGrade = "C";
                } else if (numericalGrade >= 60) {
                    letterGrade = "D";
                } else {
                    letterGrade = "F";
                }
                Console.WriteLine("letter grade: " + letterGrade);
                Console.WriteLine("Continue (y/n) ?");
                choice = Console.ReadLine();
            }
        }

    }
}
