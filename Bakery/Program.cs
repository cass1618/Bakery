using System;
using BakeryModels;
using System.Collections.Generic;
public class Program
{
  static void Main()
  {
    Bread bread = new Bread();
    bread.PriceEach = 5;
    Pastry pastry = new Pastry();
    pastry.PriceEach = 2;

    Console.WriteLine("\r\nWelcome to Pierre's Bakery!");
    Console.WriteLine("\r\nAll loaves of bread are "+bread.PriceEach.ToString("C2")+" and all pastries are "+pastry.PriceEach.ToString("C2")+".");
    Console.WriteLine("\r\nToday we have 2 amazing specials - buy 2 loaves of bread get 1 free!!  Additionally, 3 pastries for $5!");
    

  }
}