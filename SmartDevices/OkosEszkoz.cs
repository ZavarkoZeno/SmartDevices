using System;
using System.Collections.Generic;
using System.Text;

namespace SmartDevices
{
    public abstract class OkosEszkoz
    {
        public string Nev { get; set; }
        public string Gyarto { get; set; }
        public bool Bekapcsolva { get; set; }

        public OkosEszkoz(string nev, string gyarto)
        {
            Nev = nev;
            Gyarto = gyarto;
            Bekapcsolva = false;
        }

        public void Bekapcsol()
        {
            Bekapcsolva = true;
            Console.WriteLine($"{Nev} bekapcsolva.");
        }
    }
}
