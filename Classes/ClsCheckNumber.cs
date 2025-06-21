using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{

    class ClsCheckNumber
    {
        static double val1;
        static double val2;
        static List<double> values2 = new List<double>();
        static int i = -1;
        static double sumValues = 0;
        public static double CheckNumber(double number)
        {
            if (number < 25)
            {
                // these numbers less than 25 and their total will be the main Value that passed first
                sumValues += number;
            }
            else
            {
                val1 = 0.6 * number;
                val2 = 0.4 * number;
                if (val2 > 25)
                {
                    values2.Add(val2);
                }
                else
                {
                    sumValues += val2;
                }
                CheckNumber(val1);
            }
            i++;
            if (i < values2.Count)
            {
                CheckNumber(values2[i]);
            }
            return double.Parse(sumValues.ToString("F2"));

        }
    }

}
