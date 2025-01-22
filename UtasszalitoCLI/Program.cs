using System.Security.Cryptography;
using UtasszalitoCLI;

List<Sebesseg> sebessegek = new();
List<Utasszalito> utasSzallitok = new();

const string DIR = "H:\\repos\\Utasszalito\\src";

using (StreamReader sr = new($"{DIR}\\utasszallitok.txt"))
{
    sr.ReadLine();
    while (!sr.EndOfStream)
    {
        string[] sor = sr.ReadLine().Split(';');
        string tipus = sor[0];
        int ev = int.Parse(sor[1]);
        string szemelyzet = sor[3];
        string[] s = sor[2].Split('-');
        int utasMin = 0;
        int utasMax;
        if (s.Length == 2)
        {
            utasMin = int.Parse(s[0]);
            utasMax = int.Parse(s[1]);
        } else
        {
            utasMax = int.Parse(s[0]);
        }

 
        int sebesseg = int.Parse(sor[4]);
        int tomeg = int.Parse(sor[5]);
        double fesztav = double.Parse(sor[6]);
        
        sebessegek.Add(new Sebesseg(sebesseg));
        utasSzallitok.Add(new Utasszalito(tipus, ev, szemelyzet, utasMin, utasMax, sebesseg, tomeg, fesztav));

    }
}

Console.WriteLine($"4. feladat\n{sebessegek.Count}db adatsor van");

Console.WriteLine($"5. feladat\n{utasSzallitok.Where(r => r.tipus.Contains("Boeing")).Count()}db Boeing gép van");

Utasszalito f6 = utasSzallitok.OrderByDescending(r => r.utasMax).First();

Console.WriteLine($"6.feladat\nA legtöbb utast szállító repülőgép:" +
    $"\n\tTípus: {f6.tipus}" +
    $"\n\tElső felszállás: {f6.ev}" +
    $"\n\tUtasok száma: {f6.utasMin}-{f6.utasMax}" +
    $"\n\tSzemélyzet: {f6.szemelyzet}" +
    $"\n\tUtazósebesség: {f6.sebesseg}");


Dictionary<string, int> group = new Dictionary<string, int> { { "Alacsony sebességű", 0 }, { "Szubszonikus", 0 }, { "Transzszonikus", 0 }, { "Szuperszonikus", 0 } };

foreach (var item in sebessegek)
{
    group[item.Kategorianev]++;
}

Console.WriteLine("7.feladat");
foreach (var item in group)
{
    if (item.Value == 0)
    {
        Console.Write($"{item.Key} ");
    }
}


using(StreamWriter sw = new("utasszalitok_new.txt"))
{
    sw.WriteLine("típus;év;utas;személyzet;utazósebesség;felszállótömeg;fesztáv");
    foreach (var gep in utasSzallitok)
    {
        sw.WriteLine($"{gep.tipus};{gep.ev};{gep.utasMax};{gep.szemelyzet};{gep.sebesseg};{gep.tomeg/1000};{Math.Round(gep.fesztav * 3.2808)}");
    }
}