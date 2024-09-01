using System.Transactions;

Console.WriteLine("Welcome to simple calculator");
Console.WriteLine("Enter the first number");
decimal num1 = decimal.Parse(Console.ReadLine());
Console.WriteLine("Enter the second number");
decimal num2 = decimal.Parse(Console.ReadLine());
decimal sum = num1 + num2;
Console.WriteLine("The sum of the two numbers is " + sum);