using System;

namespace temp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Converting the Temperature

            Console.WriteLine("Welcome to the Temperature Converter.");

            Console.WriteLine("Enter temperature in degrees: ");

            double faren = Convert.ToDouble(Console.ReadLine());

            double celcius = (faren - 32) * 5 / 9;

            Console.WriteLine("The temperature in celcius is: " + celcius);


            //Figuring tax

            Console.WriteLine("Welcome to the Michigan Tax Calculator.");

            Console.WriteLine("Enter before tax price: ");

            double price = Convert.ToDouble(Console.ReadLine());

            double tax = price * .06;

            Console.WriteLine("The sales tax is: " + tax);

            //Tip calculator

            Console.WriteLine("Welcome to the Tip Calculator.");

            Console.WriteLine("Enter total bill price: ");

            double billTotal = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter tip percentage in whole number: ");

            double tip = Convert.ToDouble(Console.ReadLine());

            double total = (billTotal) * (tip / 100) + billTotal;

            double tipCost = (tip / 100) * billTotal;

            Console.WriteLine("Your total with tip is: " + total + ". " + "The tip is: " + tipCost);

            //Bill dividends

            Console.WriteLine("Welcome to the Bill Splitter.");

            Console.WriteLine("Enter bill total: ");

            double amount = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter number of people: ");

            double people = Convert.ToDouble(Console.ReadLine());

            double split = amount / people;

            Console.WriteLine("Each person owes: " + split);




            Console.ReadLine();
        }
    }
}
