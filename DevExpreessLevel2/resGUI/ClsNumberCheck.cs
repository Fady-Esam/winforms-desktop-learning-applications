using DevExpress.Utils.Html.Internal;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Math;

namespace resGUI
{

    class ClsNumberCheck
    {
        static double sixtyPercentageValue;
        static double fourtyPercentageValue;
        static double val1;
        static double val2;
        static List<double> values2 = new List<double>();
        static int i = -1;
        static double sumValues;
        static Stack<double> stack;
        static double currentNumber;
        static DataTable table;
        static int count;
        static double modVal;
        //static double v1;
        //static double v2;
        //static double? testValue = null;

        public static void CheckNumber(double number)
        {
            if (number > 25)
            {
                sixtyPercentageValue = ((double)60 / (double)100) * number;
                fourtyPercentageValue = ((double)40 / (double)100) * number;

                while (sixtyPercentageValue > 25)
                {
                    sixtyPercentageValue = ((double)60 / (double)100) * sixtyPercentageValue;
                }

                while (fourtyPercentageValue > 25)
                {
                    fourtyPercentageValue = ((double)40 / (double)100) * fourtyPercentageValue;
                }

            }
        }
        static bool end = false;
        public static double CheckNum(double number)
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
                CheckNum(val1);
            }
            i++;
            if (i < values2.Count)
            {
                CheckNum(values2[i]);
            }

