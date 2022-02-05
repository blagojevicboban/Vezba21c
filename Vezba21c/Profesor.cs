using System;

namespace Vezba21c
{
    internal class Profesor:Osoba, IRadnik
    {
        public int godineStaza;

        public void izracunajPlatu()
        {
            Decimal zarada =  10000 * 4.5M * (1 +godineStaza / 100M);
            Console.WriteLine("Zarada=" + zarada);
        }

        public override void Prikazi()
        {
            Console.WriteLine(ime + " " + prezime + " " + jmbg + " - " + godineStaza);
        }
    }
}
