namespace lexicon_menu_utils;

public class ThirdWord
{
    public static void Run()
    {
        while (true)
        {
            Console.Clear();
            string[] splitInput = SanitizedInput
                .GetAlphabeticalWithSpaceInput("Please enter 3 or more words separated by spaces: ")
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);
            if (splitInput.Length > 2)
            {
                System.Console.WriteLine($"\n{splitInput[2]}");
                System.Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
                break;
            }
            else
            {
                System.Console.WriteLine("\nNeed more words...");
                System.Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }
}
