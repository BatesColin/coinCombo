using System;

namespace CoinCombo
{
  public class CoinCombo
  {
    int remainder = 0;
    int quarters = 0;
    int dimes = 0;
    int nickels = 0;
    int pennies = 0;
    public CoinCombo()
    {

    }
    public int Coins(int number)
    {

      newNumber = New number()
      {
       quarters += number/25
       remainder = %25
       dimes+= number/10
       remainder = %10
       nickles+= number/5
       remainder = %5
       pennies += number/1
      }
    }
  }
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("How much change do you have?");
      int number = Console.ReadLine();
      CoinCombo myCoins = new CoinCombo(number);
      string result = quarters + " " + "Quarters" + dimes + " " + "Dimes" + nickels + " " + "Nickels" + pennies + " " + "Pennies";
      Console.WriteLine(result);
    }
  }
}
