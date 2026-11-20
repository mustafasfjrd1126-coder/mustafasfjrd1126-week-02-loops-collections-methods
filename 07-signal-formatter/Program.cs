using System;
class Oppgave{

static string FormatSignal(string source)
{
    // TODO: Returner formatert string.
    return source.ToUpper();
}



static void Main(string [] args)
{
    
  Console.WriteLine(FormatSignal("moon-base"));
  Console.WriteLine(FormatSignal("relay-7"));
  Console.WriteLine(FormatSignal("cargo-deck"));
}
   


}