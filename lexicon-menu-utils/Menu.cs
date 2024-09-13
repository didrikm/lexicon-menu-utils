namespace lexicon_menu_utils;

public class Menu
{
    private string header;
    private List<string> options;
    private List<Action> actions;
    private bool isRunning;

    public Menu(string menuHeader, List<string> menuOptions, List<Action> menuActions)
    {
        if (menuOptions.Count != menuActions.Count)
        {
            throw new ArgumentException("The number of options and actions must be the same.");
        }

        header = menuHeader;
        options = menuOptions;
        actions = menuActions;
        isRunning = true;
    }

    public void Run()
    {
        while (isRunning)
        {
            Console.Clear();
            PrintMenu();
            string choice = Console.ReadLine() ?? string.Empty;

            if (choice == "0")
            {
                isRunning = false;
            }
            else if (int.TryParse(choice, out int index) && index > 0 && index <= options.Count)
            {
                actions[index - 1].Invoke();
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
            else
            {
                Console.WriteLine("\nInvalid input. Please try again.");
                Console.WriteLine("\nPress any key to continue...");
                Console.ReadKey();
            }
        }
    }

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
