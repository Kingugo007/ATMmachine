public class Deposit
{
    public static void deposit(CardHolder UserInfo)
    {
        Console.Clear();
        Console.WriteLine("Deposit: How much would you like to deposit");
        double deposit = double.Parse(Console.ReadLine());
        UserInfo.balance = UserInfo.balance + deposit;
        Console.WriteLine("Deposit: Thank you for banking with us. You new balance is: " + UserInfo.balance);
        Console.WriteLine();
        Console.WriteLine("----------------------------------------------------------------------------------");       
        FinalOption.options(); 

    }
}

