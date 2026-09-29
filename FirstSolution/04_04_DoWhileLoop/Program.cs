


int[] grades = new int[3];

// sayaç

int i = 0;

// en az 1 kez çalıştıktan sonra while döngüsü devreye girer
do
{
    Console.WriteLine("Not giriniz: ");

    grades[i] = Convert.ToInt32(Console.ReadLine());
    i++; 

    
} while (i < grades.Length);

Console.WriteLine("Girilen Notlar: ");

int sum = 0;


foreach (int grade in grades)
{
    Console.WriteLine(grade);
    sum += grade;

}

int average = sum / grades.Length;

Console.WriteLine("\nOrtalama:");
Console.WriteLine(average);



Console.ReadKey();

