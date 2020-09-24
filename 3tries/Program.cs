using System;

namespace _3tries
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            int randomNumber = rnd.Next(1, 11);
            int userInput;

            int counter = 0;

            while(counter < 3)
            {
                if(randomNumber == userInput)
                {
                    Console.WriteLine("Congratioilations, you win!");
                    break;
                }else
                {
                    Console.WriteLine("Try again!");
                    Console.WriteLine("what is my number?");
                    userInput = int.Parse(Console.ReadLine());

                    counter++;
                    Console.WriteLine($"you have guesse {counter}times.");
                }
            }    counter = counter + 1;
            Console.WriteLine($"you have guessed {counter} times");
        }
    }
}
