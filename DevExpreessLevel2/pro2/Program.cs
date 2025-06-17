using System;

class Program
{
    static void Main()
    {
        //calc();
        //A_PalindromesReplace()

        //CheckPerfectNumber(Console.ReadLine())
        // CheckTo(Console.ReadLine());
        /*
        int rows = RandMatrix(3, 3).GetLength(0); // Get the number of rows
        int columns = RandMatrix(3, 3).GetLength(1); // Get the number of columns

        for (int i = 0; i < rows; i++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.WriteLine(RandMatrix(3, 3)[i,j]);
            }
        }*/
        //RArrivaloftheGeneral();
        // CDragons();
        LetterPattern();

    }





    static public void LetterPattern()
    {
        int count = int.Parse(Console.ReadLine());
        for(int i = 0; i < count; i++)
        {
            for(int j = 0; j <= i; j++)
            {
                Console.Write((char)(65 + i));
            }
            Console.WriteLine();
        }
    }




    static public void CDragons()
    {
        string[] inputs = Console.ReadLine().Split();
        int initStrength = int.Parse(inputs[0]);
        int count = int.Parse(inputs[1]);
        bool isWon = true;
        Dictionary<int, int> dataDic = new Dictionary<int, int>();
        // int[] dragonsStrenghts = new int[count];
        // int[] dragonsBonus = new int[count];

        for(int i = 0; i < count; i++)
        {
            string[] inpus = Console.ReadLine().Split();
            dataDic.Add(int.Parse(inpus[0]), int.Parse(inpus[1]));
            // dragonsStrenghts[i] = int.Parse(inpus[0]);
            // dragonsBonus[i] = int.Parse(inpus[1]);
        }
        // Array.Sort(dragonsStrenghts);
        // Array.Sort(dragonsBonus);
        Dictionary<int, int> sortedDictionary = dataDic.OrderBy(e => e.Key).ToDictionary(e => e.Key, e => e.Value);
        foreach(var item in  sortedDictionary)
        {
            if (initStrength > item.Key)
                initStrength += item.Value;
            else
            {
                isWon = false;
                break;
            }
        }

        Console.WriteLine(isWon ? "YES" : "NO");

    }





    static public void RArrivaloftheGeneral()
    {
        int num = int.Parse(Console.ReadLine());
        string[] inputs = Console.ReadLine().Split();
        int[] OriginalNums = Array.ConvertAll(inputs, int.Parse);
        int[] SortedNums = (int[]) OriginalNums.Clone();
        Array.Sort(SortedNums);
        int minVal = SortedNums[0];
        int maxVal = SortedNums[SortedNums.Length - 1];
        int maxCount = 0;
        int minCount = 0;
        for(int i = 0; i < OriginalNums.Length; i++)
        {
            if (OriginalNums[i] == maxVal)
                break;
            maxCount++;
            
        }
        for(int i = OriginalNums.Length - 1; i >= 0; i--)
        {
            if (OriginalNums[i] == maxVal && i == maxCount)
                continue;
            if (OriginalNums[i] == minVal)
                break;
            minCount++;
            
        }
        Console.WriteLine(minCount + maxCount);
    }



    static public int[,] RandMatrix(int rows, int columns)
    {
        var ran = new Random();
        int[,] randArr = new int[rows,columns];
        for(int i = 0; i < rows; i++)
        {
            for(int j = 0; j < columns; j++)
            {
                randArr[i, j] = ran.Next(0, 100);
            }
        }
        return randArr;
    }
    static public void CheckTo(string input)
    {
        for(int i = 2; i < int.Parse(input); i++)
        {
            if (CheckPerfectNumber(i.ToString()))
            {
                Console.WriteLine(i);
            }
        }
    }


