namespace Strings_Null_Asher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ask user to input a character
            Console.WriteLine("Enter a character:");
            char myChar = Console.ReadKey().KeyChar;

            // Check if the character is a letter
            bool isLetter = Char.IsLetter(myChar);

            // Print the result
            Console.WriteLine($"\n{myChar} is a letter: {isLetter}");

            // Ask user to input a string of words
            Console.WriteLine("\nEnter a string of words:");
            string string1 = Console.ReadLine();

            // Ask user to input a single word to search for
            Console.WriteLine("Enter a word to search for:");
            string string2 = Console.ReadLine();

            // Check if the string of words contains the word to search for
            bool containsWord = string1.Contains(string2);

            // Print the result
            Console.WriteLine($"{string2} exists in {string1}: {containsWord}");
        }
    }
}