using System;

namespace NumbersGame
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Random random = new Random();

            int number = random.Next(1, 20);

            Console.WriteLine("Välkommen! Jag tänker på ett nummer. Kan du gissa vilket? Du får fem försök.");

            // run as long as user input is equal to random number or 5 attempts

            int count = 0;
            while (count != 5)
            {
              
                String input = Console.ReadLine();

                int choice = int.Parse(input);

                if (number == choice)
                {
                    Console.WriteLine("Wohoo! Du klarade det!");
                    break;
                }
                else if (choice < number)
                {
                    Console.WriteLine("Tyvärr, du gissade för lågt!");
                    count++;
                }
                else if (choice > number)
                {
                    Console.WriteLine("Tyvärr, du gissade för högt!");
                    count++;
                }
                
                if (count == 5)
                {
                    Console.WriteLine("Tyvärr, du lyckades inte gissa talet på fem försök!");
                }
            }
        }
    }
}