using System;

namespace GuessTheNumberGame
{
    class Program
    {
        static void Main(string[] args)
        {
            PLAYER:
            Console.WriteLine("Pick a number between 1 - 100");
            Console.ReadLine();

            int x = 50;
            int min = 0;
            int max = 100;
            int i = 0;
            Random r = new Random();
            while (i < 5)
            {
                Console.WriteLine("According computer the number is {0}", x);
                Console.WriteLine("Is this true? (higher or less or equal) h/l/e");
                switch (Console.ReadKey(true).KeyChar)
                {
                    case 'l':
                        if (i == 3)
                        {
                            x = r.Next(min, x);
                        } else {
                            max = x;
                            x -= (max - min) / 2;
                        }
                        break;
                    case 'h':
                        if(i == 3)
                        {
                            x = r.Next(x + 1, max);
                        } else {
                            x += (max - min) / 2;
                        }
                        break;
                    case 'e':
                        Console.WriteLine("Computer won!!");
                        goto END;
                    default:
                        Console.WriteLine("Wrong input!!");
                        break;
                }
                ++i;
            }
            Console.WriteLine("The computer couldn't guess the number.");
            goto END;

            END:
            Console.WriteLine("\nDo you want to play again? y/n");
            switch (Console.ReadKey(true).KeyChar)
            {
                case 'y': goto PLAYER;
                case 'n': break;
                default: goto END;
            }
        }
    }
}