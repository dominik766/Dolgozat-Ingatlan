using Ingatlan;
List<Ingatlan.Ingatlan> ingatlan = new List<Ingatlan.Ingatlan>();
Console.WriteLine("program elindult!");
Console.WriteLine(" ");
if (File.Exists("ingatlanok.txt")){
    foreach (string aktsor in File.ReadAllLines("ingatlanok.txt")){
        string[] adatok = aktsor.Split(';');
        if (!string.IsNullOrWhiteSpace(aktsor)){
            if (adatok.Count() == 4) {
                if (int.TryParse(adatok[3], out int AlapteruletM2)){
                    Ingatlan.Ingatlan aktualis = new Ingatlan.Ingatlan(adatok[0], adatok[1], adatok[2], AlapteruletM2);
                    ingatlan.Add(aktualis);}
                else { Console.WriteLine($"[HIBA] A(z) {adatok[0]} azonosítójú ingatlan adatai hibásak, átugorva! "); continue; }}
            else if (adatok.Count() == 5){
                if (int.TryParse(adatok[3], out int AlapteruletM2) &&
                    int.TryParse(adatok[4], out int ArEzerFt)){
                    Ingatlan.Ingatlan aktualis = new Ingatlan.Ingatlan(adatok[0], adatok[1], adatok[2], AlapteruletM2, ArEzerFt);
                    ingatlan.Add(aktualis);}
                else { Console.WriteLine($"[HIBA] A(z) {adatok[0]} azonosítójú ingatlan adatai hibásak, átugorva! "); continue; }}
            else { continue; }}}
    Console.WriteLine(" ");
    Console.WriteLine("Ingatlannyilvántartás: ");
    foreach (Ingatlan.Ingatlan ingatlanok in ingatlan) { Console.WriteLine(ingatlanok.ToString()); }
    Console.WriteLine(" ");
    Console.WriteLine($"Regisztrált ingatlanok száma a rendszerben: {Ingatlan.Ingatlan.OsszesRegisztraltIngatlan} db");
    Console.WriteLine(" ");
    Console.WriteLine("Lakás Kategóriájú Ingatlanok");
        // Console.WriteLine($"{Ingatlan.Ingatlan.KategoriaEgyezik("Lakás")}");   ...???
    Console.WriteLine("-");
    Console.WriteLine(" ");
    //legnagyobb alapteruletu ingatlan
    Ingatlan.Ingatlan legnagyobb_alapterulet = ingatlan.MaxBy(x => x.AlapteruletM2);
    Console.WriteLine($"Legnagyobb alapterületű ingatlan: {legnagyobb_alapterulet}");
    // vagyonszerzesi adoja
        // Console.WriteLine($"Fizetendő vagyonszerzési illeték (4%): {Adokalkulator.VagyonszerzesiAdo(legnagyobb_alapterulet[4])}");   ...?
    // atlagos negyzetmeterar
        // ...?
}


