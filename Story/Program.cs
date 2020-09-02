using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework1
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program = new Program();

            //program.Story();
            //program.FloatMath();
            program.Convertion();
        }

        void Story()
        {
            //GET INFRO FROM USERS, Name, Age, Gender, City
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();

            Console.WriteLine("How old are you?");
            int age = int.Parse(Console.ReadLine());

            Console.WriteLine("Are you a boy or girl?");
            string gender = Console.ReadLine().ToLower();
            string pronoun1;
            string pronoun2;
            // Sets male pronoun if boy, female if girl and neutral if anything else is inputted.
            if (gender.Equals("boy"))
            {
                pronoun1 = "he";
                pronoun2 = "his";
            }
            else if (gender.Equals("girl"))
            {
                pronoun1 = "she";
                pronoun2 = "hers";            
            }
            else
            {
                pronoun1 = "they"; 
                pronoun2 = "their";
            }
            Console.WriteLine("Where are you from?");
            string city = Console.ReadLine();


            //PRINT STORY

            Console.WriteLine("Once upon a time there was a hero named " + name + ".");
            Console.WriteLine("On a fateful day " + pronoun1 + " got caught up in an adventure that would change " + pronoun2 + " life forever.");
            Console.WriteLine("Our hero met a magical cat named Whiskers.");
            Console.WriteLine("Whiskers asked 'Who are you?'.");
            Console.WriteLine("Our hero responded: 'I am " + name + ", I am here to save " + city + " from certain doom!");
            Console.WriteLine("The cat laughed. 'You think you have what it takes? You cant be much older than " + age + ", how would you acomplish anything?'");
            Console.WriteLine("'You are one to talk! I am " + (age - 8) + " years older than you I would have you know!' " + pronoun1 + " cried out in frustration.");
            Console.WriteLine("The cat smirked. 'Fine come with me...'");
            Console.WriteLine("");
            Console.WriteLine("End of chapter.");




            Console.ReadKey();
        }

        void FloatMath()
        {
            //GET 3 FLOAT NUMBERS
            Console.WriteLine("Input first float number:");
            float num1 = float.Parse(Console.ReadLine());

            Console.WriteLine("Input second float number:");
            float num2 = float.Parse(Console.ReadLine());

            Console.WriteLine("Input third float number:");
            float num3 = float.Parse(Console.ReadLine());

            //PRINT AVERAGE

            float total = num1 + num2 + num3;
            float average = total / 3;
            
            Console.WriteLine("Average: " + average);
            

            //SUM AND ROUND TO CLOSEST INT

            double sum = Math.Round(total);

            Console.WriteLine("Sum and Round: " + sum);

            Console.ReadKey();
        }

        void Convertion()
        {
            //GET NUMBER FROM USER
            Console.Write("Input number: ");
            int number = int.Parse(Console.ReadLine());

            // Meter to Yard
            float yard = number * 1.09361f;
            Console.WriteLine(number + " meter = " + yard + " yards");

            // Kilo to Pound
            float pound = number * 2.20462f;
            Console.WriteLine(number + " kg = " + pound + " lb");

            // Celcius to Fahrenheit
            float fahrenheit = (number * 9 / 5) + 32;
            Console.WriteLine(number + " Celsius = " + fahrenheit + " Fahrenheit = " + (number + 273.15) + " Kelvin");

            // KiloWatt to Horsepower
            float horsepower = number * 1.34102f;
            Console.WriteLine(number + " kilowatt = " + horsepower + " horsepower");

            //Degrees to Radian
            float radian = number * 0.0174533f;
            Console.WriteLine(number + " Degrees = " + radian + " Radians");

            Console.ReadKey();
        }
    }
}
