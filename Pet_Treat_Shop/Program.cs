using Pet_Treat_Shop;
using System;
using static System.Console;
class Program
{
    public static void Main()
    {
        Treats treatShop = new Treats();
        //bool quit = false;
        //do
        //{
            WriteLine("Enter the number of biscuits: ");
            treatShop.amountOfBiscuits = int.Parse(ReadLine());
            WriteLine("Enter the number of chewies: ");
            treatShop.amountOfChewies = int.Parse(ReadLine());
            WriteLine("Enter the number of vitamins: ");
            treatShop.amountOfVitamins = int.Parse(ReadLine());
            WriteLine("Please enter the bucket size [Normal,Large]: ");
            treatShop.SetBucketSize(ReadLine().ToUpper());
            WriteLine("Is it the weekend? [Y = yes / N = no]: ");
            treatShop.SetWeekend(ReadLine().ToUpper());
            WriteLine(treatShop.CalculateAmount());
        //    WriteLine("If want to quit press 1 or enter: ");
        //    if (readline() == "1")
        //    {
        //        quit = true;
        //    }
        //} while (quit == false);
    }
}

