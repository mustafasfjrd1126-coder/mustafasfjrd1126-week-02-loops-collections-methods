string transmission = "AX?19??Q";
int markerCount = 0;

// TODO: Bruk for og transmission[i].
 for (int i = 0; i < transmission.Length-1; i++)
 {
    if (transmission[i] == '?')
    {
        markerCount++;
        Console.WriteLine($"index of ? : {i}");
    }
 }

Console.WriteLine($"Marker count: {markerCount}");
