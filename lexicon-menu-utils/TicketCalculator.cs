namespace lexicon_menu_utils;

public class TicketCalculator
{
    public static void SinglePerson()
    {
        int guestAge = int.Parse(SanitizedInput.GetNumericInput("Please enter age: "));
        if (guestAge < 20)
            System.Console.WriteLine("Ticket price with youth discount: 80kr");
        else if (guestAge > 64)
            System.Console.WriteLine("Ticket price with pensioner discount: 90kr");
        else
            System.Console.WriteLine("Standard ticket price: 120kr");
    }

    public static void MultiPerson()
    {
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
                total += 80;
            else if (age > 64)
                total += 90;
            else
                total += 120;
        }
        System.Console.WriteLine(
            $"The number of people in your party is {guestCount}\nYour ticket total will be {total}kr\nEnjoy your movie!"
        );
    }
}
