public class Withdraw
{
    public static void withdraw(CardHolder UserInfo)
    {
        Console.Clear();
        Console.WriteLine("Enter Amount: ");
        double withdraw = double.Parse(Console.ReadLine());
        // CHECK IF THE USER HAS ENOUGH MONEY
        if (UserInfo.balance < withdraw)
        {
            Console.WriteLine("Withdraw: Insufficient balance :(");
        }
        else
        {
            UserInfo.balance = UserInfo.balance - withdraw;
            Console.WriteLine("Withdraw: You transaction is completed");

        }
        Console.WriteLine();
        Console.WriteLine("-----------------------------");
        FinalOption.options();
    }
}

