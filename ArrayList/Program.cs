//System.Collections namespace

using System.Collections;


ArrayList liste = new ArrayList();
//liste.Add("Ayşe");
liste.Add(2);
//liste.Add(true);
//liste.Add('A');

//içerisindeki verilere erişme;
Console.WriteLine(liste[0]);
foreach (var item in liste)
Console.WriteLine(item);

//AddRange
Console.WriteLine("**** Add Range ****");
//string[] renkler = { "Kırmızı", "Sarı", "Yeşil"};
List<int> sayılar = new List<int>() {1,8,3,7,9,92,5};
//liste.AddRange(renkler);
liste.AddRange(sayılar);

foreach (var item in liste)
{
    Console.WriteLine(item); 
}

//sort
Console.WriteLine("***** Sort ***** ");
liste.Sort();

foreach (var item in liste)
{
    Console.WriteLine(item);
}

//Binary Search
Console.WriteLine("***** Binary Search ***** ");
Console.WriteLine(liste.BinarySearch(9));

//Reverse
Console.WriteLine("***** Reverse ***** ");
liste.Reverse();
foreach (var item in liste)
{
    Console.WriteLine(item);
}

//Clear
Console.WriteLine("***** Clear ***** ");
liste.Clear();
foreach (var item in liste)
{    
    Console.WriteLine(item);
}
