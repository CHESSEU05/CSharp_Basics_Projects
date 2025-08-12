// See https://aka.ms/new-console-template for more information

namespace NumberGuessingGame
{
    public class Program
    {
        public static void Main()
        {
            Console.WriteLine("-*-*-*-*-*-*-*-*-*-*-*-*-*-*-* CNT'S NUMBER GUESSIG GAME *-*-*-*-*-*-*-*-*-*-*-*-*-*-*-");
            Console.WriteLine();
            Console.Write("Hey, please enter your name: ");
            string name = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("You are welcome, " + name + " to our number guessing game.");
            Console.WriteLine();
            Console.WriteLine("This is a simple game where you will be asked to guess a random chosen number.");
            Console.WriteLine();
            Console.Write("Hey, please enter the range of numbers of the game (positive integer): ");
            int guessLimit = Convert.ToInt32(Console.ReadLine());
            if (guessLimit < 0)
            {
                guessLimit = Math.Abs(guessLimit);
                Console.WriteLine("Can't deal with negative numbers, hence guess limit is " + guessLimit + ".");
            }
            Random random = new Random();
            int number = random.Next(guessLimit + 1);
            int maxGuess = 0;
            if (guessLimit <= 50)
            {
                maxGuess = 5;
            }
            else if (guessLimit > 50 && guessLimit <= 100)
            {
                maxGuess = 7;
            }
            else if (guessLimit > 100 && guessLimit <= 500)
            {
                maxGuess = 10;
            }
            else
            {
                maxGuess = 15;
            }
            Console.WriteLine();
            Console.WriteLine("You will be required to guess the randomly chosen (btw 1 and " + guessLimit + " inclusively)");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("NOTE: You have a maximum of " + maxGuess + " chances in order to guess !!!");
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine();
            int guessCount = 0;
            int guess = 0;
            bool OutofGuess = false;

            do
            {
                if (guessCount > (maxGuess - 1))
                {
                    OutofGuess = true;
                    Console.WriteLine("You are out of guess. You can try next time " + name + ".");
                    break;
                }

                Console.Write("Enter a guess: ");
                guess = Convert.ToInt32(Console.ReadLine());
                guessCount++;

                if (guess < number)
                {
                    Console.WriteLine("Your guess is smaller than the answer. Try a larger value ...");
                    Console.WriteLine();
                }
                else if (guess > number)
                {
                    Console.WriteLine("Your guess is larger than the answer. Try a smaller value ...");
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("You Win ... Celebrate ... That's great, " + name + " !!!");
                    Console.WriteLine();
                }

            } while (guess != number && !OutofGuess);
        }
    }
}