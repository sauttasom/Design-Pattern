using FlyweightPattern;

ChampionsFactory championsFactory = new ChampionsFactory(); 
ChampionsCollection championsCollection = new ChampionsCollection();


string[] championsAb = new string[] { "ESSENCE THEFT", "ORB OF DECEPTION", "FOX-FIRE", "SPIRIT RUSH" };
championsCollection.AddChampion("M", "DYNASTY AHRI", "AHRI", championsAb, championsFactory);

championsAb = new string[] { "SONIC WAVE", "SAFEGUARD", "TEMPEST", "DRAGON'S RAGE" };
championsCollection.AddChampion("J", "GOD FIST LEE SIN AHRI", "LEE SIN", championsAb, championsFactory);

championsAb = new string[] { "STEEL TEMPEST", "WIND WALL", "SWEEPING BLADE", "LAST BREATH" };
championsCollection.AddChampion("M", "YASUO TURE DAMANG", "YASUO", championsAb, championsFactory);

Console.WriteLine(championsCollection.ShowInfoChampions());
