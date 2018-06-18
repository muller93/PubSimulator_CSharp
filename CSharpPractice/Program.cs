using System;

namespace CSHarpPractice{

class Program
{
  static void Main(string[] args)
  {
      Barkeeper barkeeper = new Barkeeper(50);
      Drink beer = new Drink(100, 5);
      Human human = new Human("Robi", 18, true, 1000);

      Console.WriteLine(human);
      human.goPub();
      human.drinking(barkeeper, beer);
      Console.WriteLine(human);
      Console.WriteLine(beer);


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
