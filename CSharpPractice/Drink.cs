class Drink
{
  string name;
  int price;
  int alcoholContent;

  public Drink(string name, int price, int alcoholContent)
  {
    this.price = price;
    this.alcoholContent = alcoholContent;
    this.name = name;
  }
  public int GetPrice()
  {
    return price;
  }

  public string GetName()
  {
    return name;
  }
  public int GetAlcoholContent()
  {
    return alcoholContent;
  }

  public override string ToString()
  {
    return "Drink, price: " + price + ", alcohol content: " + alcoholContent;
  }
}
