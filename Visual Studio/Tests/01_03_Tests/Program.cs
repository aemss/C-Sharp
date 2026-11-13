
void Matris() 
{
    int c = 1;
    int n = 3;
    int m = 5;
    int[,] matris = new int[n,m];

    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            matris[i, j] = c;
            c++;
        }
    }
    for (int i = 0; i < n; i++)
    {
        for (int j = 0; j < m; j++)
        {
            Console.Write(matris[i,j] + "\t");
        }
        Console.WriteLine();
    }
}

Matris();

    

    


