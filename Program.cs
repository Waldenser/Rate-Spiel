namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int number = 0;
            int guess = 0;
            int guesses = 0;
            int max = 100;
            int min = 1;
            bool PlayAgain = true;
            bool IsNumber = true;
            string antwort;

            Console.WriteLine("------------");
            Console.WriteLine("Rate Spiel");
            Console.WriteLine("------------");

            while (PlayAgain)
            {
                guess = 0;
                guesses = 0;
                antwort = "";
                number = random.Next(min, max + 1);

                while (guess != number)
                {
                    Console.WriteLine("Rate eine Nummer zwischen " + min + " - " + max);
                    guess = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Rate: " + guess);

                    if (guess > number)
                    {
                        Console.WriteLine(guess + " ist zu Hoch");
                    }
                    else if (guess < number)
                    {
                        Console.WriteLine(guess + " ist zu Tief");
                    }
                    guesses++;
                }
                Console.WriteLine(guess + " ist die Richtige Nummer");
                Console.WriteLine("Versuche: " + guesses);
                Console.WriteLine("Möchtest du wieder spielen? (Y/N)");
                antwort = Console.ReadLine();
                antwort = antwort.ToUpper();

                if (antwort == "Y")
                {
                    PlayAgain = true;
                }
                else
                {
                    PlayAgain = false;
                }

            }

            Console.ReadKey();
        }
    }
}
