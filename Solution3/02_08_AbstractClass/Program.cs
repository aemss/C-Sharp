
using AbstractClass;

//var SearchAlgorithm = new SearchAlgorithm(10,20,30,40,50,60);

SearchAlgorithm searcher;

searcher = new LinearSearch(3, 7, 15, 20, 28, 35, 42);
Console.WriteLine("Doğrusal Arama");
int result1 = searcher.Search(20);
searcher.PrintResult(result1, 20);

searcher = new BinarySearch(3, 7, 15, 20, 28, 35, 42);
Console.WriteLine("İkili Arama");
int result2 = searcher.Search(42);
searcher.PrintResult(result2, 42);


