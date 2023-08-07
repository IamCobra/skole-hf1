using System.Security.Cryptography.X509Certificates;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // 

            Console.WriteLine(AbsolutValue(-36));

            Console.WriteLine(Divisable(7, 12));

            // Herunder har jeg opgaven, store og små bogstaver beregener

            Console.WriteLine(tjek("pil"));
            Console.WriteLine(tjek("ABC"));
            Console.WriteLine(tjek("gul"));

        }
        
        static int AbsolutValue(int value) // Denne funktion tjekker om tallet er minus. Og hvis den er så ganger den tallet med minus for at det bliver et positivt tal
        {
            if (value < 0)
            {
                value = value * (-1);
            }

            return value;
        }

        static int Divisable(int firstValue, int secondValue) // Ved denne funktion har jeg lavet en if statement.
        {
            int result;
            bool isTrue = false; // jeg har lavet en bool som vi siger er false

            if (secondValue % 2 == 0 || secondValue % 3 == 0) // Her tjekker jeg om secondValue kan divideres med 2 eller 3, ved at bruge modulus for at være sikker på at resten er ligemed 0.
            {
                isTrue = true;
            }

            if ((firstValue % 2 == 0 || firstValue % 3 == 0) && isTrue == true) // Her gør vi noget lignende udover her tjekker vi bare om det vi gjorde før er sandt.
            {
                result = firstValue * secondValue;
            }
            else
            {
                result = firstValue + secondValue; // hvis vores value ikke kan divideres med 2 eller 3 fortæller vi den at den skal plusse det sammen.
            }

            return result;

        }

        static bool tjek(string storeOrd) // I denne opgave skal vi lave en metode der tjekker om der er store bogstaver eller små."
        {
            if (storeOrd.Length == 3)
            {
                foreach (char c in storeOrd)
                {
                    if (char.IsUpper(c))
                        return true;


                }
                return false;


            }
            else { return false; } 
        }

    }
}