string[] planetCodes = { "ORION-4", "KAPPA-9", "LYRA-2", "NOVA-7", "VEGA-3" };
bool found = false;

// TODO: Skriv Length, første og siste element.
// TODO: Finn KAPPA-9 med en løkke.
for (int i = 0; i < planetCodes.Length-1; i++)
{
found = (planetCodes[i]=="KAPPA-9") ? found : !found;
}
Console.WriteLine(planetCodes[0]);
Console.WriteLine(planetCodes[planetCodes.Length - 1]);
Console.WriteLine($"Length of the planetCodes : {planetCodes.Length}");

Console.WriteLine($"Found KAPPA-9: {found}");
