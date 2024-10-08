using System.Text.RegularExpressions;

namespace lexicon_menu_utils;

public class SanitizedInput
{
    //loopar tills användaren matat in något som stämmer överens med respektive regex
    public static string GetAlphabeticalInput(string message)
    {
        string input;
        do
        {
            Console.Write(message);
            input = Console.ReadLine() ?? "";
        } while (!IsAlphabetical(input));

        return input;
    }

    public static string GetAlphabeticalWithSpaceInput(string message)
    {
        string input;
        do
        {
            Console.Write(message);
            input = Console.ReadLine() ?? "";
        } while (!IsAlphabeticalWithSpace(input));

        return input;
    }

    public static string GetAlphanumericInput(string message)
    {
        string input;
        do
        {
            Console.Write(message);
            input = Console.ReadLine() ?? "";
        } while (!IsAlphanumeric(input));

        return input;
    }

    public static string GetNumericInput(string message)
    {
        string input;
        do
        {
            Console.Write(message);
            input = Console.ReadLine() ?? "";
        } while (!IsNumeric(input));

        return input;
    }

    public static string GetAlphaScandinavianInput(string message)
    {
        string input;
        do
        {
            Console.Write(message);
            input = Console.ReadLine() ?? "";
        } while (!IsAlphaScandinavian(input));

        return input;
    }

    private static bool IsAlphabetical(string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;

        string pattern = @"^[a-zA-Z]+$";
        return Regex.IsMatch(input, pattern);
    }

    private static bool IsAlphabeticalWithSpace(string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;

        string pattern = @"^[a-zA-Z\s]+$";
        return Regex.IsMatch(input, pattern);
    }

    private static bool IsAlphanumeric(string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;

        string pattern = @"^[a-zA-Z0-9]+$";
        return Regex.IsMatch(input, pattern);
    }

    private static bool IsNumeric(string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;

        string pattern = @"^[0-9]+$";
        return Regex.IsMatch(input, pattern);
    }

    private static bool IsAlphaScandinavian(string input)
    {
        if (string.IsNullOrEmpty(input))
            return false;

        string pattern = @"^[a-zA-ZåäöÅÄÖæøåÆØÅ]+$";
        return Regex.IsMatch(input, pattern);
    }
}
