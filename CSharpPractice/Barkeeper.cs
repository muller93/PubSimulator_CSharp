class Barkeeper
{
  int money;
  static int usedGlass;
  public int GetMoney()
  {
    return money;
  }
  public int SetMoney(int value)
  {
    return money = value;
  }

  public Barkeeper(int money)
  {
    this.money = money;
  }

  public void washUp()
  {
    if (usedGlass > 0)
    {
      usedGlass--;
      System.Console.Write("He washed a glass");
    }
    else
    {
      System.Console.Write("There is not dirty glass");
    }
  }
  public override string ToString()
  {
    return "Barkeeper money: " + money;
  }
}

