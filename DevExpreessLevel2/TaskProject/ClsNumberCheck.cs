using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TaskProject
{
    class ClsNumberCheck
    {
        static double sixtyPercentage;
        static double fourtyPercentage;
        static double val1;
        static double val2;
        public static void CheckNumber(double number)
        {
            if (number > 25)
            {
                sixtyPercentage = (60 / 100) * number;
                fourtyPercentage = (40 / 100) * number;


                while (sixtyPercentage > 25)
                {
                    sixtyPercentage = (60 / 100) * sixtyPercentage;
                }             

                while (fourtyPercentage > 25)
                {
                    fourtyPercentage = (40 / 100) * fourtyPercentage;
                }
                
            }
        }
        public static void CheckNum(double number)
        {
            if(number > 25)
            {
                val1 = getSixty(number);
                val2 = getFourty(number);
            }
            if(val1 > 25)
            {
                CheckNum(val1);
            }
            if (val1 > 25)
            {
                CheckNum(val1);
            }

        }
        public static double getSixty(double  num)
        {
            return (60 / 100) * num;
        }
        public static double getFourty(double num)
        {
            return (40 / 100) * num;
        }
    }
}
