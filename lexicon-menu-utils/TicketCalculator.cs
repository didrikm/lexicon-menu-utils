namespace lexicon_menu_utils;

public class TicketCalculator
{
    //Gör en undermeny
    public static void MakeMenu()
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

    //Beräknar biljettpris för en person
    public static void SinglePerson()
    {
        Console.Clear();
        int guestAge = int.Parse(SanitizedInput.GetNumericInput("Please enter age: "));
        if (guestAge < 20)
        {
            if (guestAge < 5)
                System.Console.WriteLine("Children under 5 enter free of charge!");
            else
                System.Console.WriteLine("Ticket price with youth discount: 80kr");
        }
        else if (guestAge > 64)
            if (guestAge > 100)
                System.Console.WriteLine("Centenarians enter free of charge!");
            else
                System.Console.WriteLine("Ticket price with pensioner discount: 90kr");
        else
            System.Console.WriteLine("Standard ticket price: 120kr");

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }

    //Beräknar pris för ett sällskap
    public static void MultiPerson()
    {
        Console.Clear();
        int guestCount = int.Parse(
            SanitizedInput.GetNumericInput("Please enter number of people in your party: ")
        );

        List<int> guestAges = new(guestCount);
        for (int i = 0; i < guestCount; i++)
        {
            guestAges.Add(
                int.Parse(SanitizedInput.GetNumericInput($"Please enter age for guest {i + 1}: "))
            );
        }
        int total = 0;
        foreach (int age in guestAges)
        {
            if (age < 20)
                if (age < 5)
                    continue;
                else
                    total += 80;
            else if (age > 64)
                if (age > 100)
                    continue;
                else
                    total += 90;
            else
                total += 120;
        }
        Console.Clear();
        System.Console.WriteLine(
            $"The number of people in your party is {guestCount}\nYour ticket total will be {total}kr\nEnjoy your movie!"
        );

        Console.WriteLine("\nPress any key to continue...");
        Console.ReadKey();
    }
}
