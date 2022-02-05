using System;

namespace Vezba21c
{
    internal class Ucenik:Osoba
    {
        public int razred;
        public override void Prikazi()
        {
            Console.WriteLine(ime + " " + prezime + " " + jmbg + " - " + razred);
        }
    }
}
