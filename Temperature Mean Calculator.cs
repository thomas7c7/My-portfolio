//Lab5
//Grade ID: R2214
//Due: 3/6/2022
//CIS 199-02
//This program calculates the mean of the total temperatures the user inputs.
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;   // I added this code so i can use the WriteLine function.
namespace Lab5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WriteLine("Enter temperatures from -20 to 130 (999 to stop)"); 
            int total = 0; //Declaring the variables
            double number = 0;
            int enter = 0;
            double mean;

            while (enter != 999) //While the entered integer is not 999
            {
                    Write("Enter Temperature:");
                if (int.TryParse(ReadLine(), out enter))//Allows the user to input the temperature.
                if (enter >= -20 && enter <= 130)
                {
                    total++; // counts the times a user inputs a number.
                    number += enter;
                }
                else if (enter != 999)
                {
                    WriteLine("Valid temperatures range from -20 to 130. Please reenter temperature");
                }
            }
                    mean = number / total;  
                    WriteLine($"You entered {total} valid temperatures."); //Displays the total amount of times a user inputs the temperatures.
                    WriteLine($"The mean temperature is {mean:F1} degrees."); //Calculates the mean.
                    Console.ReadLine();
        }

    }
}
