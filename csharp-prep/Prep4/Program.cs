using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

class Program
{
    static void Main(string[] args)
    {
        List<int> numbers = new List<int>();
        Console.WriteLine("Enter a list of numbers, type 0 when finished.");
        Console.Write("Enter a number:");
        while (true)
        {
            int input = int.Parse(Console.ReadLine());
            if (input == 0)
            {
                break;
            }
            numbers.Add(input);
            Console.Write("Enter a number:");
        }

        int sum = 0;
        int max = 0;

        foreach (int number in numbers)
        {
            sum += number;

            if (number > max)
            {
                max = number;
            }

        }

        float average = ((float)sum) / numbers.Count;
        Console.WriteLine("The sum of the numbers is: " + sum);
        Console.WriteLine("The average of the numbers is: " + average);
        Console.WriteLine("The largest number is:" + max);

    }
}