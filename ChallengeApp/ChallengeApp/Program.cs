﻿var name = "Kasia";
var age = 20;
var sex = "kobieta";

if (sex == "kobieta" && age < 30)
{
    Console.WriteLine("Kobieta poniej 30 lat");
}
else if (name == "Ewa" && age == 30)
{
    Console.WriteLine("Ewa, lat 30");
}
else if (sex == "mężczyzna" && age < 18)
{
    Console.WriteLine("Niepełnoletni mężczyzna");
}
else
{
    Console.WriteLine("Inna osoba");
}
