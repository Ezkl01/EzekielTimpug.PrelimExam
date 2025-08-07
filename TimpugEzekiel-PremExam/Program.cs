using System;
class program
{
    static void Main()
    {

        //Problem 1

        int ConditionMet = 0;

        Console.WriteLine("\n=== Grade Letter Generator ===\n");

        Console.Write("Please enter your grade (0-100) : ");
        double studentGrade = double.Parse(Console.ReadLine());

        if (studentGrade >= 90 && studentGrade <= 100)
        {

            Console.WriteLine("\nYou got : A - Exellent performance!\n");

        }
        else if (studentGrade >= 80 && studentGrade <= 89)
        {

            Console.WriteLine("\nYou got : B - Good job!\n");

        }
        else if (studentGrade >= 70 && studentGrade <= 79)
        {

            Console.WriteLine("\nYou got : C - Nice, But need for improvement.\n");

        }
        else if (studentGrade >= 60 && studentGrade <= 69)
        {

            Console.WriteLine("\nYou got : D - Passed, But need more efforts.\n");

        }
        else if (studentGrade >= 0 && studentGrade <= 59)
        {

            Console.WriteLine("\nYou got : F - Failed, Better luck next time\n");
        }
        else
        {

            Console.WriteLine("\nInvalid input. Please enter a grade between 0 and 100.\n");
        }

        //Problem 2

        Console.WriteLine("\n=== Feedback Message Using switch ===\n");

        Console.Write("Enter a letter in grade (A-F) : ");
        string letter = Console.ReadLine().ToUpper();

        if (letter == "A")
        {
            Console.WriteLine("\nFeedback : Excellent!\n");
        }
        else if (letter == "B")
        {
            Console.WriteLine("\nFeedback : Great job!\n");
        }
        else if (letter == "C")
        {
            Console.WriteLine("\nFeedback : Good effort!\n");
        }
        else if (letter == "D")
        {
            Console.WriteLine("\nFeedback : Needs improvement.\n");
        }
        else if (letter == "F")
        {
            Console.WriteLine("\nFeedback : Failed. Better luck next time.\n");
        }
        else
        {
            Console.WriteLine("\nInvalid input. Please enter a letter from A to F only.\n");
        }


    }
}




