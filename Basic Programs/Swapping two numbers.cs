using System;

class Program
{
    static void Main() {
        Console.WriteLine("Swap two numbers using ∗ and /");
        string header = new String('-',30);
        Console.WriteLine(header);
        Console.Write("Enter first Number: ");
        int num1 = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter second Number: ");
        int num2 = Convert.ToInt32(Console.ReadLine());
        string header2 = new String('-',45);
        Console.WriteLine(header2);
        Console.WriteLine("Before Swaping first number: {0},second number: {1}",num1,num2);
        num1 = num1*num2; //a=50 (5*10) 
        num2 = num1/num2; //b=5 (50/10)
        num1 = num1/num2; //a=10 (50/5)
        string footer = new String('-',45);
        Console.WriteLine(footer);
        Console.WriteLine("After Swaping fist number: {0}, second number: {1}",num1,num2);
    }
}
