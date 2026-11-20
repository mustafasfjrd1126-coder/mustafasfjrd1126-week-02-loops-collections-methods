using System.Runtime.InteropServices;

List<string> crew = new List<string> { "Bex", "Ivo", "Nia" };

// TODO: Endre listen etter instruksjonene.

Console.WriteLine($"Crew count: {crew.Count}");

crew.Add("Mira");
crew.Add("Sol");
crew.Remove("Bex");

Console.WriteLine($"Crew count: {crew.Count}");

foreach (var item in crew)
{
    Console.WriteLine(item);
}


// TODO: Skriv alle navn med en løkke.

// Start med listen i Program.cs og gjør dette i rekkefølge:

// Legg til "Mira" og "Sol".
// Fjern "Bex".
// Skriv antall personer med .Count.
// Iterer over den ferdige listen og skriv alle navn.
// Bruk List<string>, Add, Remove og Count.

