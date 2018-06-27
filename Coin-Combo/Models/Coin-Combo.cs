using System;

namespace CoinCombo
{
  public class CoinCombo
  {
    private int Remainder = 0;
    private int Quarters = 0;
    private int Dimes = 0;
    private int Nickels = 0;
    private int Pennies = 0;

    public CoinCombo(int number)
    {

    }
    public int GetQuarters()
    {
      return Quarters;
    }
    public int GetDimes()
    {
      return Dimes;
    }
    public int GetNickels()
    {
      return Nickels;
    }
    public int GetPennies()
    {
      return Pennies;
    }
    public void Coins(int number)
    {
       Quarters += number/25;
       Remainder = number % 25;
       Dimes += Remainder/10;
       Remainder = Remainder % 10;
       Nickels += Remainder/5;
       Remainder = Remainder % 5;
       Pennies += Remainder/1;
    }
  }
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("How much change do you have?");
      int number = int.Parse(Console.ReadLine());
      CoinCombo myCoins = new CoinCombo(number);
      string result = myCoins.GetQuarters() + " " + "Quarters" + myCoins.GetDimes() + " " + "Dimes" + myCoins.GetNickels() + " " + "Nickels" + myCoins.GetPennies() + " " + "Pennies";
      Console.WriteLine(result);
    }
  }
}
