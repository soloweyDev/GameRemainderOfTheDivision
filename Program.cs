/*
A program is required for a computer game. The user keys in the number of rounds he wishes to play.
For each round the user enters his lucky number. The program takes the number and divides it with a
secret number. If the remainder of the division is zero, it is considered a draw for the round and the total
score is incriminated by 1. Otherwise if it is any other even number, it is considered a win for the round
and the total score is incremented by 3. However if it is an odd number, it is considered a loss for the
round and the total score is decremented by 3. This is done until he completes his rounds. He wins if the
total score at the end is a positive number.
*/

using System;

namespace GameRemainderOfTheDivision
{
    class Program
    {
        static void Main()
        {
            Random random = new Random();
            byte count = 0;
            string readLine;
            sbyte score = 0;

            Console.WriteLine("How much rounds do you want to play? (1-10)");
            bool noExit = true;
            do
            {
                readLine = Console.ReadLine();
                try
                {
                    count = byte.Parse(readLine);
                    if (count > 0 && count < 11)
                    {
                        noExit = false;
                    }
                    else
                    {
                        Console.WriteLine("You input a number outside the range of 1 to 10. Input a number between 1 and 10.");
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("You input not a number. Input a number between 1 and 10.");
                }
            }
            while (noExit);

            Console.WriteLine($"You will play {count} rounds.");
            for (byte i = 0; i < count;)
            {
                int numberPlayer = 0;
                int randomNumber = random.Next(1, 10);

                Console.WriteLine($"Rounds {++i}.");
                do
                {
                    Console.WriteLine("Input a number between 1 and 100.");
                    readLine = Console.ReadLine();
                    try
                    {
                        numberPlayer = int.Parse(readLine);
                        if (numberPlayer > 0 && numberPlayer < 100)
                        {
                            noExit = false;
                        }
                        else
                        {
                            Console.WriteLine("You input a number outside the range of 1 to 100. Input a number between 1 and 100.");
                        }
                    }
                    catch (Exception)
                    {
                        Console.WriteLine("You input not a number. Input a number between 1 and 100.");
                    }
                } while (noExit);

                int remainder = numberPlayer % randomNumber;

                if (remainder == 0)
                {
                    score += 1;
                }
                else
                {
                    if (remainder % 2 == 0)
                    {
                        score += 3;
                    }
                    else
                    {
                        score -= 3;
                    }
                }
            }

            if (score < 0)
            {
                Console.WriteLine("You lose");
            }
            else
            {
                Console.WriteLine("You win");
            }

            Console.WriteLine("Press any key to exit.");
            Console.ReadKey();
        }
    }
}