    static public bool CheckPerfectNumber(string input)
    {
    
        int sum = 1;
        if(int.Parse(input) % 2 == 0)
        {
            for(int i = 2; i <= int.Parse(input) / 2; i++)
            {
                if(int.Parse(input) % i == 0)
                {
                    sum += i;
                }
            }
        }
        return sum == int.Parse(input);
        // Console.WriteLine( ? $"{sum} is Perfect": $"{sum} is Not Perfect");
    }
    static public void A_PalindromesReplace() 
    {
        string input = Console.ReadLine();
        string dataNoQu = "";
        int countOfQ = 0;

        for(int i = 0; i < input.Length; i++)
        {
            if (input[i] != '?')
            {
                dataNoQu += input[i];
            }
            else
            {
                countOfQ++;
            }
            
        }
        if (countOfQ == dataNoQu.Length)
        {
            for(int i = dataNoQu.Length - 1; i >= 0; i--)
            {
                dataNoQu += dataNoQu[i];
            }
            Console.WriteLine(dataNoQu);
        }
        else
        {
            Console.WriteLine(-1);

        }
    }









    static public void calc()
    {
        string[] input = Console.ReadLine().Split();
        int rows = int.Parse(input[0]);
        int columns = int.Parse(input[1]);
        int counter = 0;
        int takenRows = 0;
        int takenColumns = 0;
        char[,] chars = new char[rows, columns];
        for(int i = 0; i < rows; i++)
        {
            int countOfSPerRow = 0;
            string inputs = Console.ReadLine();
            for (int j = 0; j < columns; j++)
            {
                chars[i, j] = inputs[j];
                if (chars[i, j] == 'S')
                    countOfSPerRow++;
                
            }
            if (countOfSPerRow == 0)
            {
                counter += columns;
                takenRows++;
            }
        }

            for(int i = 0; i < columns; i++)
            {
                int countOfSPerColumn = 0;
                for (int j = 0; j < rows; j++)
                {
                    if (chars[j, i] == 'S')
                        countOfSPerColumn++;
                }
                if (countOfSPerColumn == 0)
                {
                    counter += rows;
                    takenColumns ++;
                }
            }

        
        // int res = counter - Math.Max(takenRows, takenColumns);
        Console.WriteLine(counter - (takenRows * takenColumns));
        // return counter - takenColumns;
    }

    static public int arrival()
    {
        int num = int.Parse(Console.ReadLine());
        string[] inputs = Console.ReadLine().Split();
        int[] nums = Array.ConvertAll(inputs, int.Parse);
        int c = 0;


        for (int i = 0; i < num; i++)
        {
            if (i != num - 1)
            {
                if (nums[i] <= nums[i + 1])
                {
                    int temp = nums[i];
                    nums[i] = nums[i + 1];
                    nums[i + 1] = temp;
                    c++;
                }
            }
        }
        return c;

    }

    static public void ca()
    {
        string[] input = Console.ReadLine().Split();
        int rows = int.Parse(input[0]);
        int columns = int.Parse(input[1]);
        int counter = 0;
        int totalCountOfS = 0;
        int takenRows = 0;
        int takenColumns = 0;
        char[,] chars = new char[rows, columns];
        for (int i = 0; i < rows; i++)
        {
            int countOfSPerRow = 0;
            string inputs = Console.ReadLine();
            for (int j = 0; j < columns; j++)
            {
                chars[i, j] = inputs[j];
                if (chars[i, j] == 'S')
                    countOfSPerRow++;
            }
            if (countOfSPerRow == 0)
            {
                counter += columns;
                takenRows++;
            }
        }

        for (int i = 0; i < columns; i++)
        {
            int countOfSPerColumn = 0;
            for (int j = 0; j < rows; j++)
            {
                if (chars[j, i] == 'S')
                    countOfSPerColumn++;
            }
            if (countOfSPerColumn == 0)
            {
                counter += rows;
                takenColumns++;
            }
        }

        
        // int res = counter - Math.Max(takenRows, takenColumns);
        Console.WriteLine(counter - takenColumns);
        // return counter - takenColumns;
    }




}
