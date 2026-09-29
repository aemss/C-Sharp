
// örnekler 
var a = "İstanbul";
var b = "istanbul";
var c = "Istanbul";

Console.WriteLine("== vs Equals");
Console.WriteLine($"{a} == {b} ? {a==b}");



Console.WriteLine($"Equals ({a }, {b}, OrdinalIgnoreCase) ? " + 
    $"{string.Equals(a,b, StringComparison.OrdinalIgnoreCase)}"); // harf duyarsızlaştırma

Console.WriteLine($"Equals ({a}, {b}, CurrentCultureIgnoreCase) ? " +
    $"{string.Equals(a, b, StringComparison.CurrentCultureIgnoreCase)}");
Console.WriteLine($"Equals ( {a}, {b},CurrentCulture) ? " +
    $"{string.Equals( a,c, StringComparison.CurrentCulture)}");



Console.ReadKey();
