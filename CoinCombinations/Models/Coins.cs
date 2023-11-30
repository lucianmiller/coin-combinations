using System.Collections.Generic;
using System;

namespace CoinCombinations.Models
{
  public class CoinCounter
  {
    public Dictionary<string, float> _coins = new Dictionary<string, float>
    {
      {"penny", 0.01f},
      {"nickel", 0.05f},
      {"dime", 0.1f},
      {"quarter", 0.25f}
    };
    public Dictionary<string, int> _output = new Dictionary<string, int>
    {
      {"penny", 0},
      {"nickel", 0},
      {"dime", 0},
      {"quarter", 0}
    };
    public float UserPrice { get; set; }

    public CoinCounter(string userInput)
    {
      UserPrice = float.Parse(userInput);
    }

    public void CountCoins()
    {
      while (UserPrice > 0)
      {
        if (UserPrice > _coins["quarter"])
        {
          int numOfQuarters = Convert.ToInt32(Math.Floor(UserPrice / _coins["quarter"]));
          _output["quarter"] = numOfQuarters;
          UserPrice = (float)Math.Round(UserPrice - (numOfQuarters * _coins["quarter"]), 2);
        }
        else if (UserPrice > _coins["dime"])
        {
          int numOfDimes = Convert.ToInt32(Math.Floor(UserPrice / _coins["dime"]));
          _output["dime"] = numOfDimes;
          UserPrice = (float)Math.Round(UserPrice - (numOfDimes * _coins["dime"]), 2);
        }
        else if (UserPrice > _coins["nickel"])
        {
          int numOfNickels = Convert.ToInt32(Math.Floor(UserPrice / _coins["nickel"]));
          _output["nickel"] = numOfNickels;
          UserPrice = (float)Math.Round(UserPrice - (numOfNickels * _coins["nickel"]), 2);
        }
        else if (UserPrice > _coins["penny"])
        {
          int numOfPennies = Convert.ToInt32(Math.Floor(UserPrice / _coins["penny"]));
          _output["penny"] = numOfPennies;
          UserPrice = (float)Math.Round(UserPrice - (numOfPennies * _coins["penny"]), 2);
        }
      }
    }
  }
}