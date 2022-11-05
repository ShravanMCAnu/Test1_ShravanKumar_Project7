// See https://aka.ms/new-console-template for more information
using Test1_ShravanKumar_Project7;

Odd objOdd=new Odd();
Console.WriteLine("For Even 'E','e' or For Odd 'O''o'");
char choice=Convert.ToChar(Console.ReadLine());
switch (choice)
{
    case 'E' or 'e':
        Console.WriteLine("Enter Number");
        int numberForE=Convert.ToInt32(Console.ReadLine());
        objOdd.SumOfEven(numberForE);
        break;
    case 'O' or 'o':
        Console.WriteLine("Enter Number");
        int numberForO = Convert.ToInt32(Console.ReadLine());
        objOdd.SumOfOdd(numberForO);
        break;
}


