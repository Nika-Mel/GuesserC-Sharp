﻿using System.ComponentModel;

Random random = new Random();
int gesuchteZahl = random.Next(1, 251);

int userZahl;
int versuche = 0;

do
{
    Console.Write("Gebe eine Zahl zwischen 1 und 250 ein: ");
    userZahl = Convert.ToInt32(Console.ReadLine());
    versuche++;
    if (gesuchteZahl == userZahl)
    {
        Console.WriteLine(userZahl + " ist die gesuchte Zahl.");
        Console.WriteLine("Du hast " + versuche + " Versuch(e) gebraucht.");
    }
    else if (userZahl < gesuchteZahl)
    {
        Console.WriteLine("Die gesuchte Zahl ist größer als " + userZahl);
    }
    else if (userZahl > gesuchteZahl)
    {
        Console.WriteLine("Die gesuchte Zahl ist kleiner als " + userZahl);
    }
    else
    {
        Console.WriteLine("Es wurde eine Zahl ausserhalb des Zahlenbereichs von 1 und 250 eingegeben.");
    }
}
while (userZahl != gesuchteZahl);
