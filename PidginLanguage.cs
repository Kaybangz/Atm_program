using Atm_program;
using System;


//CLASS FOR PIDGIN LANGUAGE
public class PidginLanguage : ILanguagePrompts, IErrorMessages, ISuccessMessages
{
    public void welcomeMessage()
    {
        Console.WriteLine("\nWELCOME TO GENESYS BANK ATM PROGRAM");
    }

    public void enterPinPrompt()
    {
        Console.WriteLine("\nUse '6653' as your default pin to continue: ");
    }

    public void transactionPrompt()
    {
        Console.WriteLine("\nWhich transaction you go like carry out today?: " +
            "\n0 => Check akant balance " +
            "\t1 => Withdraw funds \n2 => Transfer funds " +
            "\t3 => Change language \n4 => Send airtime \t5 => Comot\n");
    }

    public void mainMenuPrompt()
    {
        Console.Write("Press 'Y' make you go back to main menu and 'N' to end program: ");
    }

    public void withdrawPrompt()
    {
        Console.WriteLine("\nEnter how much you go like withdraw: ");
    }

    public void transferPrompt()
    {
        Console.WriteLine("\nEnter how much you go like transfer: ");
    }

    public void recipientPrompt()
    {
        Console.WriteLine("\nEnter akant number of person way you wan transfer the money give: ");
    }

    public void pinSaved()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nYou pin na Ogbonge!");
        Console.ForegroundColor = ConsoleColor.White;
    }


    public void transferSuccessful(decimal transferredAmt, long recipient, decimal currentBalance)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nAmount transferred: {transferredAmt} \nRecipient: {recipient} \nCurrent Balance: {currentBalance}");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void depositSuccessful(decimal amount, decimal currentBalance)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nYou don deposit {amount} inside your akant \nCurrent balance: {currentBalance} ");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void withdrawalSuccessful(decimal amount, decimal currentBalance)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nYou don withdraw {amount} for inside your akant \nCurrent balance: {currentBalance} ");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void rechargeSuccessful(decimal transferredAmt, long recipient, decimal currentBalance)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nAirtime top up: {transferredAmt} \nRecipient: +234{recipient} \nCurrent Balance: {currentBalance}");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void pinNaN()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nNa only number you fit use as pin");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void incorrectPin()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nYour pin no correct, abeg enter the correct one");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void incorrectOptionSelect()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nAbeg, try calm down read the instructions wella");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void insufficientBalance()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nYour money no reach, we no fit continue");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void invalidNumber()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nAbeg enter correct number, no dy do like that");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void incorrectRecipient()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nEnter better akant number for recipient");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void airtimeAmountPrompt()
    {
        Console.Write("\nEnter the airtime amount: ");
    }

    public void airtimeRecipientPrompt()
    {
        Console.Write("Enter the recipient phone number: ");
    }
}