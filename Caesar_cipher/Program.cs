using System.Text;
using System.Text.RegularExpressions;

namespace Caesar_cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var runTimes = 0;

            while (runTimes < 5)
            {
                try
                {
                    Console.WriteLine("Podaj klucz.");
                    int key = int.Parse(Console.ReadLine());

                    Console.WriteLine("Podaj tekst który chcesz zaszyfrować");
                    string text = Console.ReadLine().ToUpper();

                    var result = CaesarCipher.Encode(key, text);

                    Console.WriteLine(result);

                    Console.WriteLine("End? Y/N");
                    var end = Console.ReadLine().ToUpper().Equals("Y") ? runTimes = 5 : runTimes++;

                    Console.ReadKey();
                    Console.Clear();
                }
                catch (FormatException ex)
                {
                    Console.WriteLine("Klucz moze zawierac tylko i wylacznie wartosci liczbowe");
                }
                finally
                {
                    runTimes++;
                }
            }
        }
    }
}