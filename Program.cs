// See https://aka.ms/new-console-template for more information
using System.ComponentModel;


//Scenario 1: Basic Calculator
//Objective: Create a simple console application that performs basic arithmetic operations (addition, subtraction, multiplication, division).

//Requirements:
//Prompt the user to enter two numbers.
//Prompt the user to select an operation (add, subtract, multiply, divide).
//Perform the selected operation and display the result.
//Handle division by zero and invalid inputs gracefully.

//Key Features:
//Input validation
//Exception handling
//Basic arithmetic operations

Console.Write("Please enter 1st number: ");
int num1 = int.Parse(Console.ReadLine());

Console.Write("Please enter 2nd number: ");
int num2 = int.Parse(Console.ReadLine());

int add(int num1, int num2) => num1 + num2;

int subtract(int num1, int num2) => num1 - num2;

int multiply(int num1, int num2) => num1 * num2;

int divide(int num1, int num2) => num1 / num2;


Console.WriteLine("Please type option, 'add', 'subtract', 'multiply', or 'divide': ");

string menuSelection = Console.ReadLine();




switch (menuSelection)
{
    case "add":
        Console.WriteLine($"Addition: {num1} + {num2} = {add(num1, num2)}");
        break;
    case "subtract":
        Console.WriteLine($"Subtraction: {num1} - {num2} = {subtract(num1, num2)}");
        break;
    case "multiply":
        Console.WriteLine($"Multiplication: {num1} * {num2} = {multiply(num1, num2)}");
        break;
    case "divide":
        if (num1 % num2 == 0)
        {
            Console.WriteLine($"Division: {num1} / {num2} = {divide(num1, num2)}");
        }
        else
            Console.WriteLine("Next time enter a numbers that divides evenly without remainders");
        break;
    default:
        Console.WriteLine("Unknown");
        break;
}