            return double.Parse(sumValues.ToString("F2"));

        }


        public static DataTable Chek(double number)
        {
            DataTable table = new DataTable();

            table.Columns.Add("Amount", typeof(double));

            sumValues = 0; 
            stack = new Stack<double>();
            stack.Push(number);
            while (stack.Count > 0)
            {
                currentNumber = stack.Pop();
                if (currentNumber <= 25000 /*&& currentNumber >= 20000*/)
                {
                    // these numbers less than 25 and their total will be the main Value that passed first
                    // sumValues += currentNumber;
                    table.Rows.Add(double.Parse(currentNumber.ToString("F2")));
                }
                else
                {
                     val1 = 0.6 * currentNumber;
                     val2 = 0.4 * currentNumber;

                    if (val2 > 25000)
                    {
                        stack.Push(val2); 
                    }
                    else
                    {
                        // these numbers less than 25 and their total will be the main Value that passed first
                        // sumValues += val2;
                        
                        table.Rows.Add(double.Parse(val2.ToString("F2")));
                    }

                    stack.Push(val1);
                }

            }
            return CheckDuplication(table);
            // return double.Parse(sumValues.ToString("F2"));
        }
        public static DataTable CheckDuplication(DataTable table)
        {
            double minValue = table.AsEnumerable()
                    .Min(row => row.Field<double>("Amount"));
            List<double> duplicates = table.AsEnumerable()
                      .GroupBy(row => row.Field<double>("Amount"))
                      .Where(group => group.Count() > 1)
                      .Select(group => group.Key).ToList();
            int indexOfMin = 0;
            int c = 0;
            if (duplicates.Count > 0)
            {
                for (int i = 0; i < table.Rows.Count; i++)
                {
                    for (int j = 0; j < duplicates.Count; j++)
                    {
                        if ((double)table.Rows[i]["Amount"] == duplicates[j] && duplicates.Count - c == 1)
                        {
                            table.Rows[i]["Amount"] = duplicates[j] - 1000;
                            c++;
                        }
                    }
                    if ((double)table.Rows[i]["Amount"] == minValue)
                    {
                        indexOfMin = i;
                    }
                }
                for (int i = 0; i < c; i++)
                {
                    table.Rows[indexOfMin]["Amount"] = minValue + 1000;
                }
                // CheckDuplication(table);
            }
            return table;
        }

        public static DataTable NumChck(double Number)
        {
             count = Convert.ToInt32(Number) / 24900;
                table = new DataTable();
                table.Columns.Add("Amount", typeof(double));
            modVal = Number % 24900;
            if (count == 0)
            {
                table.Rows.Add(double.Parse(Number.ToString("F2")));
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    table.Rows.Add(double.Parse(24900.ToString("F2")));
                }
            }
            if (table.Rows.Count == 1 && Number > 24900)
            {
                table.Rows.Add(double.Parse(modVal.ToString("F2")));
            }
            else if (table.Rows.Count > 1)
            {
                if (modVal != 0)
                {
                    for (int i = 0, j = 0; i < table.Rows.Count; i++)
                    {
                        table.Rows[i]["Amount"] = (double)table.Rows[i]["Amount"] + double.Parse((modVal / table.Rows.Count).ToString("F2"));

                        if (i % 2 == 0 && i != table.Rows.Count - 1)
                        {
                            j++;
                            table.Rows[i]["Amount"] = (double)table.Rows[i]["Amount"] - (j * 500);
                            table.Rows[i + 1]["Amount"] = (double)table.Rows[i + 1]["Amount"] + (j * 500);
                            // table.Rows[table.Rows.Count - 1]["Amount"] = (double)table.Rows[table.Rows.Count - 1]["Amount"] + (1 * 1000);
                        }

                    }

                    /*
                    table.Rows.Add(double.Parse((Number % 24900).ToString("F2")));
                    for (int i = 0; i < table.Rows.Count - 1; i++)
                    {
                        if (i != table.Rows.Count - 2)
                        {
                            table.Rows[i]["Amount"] = (double)table.Rows[i]["Amount"] - ((i + 1) * 1000);
                            // table.Rows[i + 1]["Amount"] = (double)table.Rows[i + 1]["Amount"] + ((i + 1) * 1000);
                            table.Rows[table.Rows.Count - 1]["Amount"] = (double)table.Rows[table.Rows.Count - 1]["Amount"] + ((i + 1) * 1000);
                        }
                    }*/
                }
                else
                {
                    for (int i = 0, j = 0; i < table.Rows.Count; i++)
                    {

                        if (i % 2 == 0 && i != table.Rows.Count - 1)
                        {
                            j++;
                            table.Rows[i]["Amount"] = (double)table.Rows[i]["Amount"] - (j * 500);
                            table.Rows[i+1]["Amount"] = (double)table.Rows[i+1]["Amount"] + (j * 500);
                            // table.Rows[table.Rows.Count - 1]["Amount"] = (double)table.Rows[table.Rows.Count - 1]["Amount"] + (1 * 1000);
                        }
                        
                    }
                }
            }
            return table;
        }

        public static DataTable NumChck2(double Number, double NumDiv)
        {
            count = Convert.ToInt32(Convert.ToInt32(Number) / NumDiv);
            table = new DataTable();
            table.Columns.Add("Amount", typeof(double));
            modVal = Number % NumDiv;
            if (count == 0)
            {
                table.Rows.Add(double.Parse(Number.ToString("F2")));
            }
            else
            {
                for (int i = 0; i < count; i++)
                {
                    table.Rows.Add(double.Parse(NumDiv.ToString("F2")));
                }
            }
            if (table.Rows.Count == 1 && Number > NumDiv)
            {
                table.Rows.Add(double.Parse(modVal.ToString("F2")));
            }
            else if (table.Rows.Count > 0)
            {
                if (modVal != 0 && false)
                {
                  for (int i = 0, j = 0; i < table.Rows.Count; i++)
                  {
                        table.Rows[i]["Amount"] = (double)table.Rows[i]["Amount"] + double.Parse((modVal / table.Rows.Count).ToString("F2"));

                        if (i % 2 == 0 && i != table.Rows.Count - 1)
                        {
                            j++;
                            table.Rows[i]["Amount"] = (double)table.Rows[i]["Amount"] - (j * 500);
                            table.Rows[i + 1]["Amount"] = (double)table.Rows[i + 1]["Amount"] + (j * 500);
                            // table.Rows[table.Rows.Count - 1]["Amount"] = (double)table.Rows[table.Rows.Count - 1]["Amount"] + (1 * 1000);
                        }

                  }

                    /*
                    table.Rows.Add(double.Parse((Number % 24900).ToString("F2")));
                    for (int i = 0; i < table.Rows.Count - 1; i++)
                    {
                        if (i != table.Rows.Count - 2)
                        {
                            table.Rows[i]["Amount"] = (double)table.Rows[i]["Amount"] - ((i + 1) * 1000);
                            // table.Rows[i + 1]["Amount"] = (double)table.Rows[i + 1]["Amount"] + ((i + 1) * 1000);
                            table.Rows[table.Rows.Count - 1]["Amount"] = (double)table.Rows[table.Rows.Count - 1]["Amount"] + ((i + 1) * 1000);
                        }
                    }*/
                }
                else
                {
                    for (int i = 0, j = 0; i < table.Rows.Count; i++)
                    {

                        if (i % 2 == 0 && i != table.Rows.Count - 1)
                        {
                            j++;
                            table.Rows[i]["Amount"] = (double)table.Rows[i]["Amount"] - (j * 500);
                            table.Rows[i + 1]["Amount"] = (double)table.Rows[i + 1]["Amount"] + (j * 500);
                            // table.Rows[table.Rows.Count - 1]["Amount"] = (double)table.Rows[table.Rows.Count - 1]["Amount"] + (1 * 1000);
                        }

                    }
                }
            }
            return table;
        }













        //public static void CheckNum(double number)
        //{
        //    if (number > 25)
        //    {
        //        val1 = getSixty(number);
        //        val2 = getFourty(number);       
        //    }
        //    if (val1 > 25)
        //    {
        //        if (val2 > 25)
        //        {
        //            CheckN(val2);
        //        }
        //        CheckNum(val1);   
        //    }
        //}
        //public static void CheckN(double number)
        //{
        //    if (number > 25)
        //    {
        //        v1 = getSixty(number);
        //        v2 = getFourty(number);
        //        if (testValue == null)
        //        {
        //            testValue = v1;
        //        }
        //    }
        //    if (v1 > 25)
        //    {
        //        CheckN(v1);
        //    }
        //    if (testValue > 25)
        //    {
        //        CheckNum((double)testValue);
        //    }
        //}


        //public static double getSixty(double num)
        //{   
        //    return 0.6 * num;
        //}
        //public static double getFourty(double num)
        //{
        //    return 0.4 * num;
        //}
    }
}
