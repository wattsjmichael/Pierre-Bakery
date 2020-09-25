namespace Pierre
{
  public class Bread
  {
    public int isBread(int userBread)
    {
      if (userBread % 3 == 0)
      {
        return (userBread * 5) - ((userBread/3) * 5);
      }
      else
      {
        return (userBread * 5);
      }
    }
  }
  public class Pastry
  {
    public int isPastry(int userPastry)
    {
      return (userPastry * 2);
    }
  }
}


