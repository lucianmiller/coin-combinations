using System.Collections.Generic;

namespace CoinCombinations.Models
{
  public class CoinCombinations
  {
    public List<string> Coins { get; set; }
    public List<int> Worth { get; set; }

    public CoinCombinations()
    {
      Coins = new List<string> {"penny", "nickle", "dime", "quarter"}
      Worth = new List<int> {1, 5, 10, 25}
    }
  }
}