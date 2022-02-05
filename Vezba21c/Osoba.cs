using System;

namespace Vezba21c
{
    internal class Osoba
    {
        public string ime;
        public string prezime;
        public string jmbg;
        public virtual void Prikazi()
        {
            Console.WriteLine(ime + " " + prezime + " " + jmbg);
        }
    }
}
