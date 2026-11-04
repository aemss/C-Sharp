
var cities = new List<string> { "" +
    "izmir",
    "İzmir", 
    "Isparta", 
    "Isparta", 
    "isparta", 
    "Istanbul",
    "istanbul",
    "samsun",
    "van",
    "adana"
};

// Ordinal sıralama
var ordinalSorted = new List<string>(cities);
ordinalSorted.Sort(StringComparer.Ordinal);

foreach (var ordinal in ordinalSorted)
{
    Console.WriteLine(ordinal);
}

// CurrentCultureIgnoreCase
Console.WriteLine($"\n{new string('-',10)}");

var culturedSorted = new List<string>(cities);
culturedSorted.Sort(StringComparer.Ordinal);

foreach (var ordinal in ordinalSorted)
{
    Console.WriteLine(ordinal);
}

Console.ReadKey();
