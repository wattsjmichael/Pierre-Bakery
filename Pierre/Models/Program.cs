using System;
using Pierre.Models;


namespace Pierre
{
  public class Program
  {
    public static void Main()
    {
      string userInputBread;
      string userInputPastry;
      

      Console.WriteLine("Welcome to Pierre's Bakery!");
      Console.WriteLine("----------------------------");
      Console.WriteLine("Sale Today for Bread, Buy 2 Loaves get 1 Free!");
      Console.WriteLine("Loaves of Bread are 5 dollars");
      Console.WriteLine("----------------------------");
      Console.WriteLine("How many loaves of Bread would you like?");
      userInputBread = Console.ReadLine();
      Console.WriteLine("---------------------");
      Console.WriteLine("Dont Forget about Pastries!");
      Console.WriteLine("They are on SALE too! 1 Pastry for $2 or 3 pastries for $5");
      Console.WriteLine("---------------------");
      Console.WriteLine("How Many Pastries would you like?");
      userInputPastry = Console.ReadLine();
      int userPastry = int.Parse(userInputPastry);
      Console.WriteLine("--------------------");
      Console.WriteLine("Your Itemized Receipt (you know for those pesky expense reports :)");
      Console.WriteLine(Pastry.isPastry(userPastry) + " Dollars for your Pastries");
      int userBread = int.Parse(userInputBread);
      Console.WriteLine(Bread.isBread(userBread) + " Dollars for your Bread");
      int totalBread = Bread.isBread(userBread);
      int totalPastry = Pastry.isPastry(userPastry);
      Console.WriteLine("-------------------");
      Console.WriteLine("Your total is " + ((totalBread) + (totalPastry)) + " Dollars"); 
      Console.WriteLine("Thank you for shopping at Pierre's Bakery! Take Care! ");
    }
  }
}