class Drink
{
  int price;
  int alcoholContent;

  public Drink(int price, int alcoholContent){
    this.price = price;
    this.alcoholContent = alcoholContent;
  }
  public int GetPrice(){
    return price;
  }
  public int GetAlcoholContent() {
    return alcoholContent;
    }

  public override string ToString()
  {
    return "Drink, price: " + price +", alcohol content: " + alcoholContent;
  }
}

/*Legyen egy Kocsmáros osztály is. Neki is legyen privát pénze , amit konstruktorban is meg lehet adni.
 Az összes kocsmáros ugyanazokon a kosz
os poharakon osztozzon (static), és legyen egy elmos() metódusa, ami csökkenti eggyel a koszos poharak számát,
 és kiírja, hogy elmosott egy
poharat. Ha nincs koszos pohár, akkor azt írja ki.
Legyen egy Ital osztály is, aminek a következ privát tulajdonságai lesznek: ár , alkoholtartalom .
Az Embernek legyen egy olyan iszik metódusa is, aminek fejléce iszik(Kocsmáros kocsmáros, Ital ital) ,
 azaz italt is tud fogadni.
Ekkor az ital árát adja át az Ember a Kocsmárosnak 1 helyett. Az Ember részegsége az ital alkoholtartalmával njön.
Ha a részegség eléri a 40-et, akkor az Ember mindkét iszik() függvényénél automatikusan aludjon el.
Az összes osztály privát változóihoz legyenek getter, setter metódusok, és az osztályokhoz értelmes toString metódus.
Legyen egy main függvény, mondjuk Main nev osztályban, itt írjatok egy rövidke futtatást,
amiben eljátszogattok egy kicsit az emberekkel,
bemutattok pár esetet, igyanak, aludjanak, stb...  */
