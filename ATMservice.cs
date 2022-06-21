using System.Security;
using System.Net;
public class ATMservice
{
    public static void ATM()
    {

        List<CardHolder> cardHolders = new List<CardHolder>();
        cardHolders.Add(new CardHolder("12345678", "John", "Doe", 15000.02, 1234));

        String debitCardNum = "";
        CardHolder currentUser;
        int userPin = 0;


        static SecureString maskString()
        {
            Console.WriteLine();
            Console.WriteLine("Enter Your Pin");
            SecureString pass = new SecureString();
            ConsoleKeyInfo keyInfo;

            do
            {
                keyInfo = Console.ReadKey(true);
                if (!char.IsControl(keyInfo.KeyChar))
                {
                    pass.AppendChar(keyInfo.KeyChar);
                    Console.Write("*");
                }
                else if (keyInfo.Key == ConsoleKey.Backspace && pass.Length > 0)
                {
                    pass.RemoveAt(pass.Length - 1);
                    Console.Write("\b \b");
                }
            }
            while (keyInfo.Key != ConsoleKey.Enter);
            {
                 return pass;
            }
        }


        while (true)
        {
            try
            {                
                debitCardNum = Console.ReadLine();
                currentUser = cardHolders.FirstOrDefault(a => a.cardNumber == debitCardNum);
                if (currentUser != null) { break; }
                else { Console.WriteLine("Card not recognized, enter a valid card"); }
            }
            catch { Console.WriteLine("Card not recognized, enter a valid card"); }
        }

        while (true)
        {
            try
            {
                SecureString pass = maskString();
                string Password = new NetworkCredential(string.Empty, pass).Password;
                //Console.ReadKey();
                userPin = int.Parse(Password);
                if (currentUser.pin == userPin) { break; }
                else 
                {
                    Console.WriteLine();
                    Console.WriteLine("Incorrent pin. Please try again");
                }
            }
            catch
            {
                Console.WriteLine();
                Console.WriteLine("Incorrent pin. Please try again"); 
            }

        }
        Console.WriteLine();
            Console.WriteLine("Welcome to .Net Bank system " + currentUser.firstName + " " + currentUser.lastName);
            Console.WriteLine();
            Console.WriteLine("----------------------------------------------------");
            Console.WriteLine();
            int option = 0;
            do
            {
                PrintOption.options();

                try
                {
                    option = int.Parse(Console.ReadLine());
                }
                catch { }
                if (option == 1) { Deposit.deposit(currentUser); }
                else if (option == 2) { Withdraw.withdraw(currentUser); }
                else if (option == 3) { Balance.balance(currentUser); }
                else if (option == 4) { break; }
                else { option = 0; }

            } while (option != 4);
            Console.WriteLine("Thank you! Have a nice day");
   
    }
}