using _2024_10_07_J_doga;



List<Verseny> versenyzok = new List<Verseny>();

StreamReader sr = new StreamReader("forras.txt");



while (!sr.EndOfStream)
{
    string[] line = sr.ReadLine().Split(";");
    Verseny versenyzo = new Verseny();

    versenyzo.Nev = line[0];
    versenyzo.szuletesiev = 2024 - int.Parse(line[1]);
    versenyzo.rajtszam = int.Parse(line[2]);
    versenyzo.nem = line[3];
    versenyzo.evkategoria = line[4];
    versenyzo.UszasIdeje = TimeSpan.ParseExact(line[5], "hh\\:mm\\:ss", null);
    versenyzo.elsodepobantoltottido = TimeSpan.ParseExact(line[6], "hh\\:mm\\:ss", null);
    versenyzo.kerekparozasideje = TimeSpan.ParseExact(line[7], "hh\\:mm\\:ss", null);
    versenyzo.masodikdepobantoltottido = TimeSpan.ParseExact(line[8], "hh\\:mm\\:ss", null);
    versenyzo.futasideje = TimeSpan.ParseExact(line[9], "hh\\:mm\\:ss", null);

    versenyzok.Add(versenyzo);
}
sr.Close();

Console.WriteLine($"1.Feladat:\n{versenyzok.Count} versenyző fejezte be a versenyt.");


int VersenyzokSzama = 0;
foreach (var versenyzo in versenyzok)
{
 
    if (versenyzo.szuletesiev >= 25 && versenyzo.szuletesiev <= 29);
    VersenyzokSzama = VersenyzokSzama + 1;
}
Console.WriteLine($"2.Feladat:\nVersenyzők száma '25-29' korkategóriaban {VersenyzokSzama} db");


int Ossz = versenyzok.Sum(d => d.szuletesiev);

float versenyzokAtlag = Ossz / (float)versenyzok.Count;
Console.WriteLine($"3.Feladat:\nVersenyzők átlagéletkora: {versenyzokAtlag,0:00}");


float  atlag = 0;
foreach (var versenyzo in versenyzok)
{
  

    for (int i = 0; i < versenyzok.Count; i++)
    {
        if (versenyzo.evkategoria == "elit")
        {
            atlag = atlag + versenyzo.evkategoria / versenyzok.Count;
        }
    }
}



int min = 0;
for (int i = 1; i < versenyzok.Count; i++)
{
    if (versenyzok[i].UszasIdeje > versenyzok[min].UszasIdeje)
    {
        min = i;
    }
}

Console.WriteLine($"6.Feladat:\nFérfi győztes: {versenyzok[min].Name}");
