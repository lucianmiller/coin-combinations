using System;
using CoinCombinations.Models;

namespace CoinCombinations
{
  class Program
  {
    static void Main()
    {
      Console.WriteLine("Please enter amount of money you have:");
      string userInput = Console.ReadLine();
      CoinCounter coinCombinations = new CoinCounter(userInput);
      coinCombinations.CountCoins();

      Console.WriteLine("quarters: " + coinCombinations._output["quarter"]);
      Console.WriteLine("dimes: " + coinCombinations._output["dime"]);
      Console.WriteLine("nickels: " + coinCombinations._output["nickel"]);
      Console.WriteLine("pennies: " + coinCombinations._output["penny"]);
    }
  }
}