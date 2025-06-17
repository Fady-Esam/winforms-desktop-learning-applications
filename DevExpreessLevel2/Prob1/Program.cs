
using System;

class Program
{
    static void Main()
    {
        string n1 = Console.ReadLine();
        string n2 = Console.ReadLine();
        string n3 = Console.ReadLine();
        int maxV = Math.Max(Convert.ToInt32(n1), Convert.ToInt32(n2));
        int maxVal = Math.Max(maxV, Convert.ToInt32(n3));
        int minV = Math.Min(Convert.ToInt32(n1), Convert.ToInt32(n2));
        int minVal = Math.Min(minV, Convert.ToInt32(n3));
        int middleValue = (maxV + minV + Convert.ToInt32(n3)) - (maxVal + minVal);
        Console.WriteLine((maxVal - middleValue) + (middleValue - minVal));
    }
}






