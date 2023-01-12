using System;

class Program
{
    static void Main(string[] args)
    {
        Random randomGenerator = new Random();
        int specialinteger = randomGenerator.Next(1, 101);
        int guess = -1
        while (guess != specialinteger)
        {
            Console.Write("What is your guess for the random number between 1 and 101? ");
            guess = int.Parse(Console.ReadLine());
            if (specialinteger > guess)
            {
                Console.WriteLine("Higher");
            }
            else if (specialinteger < guess)
            {
                Console.WriteLine("lower");
            }
            else
            {
                Console.WriteLine('You guessed the correct number! Good job! ');
            }
        }
    }
}