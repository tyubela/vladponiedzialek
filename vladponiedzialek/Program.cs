//1)wstaw do tablicy 40 liczb fibonaccj
//0
//1
//1
//2
//3
//5
//2)wypisz tablice
//3)wczytaj liczbe z klawiatury
//4)wypisz najblizsze liczbe do tej liczby
Console.WriteLine("tablica liczb Fibbonacciego: ");
int[] tablicaLiczbFibbonacciego = new int[40];
tablicaLiczbFibbonacciego[0] = 0;
tablicaLiczbFibbonacciego[1] = 1;
for (int i = 2; i < tablicaLiczbFibbonacciego.Length; i++)
{
    tablicaLiczbFibbonacciego[i] = tablicaLiczbFibbonacciego[i - 1] + tablicaLiczbFibbonacciego[i - 2];
}
for (int i = 0; i < tablicaLiczbFibbonacciego.Length; i++)
{
    Console.WriteLine(tablicaLiczbFibbonacciego[i]+", ");
}
//wypisz w postaci: element nr 0: wartosc tego elementu
Console.WriteLine("liczby Fibbonacciego nr:wartosc");
for(int i = 0;i < tablicaLiczbFibbonacciego.Length; i++)
{
    Console.WriteLine("element numer " + (i+1) + ": " + tablicaLiczbFibbonacciego[i]);
}
Console.WriteLine("Podaj liczbe");
int liczbaWpisana = int.Parse(Console.ReadLine());
int gornaliczbaFib,dolnaliczbaFib;
// wyszukiwanie liniowe
for(int i = 0;i<tablicaLiczbFibbonacciego.Length;i++)
{
    if(liczbaWpisana > tablicaLiczbFibbonacciego[i])
        {
        continue;
    }
    else
    {
        gornaliczbaFib = tablicaLiczbFibbonacciego[i];
        dolnaliczbaFib = tablicaLiczbFibbonacciego[i - 1];
    }
}
Console.WriteLine("gorna " + gornaliczbaFib);
Console.WriteLine("dolna " + dolnaliczbaFib);
Console.WriteLine("szukana " + liczbaWpisana);

if(liczbaWpisana - dolnaliczbaFib > gornaliczbaFib - liczbaWpisana)
{
    Console.WriteLine("blizej " + gornaliczbaFib);
}
else
{
    Console.WriteLine("blizej " + dolnaliczbaFib);
}
