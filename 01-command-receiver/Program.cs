while (true)
{
    Console.WriteLine("Command: ");
    string command = Console.ReadLine();

    // TODO: Avslutt med break når command er EXIT eller null.
    // TODO: Ellers skriv Received: <command>.
       if (command == "EXIT" || command == " ")
       {
        break;
       }
       Console.WriteLine($"Received: {command}");


}
Console.WriteLine("Receiver stopped.");