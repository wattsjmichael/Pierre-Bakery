namespace Pierre
{
  public class Bread
  {
    public int isBread(int userBread)
    {
      if (userBread % 3 == 0)
      { 
        return ((((2*userBread) * 5) - (userBread * 5)));
      }
      else
      {
        return (userBread * 5);
      }
    }
  }
    public class Pastry
    {
      public bool isPastry(int pastry)
      {
        return pastry * 2 == 4;
      }
    }
  }

