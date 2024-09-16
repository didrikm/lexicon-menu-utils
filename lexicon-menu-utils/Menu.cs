namespace lexicon_menu_utils;

public class Menu
{
    private string header;
    private List<string> options;
    private List<Action> actions;

    //Meny-konstruktor. Bygger ut menyn med menynamn och möjliga val.
    public Menu(string menuHeader, List<string> menuOptions, List<Action> menuActions)
    {
        if (menuOptions.Count != menuActions.Count)
        {
            throw new ArgumentException("The number of options and actions must be the same.");
        }

        header = menuHeader;
        options = menuOptions;
        actions = menuActions;
    }

    //Startar meny-loopen
    public void Run()
    {
        while (true)
        {
            Console.Clear();
            PrintMenu();
            string choice = Console.ReadLine() ?? string.Empty;

            if (choice == "0")
            {
                break;
            }
            else if (int.TryParse(choice, out int index) && index > 0 && index <= options.Count)
            {
                actions[index - 1].Invoke();
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please try again.");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }

    //Printar menyn
    private void PrintMenu()
    {
        System.Console.WriteLine(header);
        Console.WriteLine("Menu Options:");
        for (int i = 0; i < options.Count; i++)
        {
            Console.WriteLine($"{i + 1}. {options[i]}");
        }
        Console.WriteLine("0. Exit");
        Console.Write("\nEnter your choice: ");
    }
}
