﻿// See https://aka.ms/new-console-template for more information
Console.WriteLine("Hvilken tabel vil du have?");
int tabel = Convert.ToInt32(Console.ReadLine());

for (int tal = 1; tal < 11; tal++)
{
    Console.WriteLine(tal * tabel);
}