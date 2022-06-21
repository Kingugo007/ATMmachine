public class Balance
{
    public static void balance(CardHolder UserInfo)
    {
        Console.Clear();
        Console.WriteLine("Current balance: " + UserInfo.balance);
        Console.WriteLine();
        Console.WriteLine("-----------------------------");
        FinalOption.options();
    }
}

