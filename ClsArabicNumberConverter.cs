using DevExpress.Data.Filtering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestProj
{
    class ClsArabicNumberConverter
    {

        static string result = "";
        static int numInt;
        static int num7;
        static int num6;
        static int num5;
        static int num4;
        static int num3;
        static int num2;
        static int num1;
        static double fractionalPart;
        static int numFraction;
        static string fractionPart = "";
    public static string ArabicNumber(double numValue)
    {
        result = "";
        numInt = (int)Math.Floor(numValue);
        num7 = numInt / 1000000;
        num6 = (numInt % 1000000) / 100000;
        num5 = (numInt % 100000) / 10000;
        num4 = numInt / 1000;
        num3 = (numInt % 1000) / 100;
        num2 = (numInt % 100) / 10;
        num1 = numInt % 10;
        fractionalPart = numValue - numInt;
        numFraction = (int)Math.Round(fractionalPart * 100);
        fractionPart = ""; 

        if (num7 > 0)
        {
            if (num7 == 1)
                result += " مليون";

            else if (num7 == 2)
                result += " مليونان";

            else if (num7 == 10)
                result += " عشرة ملايين";

            else
                result += ArabicUnits(num7) + " ملايين";
        }
        if (num6 > 0)
        {
            if (result.Length > 0)
                result += " و ";
            result += (numInt % 1000 == 0) ? " " + ArabicHundreds(num6) : ArabicHundreds(num6); 
        }
        if (num5 == 1)
        {
            if (num4 == 10)
                result += ArabicTeens(num4 % 10) + " ألاف";
            if (result.Length > 0 && numInt > 11000)
                result += " و ";
            if ((num4 > 10 && num4 <= 19) || (num4 % 100 > 10 && num4 % 100 <= 19))
                result += ArabicTeens(num4 % 10) + " ألفا";    

        }
        else if (numInt >= 20000)
        {
            if (result.Length > 0 && num4 % 100 != 0)
                result += " و ";
            if (num4 > 0)
                if (num4 % 10 != 0)
                    result += num5 == 0 ? ArabicUnits(num4 % 10) + " الفا" : ArabicUnits(num4 % 10) + " و "; 
                else if (num4 % 100 == 0 && num7 <= 0)
                    result += " الفا";
            if (num5 > 0)
                result += ArabicTens(num5) + " الفا"; 

        }
        else if (num4 < 1000 && num4 > 0)
        {
            if (numInt % 1000 == 0)
                result += "ألف";
            else if (num4 == 1)
                result += "ألفا";
            else if (num4 == 2)
                result += "ألفان";
            else
                result += ArabicUnits(num4) + " ألاف"; 

        }

        if (num3 > 0)
        {
            if (result.Length > 0)
                result += " و ";
            result += ArabicHundreds(num3); 
        }



        if (num2 > 1)
        {
            if (result.Length > 0)
                result += " و ";
            if (num1 > 0)
                result += ArabicUnits(num1) + " و ";
            result += ArabicTens(num2); 
        }
        else if (num2 == 1)
        {
            if (result.Length > 0)
                result += " و ";
            result += ArabicTeens(num1); 
        }
        else if (num1 > 0)
        {
            if (result.Length > 0)
                result += " و ";
            result += ArabicUnits(num1);
        }

        if (result.Length == 0)
            result = "صفر";




        if (numFraction > 0)
        {
            int fractionTens = numFraction / 10;
            int fractionUnits = numFraction % 10;

            if (fractionUnits > 0)
            {
                string val = ArabicUnits(fractionUnits);
                if (fractionTens == 1)
                {
                    if (val == "واحد")
                        val = "أحد";
                    if (val == "اثنان")
                        val = "اثنا";

                }
                fractionPart += val; 
            }
            if (fractionTens > 0)
            {
                string val = ArabicTens(fractionTens);
                if (val == "عشر" && fractionUnits <= 0)
                    fractionPart += val;
                else if (val == "عشر")
                    fractionPart += " " + val;
                if (fractionUnits > 0 && val != "عشر")
                    fractionPart += " و " + val;
                if (val != "عشر" && fractionUnits <= 0)
                    fractionPart += val;
            }


            if (numFraction == 1)
                fractionPart += " قرش";
            else if (numFraction >= 2 && numFraction <= 10)
                fractionPart += " قروش";

            else
                fractionPart += " قرشا";
        }


        if (numValue > 2 && numValue < 11)
            result += " جنيهات";

        else
            result += " جنيها";


        if (!string.IsNullOrEmpty(fractionPart))
            result += " و " + fractionPart;

        return result;

    }

        public static string ArabicUnits(int num)
        {
            string[] aname = { "واحد", "اثنان", "ثلاثة", "أربعة", "خمسة", "ستة", "سبعة", "ثمانية", "تسعة" };
            return aname[num - 1];
        }

        public static string ArabicTens(int num)
        {
            string[] aname10 = { "عشر", "عشرون", "ثلاثون", "أربعون", "خمسون", "ستون", "سبعون", "ثمانون", "تسعون" };
            return aname10[num - 1];
        }

        public static string ArabicHundreds(int num)
        {
            string[] aname100 = { "مئة", "مئتان", "ثلاثمائة", "أربعمائة", "خمسمائة", "ستمائة", "سبعمائة", "ثمانمائة", "تسعمائة" };
            return aname100[num - 1];
        }

        public static string ArabicTeens(int num)
        {
            string[] aname = { "عشرة", "أحد عشر", "اثنا عشر", "ثلاثة عشر", "أربعة عشر", "خمسة عشر", "ستة عشر", "سبعة عشر", "ثمانية عشر", "تسعة عشر" };
            return aname[num];
        }

    }
}
