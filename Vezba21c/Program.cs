using System;
using System.Collections.Generic;

namespace Vezba21c
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Ucenik ucenik1 = new Ucenik();
            ucenik1.ime = "Jovan";
            ucenik1.prezime = "Jovanovic";
            ucenik1.jmbg = "111";
            ucenik1.razred = 3;
            ucenik1.Prikazi();
            Profesor profesor1 = new Profesor();
            profesor1.ime = "Marko";
            profesor1.prezime = "Nikolic";
            profesor1.jmbg = "222";
            profesor1.godineStaza = 15;
            profesor1.Prikazi();
            profesor1.izracunajPlatu();
            Osoba[] osobe = new Osoba[5];
            osobe[0] = ucenik1;
            osobe[1] = profesor1;
            for (var i = 0; i < 2; i++)
                osobe[i].Prikazi();
            List<Osoba> listaOsoba = new List<Osoba>();
            listaOsoba.Add(ucenik1);
            listaOsoba.Add(profesor1);
            foreach (var item in listaOsoba)
                item.jmbg = "123";
            foreach (var item in listaOsoba)
            {
                item.Prikazi();
            }
        }
    }
}
