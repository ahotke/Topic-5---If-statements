using System.Runtime.CompilerServices;

namespace Topic_5___If_statements
{
    internal class Program2
    {
        static void Main(string[] args)
        {
            int age;
            string magicWord;
            double temp;

            // The Magic Word
            Console.Write("What's the magic word? ");
            magicWord = Console.ReadLine().ToLower();
            if (magicWord == "please")
                Console.WriteLine("You're welcome!");
            else
                Console.WriteLine("Incorrect");

            Console.WriteLine();


            // How Old Are You?
            Console.Write("Please enter your age: ");
            Int32.TryParse(Console.ReadLine(), out age);
            Console.WriteLine();
            if (age < 16) {
                Console.WriteLine("You can't drive");
            }

            if (age < 18 && age >= 16)
            {
                Console.WriteLine("You can't vote");
            }

            if (age < 25 && age >= 18)
            {
                Console.WriteLine("You can't rent a car");
            }

            if (age >= 25)
            {
                Console.WriteLine("You can do anything legal");
            }

            //Will it freeze?
            Console.WriteLine("What is the freezing temperature of water?");
            (Console.ReadLine(), out temp);
            Math.Round(temp, 2);

            if (temp == 0);
            Console.WriteLine("0 degrees celsius is correct");

            if (temp == 0);
            Console.WriteLine("32 degrees fahrenheit is correct");

            if (temp == 0);
            Console.WriteLine("273.2 degrees kelvin is correct");


        }
    }
}
