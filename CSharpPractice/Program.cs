﻿using System;

namespace CSHarpPractice{

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

/*Kocsmaszimulátor part 1:
Bvítsük ki a már létez Ember osztályt egy privát pénz , és részegség int, és egy kocsmában boolean változókkal. Legyen egy új konstruktor, ez
fogadjon a már meglév paramétereken kívül egy pénz paramétert is, amit állítson be az Ember pénzének. A részegség 0, a kocsmában false
legyen alapértelmezetten. Legyen az Embernek egy iszik(Kocsmáros kocsmaros) metódusa, ami egy Kocsmárost vár majd. Ha ezt
meghívják, akkor ha az illet a kocsmában van, fogyjon 1 a pénzébl, njön 1-gyel a részegsége, generáljon 1 koszos poharat, és adjon 1 pénzt a
kocsmárosnak, akit paraméterül kapott. Majd látjuk, hogy a poharat hova kell eltárolni, és mi a Kocsmáros. Ha nincs a kocsmában, akkor írjon ki
egy üzenetet errl. Legyen egy alszik() metódusa is, ami nullázza a részegséget és kiírja, hogy elaludt, egy hazamegy() metódusa, ami
false-ra állítja a kocsmában változót, és egy jön() metódusa, ami true-ra. Ezekrl is történjen kiírás.
Legyen egy Kocsmáros osztály is. Neki is legyen privát pénze , amit konstruktorban is meg lehet adni. Az összes kocsmáros ugyanazokon a kosz
os poharakon osztozzon (static), és legyen egy elmos() metódusa, ami csökkenti eggyel a koszos poharak számát, és kiírja, hogy elmosott egy
poharat. Ha nincs koszos pohár, akkor azt írja ki.
Legyen egy Ital osztály is, aminek a következ privát tulajdonságai lesznek: ár , alkoholtartalom .
Az Embernek legyen egy olyan iszik metódusa is, aminek fejléce iszik(Kocsmáros kocsmáros, Ital ital) , azaz italt is tud fogadni.
Ekkor az ital árát adja át az Ember a Kocsmárosnak 1 helyett. Az Ember részegsége az ital alkoholtartalmával njön.
Ha a részegség eléri a 40-et, akkor az Ember mindkét iszik() függvényénél automatikusan aludjon el.
Az összes osztály privát változóihoz legyenek getter, setter metódusok, és az osztályokhoz értelmes toString metódus.
Legyen egy main függvény, mondjuk Main nev osztályban, itt írjatok egy rövidke futtatást, amiben eljátszogattok egy kicsit az emberekkel,
bemutattok pár esetet, igyanak, aludjanak, stb... */
