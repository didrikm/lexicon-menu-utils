namespace lexicon_menu_utils;

//TODO Kanske ska byta Action till Func för att kunna returna
//Skapar en config för att på ett smidigt sätt kunna bygga nya menyer
public class MenuConfig
{
    //Hade kunnat göra en class wrapper för dessa två, men känns lite overkill
    public List<string> Options { get; private set; }
    public List<Action> Actions { get; private set; }

    public MenuConfig()
    {
        Options = new List<string>();
        Actions = new List<Action>();
    }

    public void AddOption(string option, Action action)
    {
        Options.Add(option);
        Actions.Add(action);
    }
}
