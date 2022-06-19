/*
Higher Lower Game Program
Rony Richard
*/
using System;

namespace Program
{
    class Program //Sorry Only One Class. I managed to make the Point System Run based on whenever the Program Restarted So I failed to find a need for a Second Class.
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            bool Restart = true;
            int min = 1;
            int max = 13;
            int guess;
            int number;
            int points;
            String response;

            while (Restart)
            {
                guess = 0;
                points = 300;
                response = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Guess a number between " + min + " - " + max + " : ");
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Guess: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " is to high! Try Again.");
                        points -= 75;

                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " is to low! Try Again");
                        points -= 75;
                    }
                    //Basically for my point tracking. Every time they loop through one of the two "Try Again" Messages 75 points will be deducted. Everytime they get past the loop, 100 points will be added.
                }
                Console.WriteLine("Number: " + number);
                Console.WriteLine("Congratulations, You guessed the Number Properly!");
                points += 100;
                Console.WriteLine("Points: " + points);

                Console.WriteLine("Play Again? (Y/N): ");
                response = Console.ReadLine();
                response = response.ToUpper();

                if (response == "Y")
                {
                    Restart = true;
                }
                else
                {
                    Restart = false;
                }
            }

            Console.WriteLine("Thanks for playing!");

            Console.ReadKey();
        }
    }
}