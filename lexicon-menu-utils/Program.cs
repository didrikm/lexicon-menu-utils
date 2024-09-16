namespace lexicon_menu_utils;

public class Program
{
    public static void Main(string[] args)
    {
        MenuConfig mainMenuConfig = new MenuConfig();
        mainMenuConfig.AddOption("Calculate ticket price", TicketCalculator.MakeMenu);
        mainMenuConfig.AddOption("10x word", WriteTenTimes.Run);
        mainMenuConfig.AddOption("Third bird is the word", ThirdWord.Run);
        Menu mainMenu = new Menu("Main menu\n", mainMenuConfig.Options, mainMenuConfig.Actions);
        mainMenu.Run();
        Console.Clear();
        Console.WriteLine("\nGoodbye!");
    }
}
