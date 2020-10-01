using System;


namespace Pierre.Models
{
  public class Order
  {
    public string userBread { get; set; }
    public string userPastry { get; set; }
    public int breadCost(int userBread)
    {
      if (userBread % 3 == 0)
      {
        return (userBread * 5) - ((userBread / 3) * 5);
      }
      else if (userBread % 3 == 1)
      {
        return (userBread * 5) - ((userBread / 3) * 5);
      }
      else
      {
        return (userBread * 5);
      }
    }
    public int pastryCost(int userPastry)
    {
      if (userPastry % 3 == 0)
      {
        return ((userPastry / 3) * 5);
      }
      else if (userPastry % 3 == 1)
      {
        return ((userPastry / 3) * 5) + ((userPastry / userPastry) * 2);
      }
      else if (userPastry % 3 == 2 && userPastry >= 4)
      {
        return ((userPastry / 3) * 5) + ((userPastry % 3) * 2);
      }
      else
      {
        return (userPastry * 2);
      }
    }
  }
}





