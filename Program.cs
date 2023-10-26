using System;

System.Console.WriteLine("Enter your Currency");
int yourCurrency = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine("Enter todays value to your currency");
int realCurrency = Convert.ToInt32(Console.ReadLine());

System.Console.WriteLine($"Cuurency for today is; {yourCurrency * realCurrency}  ");
