using System;

class Program
{
    static void Main()
    {
        Console.WriteLine("Enter the first number:");
        string input1 = Console.ReadLine();

        Console.WriteLine("Enter the second number:");
        string input2 = Console.ReadLine();

        DivideStrings(input1, input2);
    }

    static void DivideStrings(string strNum1, string strNum2)
    {
        try
        {
            int num1 = Convert.ToInt32(strNum1);
            int num2 = Convert.ToInt32(strNum2);

            int result = num1 / num2;

            Console.WriteLine($"Result: {num1} / {num2} = {result}");
        }
        catch (FormatException)
        {
            Console.WriteLine("Error: Please enter valid integer values.");
        }
        catch (DivideByZeroException)
        {
            Console.WriteLine("Error: Division by zero is not allowed.");
        }
        catch (OverflowException)
        {
            Console.WriteLine("Error: The number you entered is too large or too small.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"An unexpected error occurred: {ex.Message}");
        }
    }
}