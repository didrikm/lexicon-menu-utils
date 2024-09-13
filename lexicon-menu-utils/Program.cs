namespace lexicon_menu_utils;

public class Program
{
    public static void Main(string[] args)
    {
        MenuConfig mainMenuConfig = new MenuConfig();
        // mainMenuConfig.AddOption("Add Employee", AddEmployee);
        // mainMenuConfig.AddOption("Delete Employee", DeleteEmployee);
        // mainMenuConfig.AddOption("Show All Employees", ShowAllEmployees);

        mainMenuConfig.AddOption("Calculate ticket price", CalculateTicket);

        Menu mainMenu = new Menu("Main menu\n", mainMenuConfig.Options, mainMenuConfig.Actions);
        mainMenu.Run();
        Console.WriteLine("\nGoodbye!");
    }

    // private static void AddEmployee()
    // {
    //     Console.WriteLine("Adding employee...");
    //     string hej = SanitizedInput.GetAlphaScandinavianInput("Enter a swedish name: ");
    //     System.Console.WriteLine($"hej is {hej}");
    // }

    private static void CalculateTicket()
    {
        MenuConfig ticketMenuConfig = new MenuConfig();
        ticketMenuConfig.AddOption("Calculate for one person", TicketCalculator.SinglePerson);
        Menu ticketMenu = new Menu(
            "Ticket menu\n",
            ticketMenuConfig.Options,
            ticketMenuConfig.Actions
        );
        ticketMenu.Run();
    }

    // private static void ShowAllEmployees()
    // {
    //     Console.WriteLine("Showing all employees...");
    // }
}
