using System;

namespace CSHarpPractice
{

  class Program
  {
    static void Main(string[] args)
    {
      Barkeeper Igor = new Barkeeper(100);
      Barkeeper Sergej = new Barkeeper(200);

      Drink beer = new Drink("beer", 100, 3);
      Drink vodka = new Drink("vodka", 300, 8);
      Drink palinka = new Drink("palinka", 400, 10);
      Drink wine = new Drink("wine", 200, 5);
      Drink absinthe = new Drink("absinthe", 500, 14);

      Human frank = new Human("Frank", 25, true, 3000);
      Human giorgo = new Human("Giorgo", 28, false, 2500);
      Human john = new Human("Robi", 18, true, 1000);

      frank.goPub();
      giorgo.goPub();
      john.goPub();

      Console.WriteLine(john);
      john.drinking(Igor, beer);
      john.drinking(Igor, vodka);
      john.drinking(Sergej, palinka);
      john.drinking(Sergej, wine);
      john.drinking(Igor, beer);
      john.drinking(Sergej, beer);
      Console.WriteLine(john);

      Console.WriteLine(giorgo);
      giorgo.drinking(Igor, beer);
      giorgo.drinking(Sergej, wine);
      giorgo.drinking(Sergej, palinka);
      giorgo.drinking(Igor, beer);
      giorgo.drinking(Sergej, absinthe);
      giorgo.drinking(Sergej, palinka);
      Console.WriteLine(giorgo);


      Console.WriteLine(frank);
      frank.drinking(Sergej, wine);
      frank.drinking(Igor, beer);
      frank.drinking(Sergej, absinthe);
      frank.drinking(Igor, beer);
      frank.drinking(Sergej, beer);
      Console.WriteLine(frank);

    }
  }
}

