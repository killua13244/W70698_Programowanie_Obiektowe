//class Osoba
//{
//    private string imie;
//    private string nazwisko;
//    private int wiek;
//    private string pesel;
//    public Osoba(string imie, string nazwisko, int wiek, string pesel)
//    {
//        this.imie = imie;
//        this.nazwisko = nazwisko;
//        this.wiek = wiek;
//        this.pesel = pesel;
//    }

//    public string Imie
//    {
//        get { return imie; }
//        set { imie = value; }
//    }

//    public string Nazwisko
//    {
//        get { return nazwisko; }
//        set { nazwisko = value; }
//    }

//    public int Wiek
//    {
//        get { return wiek; }
//        set { if (wiek < 1) { wiek = value; } }
//    }

//    public string Pesel
//    {
//        get { return pesel; }
//    }

//    public string PrzedstawSie()
//    {
//        return imie + nazwisko + wiek;
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        Osoba osoba = new Osoba("Jan", "kow", 30, "457476457");
//        Console.WriteLine(osoba.PrzedstawSie());
//    }
//}





//class Licz
//{
//    private int wartosc;
//    public void dodaj(int x)
//    {
//        wartosc = x + wartosc;
//    }
//    public void odejmij(int x)
//    {
//        wartosc = wartosc - x;
//    }
//    public Licz(int Wartosc)
//    {
//        wartosc = Wartosc;
//    }
//    public int Wartosc
//    {
//        get { return wartosc; }
//    }
//}


using System.ComponentModel;

class Sumator
{
    private int[] Liczby;
    public int Suma()
    {
        return Liczby.Sum();
    }
    public double SumaPodziel3()
    {
        return Liczby.Where(x=>x%3==0).Sum();
    }
    public Sumator(int[] liczby)
    {
        Liczby = liczby;
    }
    public int IleEl()
    {
        return Liczby.Count();
    }
    public void Wypisz()
    {
        foreach (int i in Liczby)
        {
            Console.WriteLine(i);
        }
    }
}


//class Program
//{
//    static void Main()
//    {
//        Osoba osoba = new Osoba("Jan", "kow", 30, "457476457");
//        Console.WriteLine(osoba.PrzedstawSie());
//    }
//}