using System;
using Pierre;

namespace Pierre
{
  public class Program
  {
    public static void Main()
    {
      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("----------------------------");
      Console.WriteLine("How many loaves of Bread would you like?");
      string userOrderOne = Console.ReadLine();
      int userBread = int.Parse(userOrderOne);
      Console.WriteLine(userBread);
    }
  }
}