namespace lexicon_menu_utils;

public class WriteTenTimes
{
    public static void Run()
    {
        Console.Clear();
        string input = SanitizedInput.GetAlphabeticalInput(
            "Enter a word that will then be printed ten times: "
        );
        for (int i = 0; i < 10; i++)
        {
            System.Console.Write($"{i + 1}. {input} ");
        }

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}
