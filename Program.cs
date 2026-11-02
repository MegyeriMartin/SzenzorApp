using SzenzorApp;

List<Szenzor> szenzorok = new List<Szenzor>();
int hibasSorokSzama = 0;

string fajlNev = "szenzorok.txt";

string[] sorok = File.ReadAllLines(fajlNev);

foreach (string sor in sorok.Skip(1))
{

    if (string.IsNullOrWhiteSpace(sor))
    {
        hibasSorokSzama++;
        continue;
    }
}


Console.WriteLine($"Sikeresen beolvasott szenzotok száma:{sorok.Count()}");
Console.WriteLine($"Kszűrt hibás sorok száma:{hibasSorokSzama}");
Console.WriteLine($"Szenzor példányok száma (static):{Szenzor.OsszesSzenzorSzama}");