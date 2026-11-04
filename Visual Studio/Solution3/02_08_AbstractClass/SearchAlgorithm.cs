
namespace AbstractClass;

public abstract class SearchAlgorithm
{
    protected int[] numbers;

    public SearchAlgorithm(params int[] numbers)
    {
        this.numbers = new int[numbers.Length];
        for (int i = 0; i < numbers.Length; i++)
        {
            this.numbers[i] = numbers[i];
        }
    }

    public abstract int Search(int target);
    
    protected void PrintMessage(string message)
    {
        Console.WriteLine(message);
    }

    public void PrintResult(int index,int target)
    {
        if (index == -1) //aranan eleman bulunamadı 
            PrintMessage($"{target} bulunamadı. ");
        else
            PrintMessage($"{target} {index}. indekste bulundu. ");
    }

}




