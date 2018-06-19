using System;

class Human
{
  String name;
  int age;
  int money;
  int drunkenness = 0;
  Boolean male;
  Boolean inPub;

  public Human(String name, int age, Boolean male, int money)
  {
    this.name = name;
    this.age = age;
    this.male = male;
    this.money = money;
  }

  public String Name { get; set; }
  public int Age { get; set; }
  public int Money { get; set; }
  public int Drunkenness { get; set; }
  public Boolean Male { get; set; }

  public void drinking(Barkeeper barkeeper)
  {
    if (inPub == true)
    {
      money--;
      drunkenness++;
      barkeeper.SetMoney((barkeeper.GetMoney() + 1));
      toMuchAlcohol();
    }
    else
    {
      Console.WriteLine(name + " isn't in pub.");
    }
  }

  public void sleeping()
  {
    drunkenness = 0;
    Console.WriteLine(name + " slept.");
  }

  public void goHome()
  {
    inPub = false;
    Console.WriteLine(name + " goes to home.");
  }

  public void goPub()
  {
    inPub = true;
    Console.WriteLine(name + " goes to pub");
  }

  public void drinking(Barkeeper barkeeper, Drink drink)
  {
    if (inPub == true)
    {
      if (money >= drink.GetPrice())
      {
        money = (money - drink.GetPrice());
        drunkenness += drink.GetAlcoholContent();
        barkeeper.SetMoney(barkeeper.GetMoney() + drink.GetPrice());
        toMuchAlcohol();
        Console.WriteLine(name + " drunk a " + drink.GetName());
      }
      else
      {
        Console.WriteLine(name + " hasn't enough money.");
      }
    }
    else
    {
      Console.WriteLine(name + " isn't in pub.");
    }
  }

  public void toMuchAlcohol()
  {
    if (drunkenness > 39)
    {
      System.Console.WriteLine(name + " drunk to much.");
      sleeping();
    }
  }
  public override string ToString()
  {
    return "Human, name: " + name + ", money: " + money + ", age: " + age + ", drunkeness: " + drunkenness + '\n';
  }
}