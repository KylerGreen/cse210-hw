using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomnumber = new Random();
        int magicnumber = randomnumber.Next(1, 101);
        Console.WriteLine("Guess the number between 1 nad 100!");
        bool guessed = false;

        while (!guessed)
        {   
            Console.WriteLine("What is your guess?");
            int numberguess = int.Parse(Console.ReadLine());
            if (numberguess == magicnumber)
            {
                Console.WriteLine("You guessed the magic number");
                guessed = true;
            }
            else if (numberguess < magicnumber)
            {
                Console.WriteLine("You guessed too low");
            }
            else
            {
                Console.WriteLine("You guessed too high");
            }
        }
    }
}