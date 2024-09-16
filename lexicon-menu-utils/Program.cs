namespace lexicon_menu_utils;

public class Program
{
    public static void Main(string[] args)
    {
        //skapar config för huvudmenyn, lägger till de tre alternativen
        MenuConfig mainMenuConfig = new MenuConfig();
        mainMenuConfig.AddOption("Calculate ticket price", TicketCalculator.MakeMenu);
        mainMenuConfig.AddOption("10x word", WriteTenTimes.Run);
        mainMenuConfig.AddOption("Third bird is the word", ThirdWord.Run);
        //skapar menyn och kör den
        Menu mainMenu = new Menu("Main menu\n", mainMenuConfig.Options, mainMenuConfig.Actions);
        mainMenu.Run();
        //rensar och säger hej då när meny-loopen brutits
        Console.Clear();
        Console.WriteLine("\nGoodbye!");
    }
}
