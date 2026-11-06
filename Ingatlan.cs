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
        public int OsszesRegosztraltIngatlan { get => osszesRegisztraltIngatlan; }

    }
}
