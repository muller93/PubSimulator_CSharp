using System;

class Human{
  String name;
  int age;
  int money;
  int drunkenness = 0;
  Boolean male;
  Boolean inPub;

  public Human(String name, int age, Boolean male, int money){
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
  //public Boolean inPub { get; set; }

  public void drinking(Barkeeper barkeeper){
    if(inPub == true){
      money--;
      drunkenness++;
      barkeeper.SetMoney((barkeeper.GetMoney() +1));
      toMuchAlcohol();
    } else {
      Console.WriteLine("He isn't in pub.");
    }
  }

  public void sleeping(){
    drunkenness = 0;
    Console.WriteLine("He is sleeping.");
  }

  public void goHome(){
    inPub = false;
    Console.WriteLine("He goes to home.");
  }

  public void goPub(){
    inPub = true;
    Console.WriteLine("He goes to pub");
  }

  public void drinking(Barkeeper barkeeper, Drink drink){
    if(inPub == true){
      Console.WriteLine(drink.GetPrice());
      money = (money - drink.GetPrice());
      drunkenness += drink.GetAlcoholContent();
      barkeeper.SetMoney(barkeeper.GetMoney() + drink.GetPrice());
      toMuchAlcohol();
    } else {
      Console.WriteLine("He isn't in pub.");
    }
  }
  public void toMuchAlcohol(){
    if(drunkenness > 39){
      sleeping();
    }
  }
  public override string ToString()
  {
    return "Human, name: " + name +", money: " + money +", age: " + age +", drunkeness: "+ drunkenness;
  } 
}


/*Bvítsük ki a már létez Ember osztályt egy privát pénz , és részegség int, és egy kocsmában boolean változókkal.
 Legyen egy új konstruktor, ez
fogadjon a már meglév paramétereken kívül egy pénz paramétert is, amit állítson be az Ember pénzének.
 A részegség 0, a kocsmában false
legyen alapértelmezetten. Legyen az Embernek egy iszik(Kocsmáros kocsmaros) metódusa, ami egy Kocsmárost vár majd.
 Ha ezt
meghívják, akkor ha az illet a kocsmában van, fogyjon 1 a pénzébl, njön 1-gyel a részegsége, generáljon 1 koszos poharat,
 és adjon 1 pénzt a
kocsmárosnak, akit paraméterül kapott. Majd látjuk, hogy a poharat hova kell eltárolni, és mi a Kocsmáros.
 Ha nincs a kocsmában, akkor írjon ki
egy üzenetet errl. Legyen egy alszik() metódusa is, ami nullázza a részegséget és kiírja, hogy elaludt, 
egy hazamegy() metódusa, ami
false-ra állítja a kocsmában változót, és egy jön() metódusa, ami true-ra. Ezekrl is történjen kiírás. */