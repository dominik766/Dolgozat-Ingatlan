using System;
using System.Collections.Generic;
using System.Text;

namespace Ingatlan
{
    internal class Ingatlan
    {
        // belso tarolok
        private int alapteruletM2;
        private int arEzerFt;
        private static int osszesRegisztraltIngatlan = 0;

        // tulajdonsagok
        public string Azonosito { get; set; }
        public string Cim {  get; set; }
        public string Kategoria { get; set; }
          // nem engedem, h 10-nel kevesebb legyen
        public int AlapteruletM2 { get => alapteruletM2; set => alapteruletM2 = value < 10 ? 10 : value; }
          // nem engedem, h 0-nal kevesebb legyen
        public int ArEzerFt { get => arEzerFt; set => arEzerFt = value < 0 ? 0 : value; }
        public static int OsszesRegisztraltIngatlan { get => osszesRegisztraltIngatlan; }

        // konstruktorok
        public Ingatlan(string azonosito, string cim, string kategoria, int alapteruletM2) : this(azonosito, cim, kategoria, alapteruletM2, alapteruletM2*500){}
        public Ingatlan(string azonosito, string cim, string kategoria, int alapteruletM2, int arEzerFt)
        {
            Azonosito = azonosito;
            Cim = cim;
            Kategoria = kategoria;
            AlapteruletM2 = alapteruletM2;
            ArEzerFt = arEzerFt;
            osszesRegisztraltIngatlan++;
        }

        // metodusok
        public override string ToString(){ return $"[{Azonosito}] {Cim} ({Kategoria}) - Terület: {AlapteruletM2} m2 | Ár: {ArEzerFt} ezer ft."; }
        public double NegyzetmeterAr(){ return (ArEzerFt * 1000.0) / AlapteruletM2; }
          //+
        public bool KategoriaEgyezik(string keresettKategoria){ if (keresettKategoria == Kategoria){ return true; } else { return false; }}
    }
}
