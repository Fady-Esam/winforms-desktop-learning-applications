

class Program
{
    static void Main()
    {
        int[,] ar2 =  { {5 , 6}, {9, 2}, {1, 4} };
        for(int i = 0; i < ar2.GetLength(0); i++)
        {
            for(int j = 0;  j < ar2.GetLength(1); j++)
            {
                Console.WriteLine(ar2[i, j]);
            }
        }
    }
}




