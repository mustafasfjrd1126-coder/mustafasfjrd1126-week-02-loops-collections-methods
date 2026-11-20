

static int CalculateFuel(int distance, int fuelPerUnit, int reserve)
{
    // TODO
    int Drivstoffbehov = distance * fuelPerUnit + reserve;

    return Drivstoffbehov;
}

Console.WriteLine(CalculateFuel(10, 3, 5));
Console.WriteLine(CalculateFuel(0, 4, 12));
Console.WriteLine(CalculateFuel(7, 2, 0));







