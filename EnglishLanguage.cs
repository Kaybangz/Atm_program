using Atm_program;
using System;


//CLASS FOR ENGLISH LANGUAGE
public class EnglishLanguage : ILanguagePrompts, IErrorMessages, ISuccessMessages
{
    public void welcomeMessage()
    {
        Console.WriteLine("\nWELCOME TO THE GENESYS BANK ATM PROGRAM");
    }

    public void enterPinPrompt()
    {
        Console.WriteLine("\nUse the default pin '6653' to continue: ");
    }

    public void transactionPrompt()
    {
        Console.WriteLine("\nWhat transaction would you like to carry out:" +
            " \n0 => Check account balance \t1 => Withdraw funds " +
            "\n2 => Transfer funds \t\t3 => Change language \n4 => Send airtime " +
            "\t\t5 => Exit\n");
    }

    public void mainMenuPrompt()
    {
        Console.Write("Press 'Y' to return to main menu and 'N' to end program: ");
    }


    public void withdrawPrompt()
    {
        Console.WriteLine("\nEnter amount you would like to withdraw: ");
    }

    public void transferPrompt()
    {
        Console.WriteLine("\nEnter amount you would like to transfer: ");
    }

    public void recipientPrompt()
    {
        Console.WriteLine("\nEnter account number of recipient: ");
    }


    public void pinSaved()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nPin saved successfully!");
        Console.ForegroundColor = ConsoleColor.White;
    }


    public void transferSuccessful(decimal transferredAmt, long recipient, decimal currentBalance)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nAmount transferred: {transferredAmt} \nRecipient: {recipient} \nCurrent Balance: {currentBalance}");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void withdrawalSuccessful(decimal amount, decimal currentBalance)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nThe amount of {amount} has been withdrawn successfully \nCurrent balance: {currentBalance} \n");
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
        Console.WriteLine("\nPin can only be numerals");
        Console.ForegroundColor = ConsoleColor.White;
    }



    public void incorrectPin()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nIncorrect pin, please enter the correct pin to continue");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void incorrectOptionSelect()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nPlease read and follow the prompts carefully");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void insufficientBalance()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nInsufficient funds, cannot carry out transaction.");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void invalidNumber()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nEnter a valid amount.");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void incorrectRecipient()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nEnter a valid account number for recipient");
        Console.ForegroundColor = ConsoleColor.White;
    }


    public void airtimeAmountPrompt()
    {
        Console.Write("\nEnter airtime amount: ");
    }

    public void airtimeRecipientPrompt()
    {
        Console.Write("Enter recipient phone number: ");
    }
}
