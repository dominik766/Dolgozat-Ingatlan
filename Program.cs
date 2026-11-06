using Ingatlan;


List<Ingatlan.Ingatlan> ingatlan = new List<Ingatlan.Ingatlan>();


if (File.Exists("ingatlanok.txt")) 
{
    foreach (string aktsor in File.ReadAllLines("ingatlanok.txt"))
    {
        string[] adatok = aktsor.Split(';');
        if ( !string.IsNullOrWhiteSpace(aktsor) )
        {
            if (adatok.Count() == 4)
            {
                if (int.TryParse(adatok[3], out int AlapteruletM2)){
                    Ingatlan.Ingatlan aktualis = new Ingatlan.Ingatlan(adatok[0], adatok[1], adatok[2], AlapteruletM2);
                    ingatlan.Add(aktualis);
                } else { Console.WriteLine("hiba: helytelen adatok a sorban. sor átugorva."); continue; }
            } else if (adatok.Count() == 5)
            {
                if (int.TryParse(adatok[3], out int AlapteruletM2) &&
                    int.TryParse(adatok[4], out int ArEzerFt))
                {
                    Ingatlan.Ingatlan aktualis = new Ingatlan.Ingatlan(adatok[0], adatok[1], adatok[2], AlapteruletM2, ArEzerFt);
                    ingatlan.Add(aktualis);
                }
            }
        } else { Console.WriteLine("üres sor kiszűrve"); continue; }
    }
} else { Console.WriteLine("hiba: a fájl nem található"); }