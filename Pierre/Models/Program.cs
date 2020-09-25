using System;
using Pierre.Models;


namespace Pierre
{
  public class Program
  {
    public static void Main()
    {
      string userInput;
      
      
      Console.WriteLine("How Many Bread?");
      userInput = Console.ReadLine();
      int userBread = int.Parse(userInput);
      Console.WriteLine(Bread.isBread(userBread));

    //   Bread order = new Bread(userBread);

    //   Console.WriteLine("Welcome to Pierre's Bakery!");
    //   Console.WriteLine("----------------------------");
    //   Console.WriteLine("How many loaves of Bread would you like?");
    //   string userOrderOne = Console.ReadLine();
    //   int userBread = int.Parse(userOrderOne);
    //   Console.WriteLine(userBread.isBread());
    // }
  }
}
}