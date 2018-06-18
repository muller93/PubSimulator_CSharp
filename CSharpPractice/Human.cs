class Human{
  String name;
  int age;
  int money;
  int drunkenness = 0;
  boolean male;
  boolean inPub = false;

  public Human(String name, int age, boolean male, int money, int drunkenness, boolean inPub){
    this.name = name;
    this.age = age;
    this.male = male;
    this.money = money;
    this.drunkenness = drunkenness;
    this.inPub = inPub;
  }

  public void drinking(Barkeeper barkeeper){
    if(inPub == true){
      money--;
      drunkenness++;
      barkeeper.money++;
    } else {
      System.Console.Write("He isn't in pub.")
    }
  }

  public void sleeping(){
    drunkenness = 0;
    System.Console.Write("He is sleeping.")
  }

  public void goHome(){
    inPub = false;
    System.Console.Write("He goes to home.")
  }

  public void goPub(){
    inPub = true;
    System.Console.Write("He goes to pub")
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