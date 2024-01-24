int numer = 3936;
string slowo = numer.ToString();
char[] litery = slowo.ToArray();

int liczba0 = 0;
int liczba1 = 0;
int liczba2 = 0;
int liczba3 = 0;
int liczba4 = 0;
int liczba5 = 0;
int liczba6 = 0;
int liczba7 = 0;
int liczba8 = 0;
int liczba9 = 0;

foreach (char liczba in litery)
{
    if (liczba == '0')
    {
        liczba0++;
    }
    else if (liczba == '1')
    {
        liczba1++;
    }
    else if (liczba == '2')
    {
        liczba2++;
    }
    else if (liczba == '3')
    {
        liczba3++;
    }
    else if (liczba == '4')
    {
        liczba4++;
    }
    else if (liczba == '5')
    {
        liczba5++;
    }
    else if (liczba == '6')
    {
        liczba6++;
    }
    else if (liczba == '7')
    {
        liczba7++;
    }
    else if (liczba == '8')
    {
        liczba8++;
    }
    else if (liczba == '9')
    {
        liczba9++;
    }
}
Console.WriteLine("0=>" + liczba0);
Console.WriteLine("1=>" + liczba1);
Console.WriteLine("2=>" + liczba2);
Console.WriteLine("3=>" + liczba3);
Console.WriteLine("4=>" + liczba4);
Console.WriteLine("5=>" + liczba5);
Console.WriteLine("6=>" + liczba6);
Console.WriteLine("7=>" + liczba7);
Console.WriteLine("8=>" + liczba8);
Console.WriteLine("9=>" + liczba9);