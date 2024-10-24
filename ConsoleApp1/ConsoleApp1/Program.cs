//1

//string x = Console.ReadLine();
//int l = int.Parse(x);
//if (l % 2 == 0)
//{
//    Console.WriteLine("parzysta");
//}
//else
//{
//    Console.WriteLine("nieparzysta");
//}

//2

//string x = Console.ReadLine();
//int l = int.Parse(x);

//for (int i = 2; i < l; i = i+ 2)
//{
//    Console.WriteLine(i);
//}



//3

//while (true) {
//    Console.WriteLine("1. print elo");
//    Console.WriteLine("2. print siema");
//    Console.WriteLine("3. wyjdz");
//    Console.WriteLine("Podaj liczbe: ");
//    string x = Console.ReadLine();
//    if (x == "1")
//    {
//        Console.WriteLine("elo");
//    }
//    else if (x == "2") { Console.WriteLine("siema"); }
//    else if (x == "3") { break; }
//    else
//    {
//        Console.WriteLine("podaj odpowiednia liczbe");
//    }
//}


//4

//string x = Console.ReadLine();
//int l = int.Parse(x);
//int s = 1;
//for (int i = l; i > 0; i--)
//{
//    s = s * i;
//}
//Console.WriteLine(s);


//5


//string x = Console.ReadLine();
//int l = int.Parse(x);

//Random rnd = new Random();
//int rand = rnd.Next(l);
//int tries = 0;
//while (true)
//{
//    Console.WriteLine("Zgadnij liczbe od 0 do "+l);
//    string t = Console.ReadLine();
//    int ti = int.Parse(t);
//    tries++;
//    if (ti != rand) { Console.WriteLine("sprobuj ponownie"); }
//    else { Console.WriteLine("Zgadles w " + tries + " prob!"); break; }
//}