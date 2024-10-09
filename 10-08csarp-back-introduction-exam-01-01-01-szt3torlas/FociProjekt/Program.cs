// Réteg közötti kapcsolat felépítése

using FociProjekt.Context;
using FociProjekt.Entities;
using FociProjekt.Repos;

// Adatbázis kezelés
AppDbContext appDbContext = new AppDbContext();

// A repo réteg ismeri a DbContext réteget, mert azon keresztül éri el a táblákat
FocistakRepo<Focista> focistakRepo = new FocistakRepo<Focista>(appDbContext);
FociKlubokRepo<FociKlub> fociKlubokRepo = new FociKlubokRepo<FociKlub>(appDbContext);

// Klubok létrehozása
DateTime datum = new DateTime(1902, 04, 16);
FociKlub realMadrid = new FociKlub(datum, "Real Madrid", 577.7);
FociKlub bayernMunchen = new FociKlub(new DateTime(1900, 02, 27), "Bayern Münhcen", 474.4);

// Focista létrehozása és adatbázishoz adása
Focista ramos = new Focista("Sergio Ramos", 4, 184, 82, true, realMadrid);
Focista hazard = new Focista("Eden Hazard", 7, 175, 74, true, realMadrid);
Focista courtois = new Focista("Thibaut Courtois", 1, 199, 96, false, realMadrid);

Focista pavard = new Focista("Benjamin Pavard", 5, 186, 76, true, bayernMunchen);
Focista lewandowski = new Focista("Robert Lewandowski", 9, 184, 80, true, bayernMunchen);
Focista kimich = new Focista("Joshua Kimmich", 6, 176, 73, true, bayernMunchen);

focistakRepo.Hozzad(ramos);
focistakRepo.Hozzad(hazard);
focistakRepo.Hozzad(courtois);

focistakRepo.Hozzad(pavard);
focistakRepo.Hozzad(lewandowski);
focistakRepo.Hozzad(kimich);

// Hány focistát tárolunk?
int focistakSzama = focistakRepo.GetFocistakSzama();
Console.WriteLine($"Focisák száma az adatbázisba: {focistakSzama} fő.");
// Törlés
focistakRepo.Torol(courtois);
focistakSzama = focistakRepo.GetFocistakSzama();
// Módosítás
Console.WriteLine($"Összes focista: {focistakSzama}. fő");
focistakRepo.Modosit(new Focista("Sergio Ramos", 9, 184, 82, true, realMadrid));

// Sikerült-e módosítani a focista adatait?
Focista? ujRamos = focistakRepo.KivalasztOsszesFocistat().Find(focista => focista.Nev == "Sergio Ramos");
if (ujRamos is not null)
    Console.WriteLine($"{ujRamos.Nev} új mezszama {ujRamos.Mezszam}.");

//FociKlub valami = new FociKlub("2024, 10, 08", "Valami Új", 256000000);



