﻿namespace lexicon_menu_utils;

public class Program
{
    public static void Main(string[] args)
    {
        MenuConfig mainMenuConfig = new MenuConfig();

        mainMenuConfig.AddOption("Calculate ticket price", CalculateTicket);

        Menu mainMenu = new Menu("Main menu\n", mainMenuConfig.Options, mainMenuConfig.Actions);
        mainMenu.Run();
        Console.Clear();
        Console.WriteLine("\nGoodbye!");
    }

    private static void CalculateTicket()
    {
        MenuConfig ticketMenuConfig = new MenuConfig();
        ticketMenuConfig.AddOption("Calculate for one person", TicketCalculator.SinglePerson);
        ticketMenuConfig.AddOption("Calculate for party", TicketCalculator.MultiPerson);
        Menu ticketMenu = new Menu(
            "Ticket menu\n",
            ticketMenuConfig.Options,
            ticketMenuConfig.Actions
        );
        ticketMenu.Run();
    }
}
