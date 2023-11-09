//Grade ID: R2214
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam2_S22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] years = { 2010, 2011, 2012, 2013, 2014, 2015, 2016, 2017, 2018, 2019, 2020 };
            double[] inflationRates = { 1.64, 3.16, 2.07, 1.46, 1.62, 0.12, 1.26, 2.13, 2.44, 1.81, 1.23 };
            double[] annualChanges = { 2.00, 1.52, -1.09, -0.60, 0.16, -1.50, 1.14, 0.87, 0.31, -0.63, -0.58 };
            //I manually changed inflationrates and annualchanges because i had problems with decimal places 
            int Years;
            double Inflationrate = 0;
            double annualchange = 0;
            bool isYearValid = false;

            Console.WriteLine("Enter year:" );
            Years = Convert.ToInt32(Console.ReadLine());
            for (int i = 0; i < years.Length; i++)
            {
                if (Years == years[i])
                {
                    isYearValid = true;
                    Inflationrate = inflationRates[i];
                    break;
                }
            }
            for (int x = 0; x < years.Length; x++)
            {
                if (Years == years[x])
                {
                    isYearValid = true;
                    annualchange = annualChanges[x];
                    break; 
                }
            }
            if (isYearValid)
            {
                Console.WriteLine("In the year {0} the inflation rate was {1}% with an annual change of {2}% from the previous year.", Years, Inflationrate, annualchange);
            }
            else
            {
                Console.WriteLine("Sorry, no data for {0}.", Years);
            }
            Console.ReadLine();
        }
    }
}
