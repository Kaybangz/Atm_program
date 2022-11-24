using Atm_program;
using System;


//CLASS FOR PIDGIN LANGUAGE
public class PidginLanguage : ILanguagePrompts, IErrorMessages, ISuccessMessages
{
    public void welcomeMessage()
    {
        Console.WriteLine("\n**********Welcome to Caleb ATM Program**********");
    }

    public void enterPinPrompt()
    {
        Console.WriteLine("\nAbeg enter four digits way you go use as pin for your card: ");
    }

    public void enterSavedPinPrompt()
    {
        Console.WriteLine("\nAbeg enter your pin to continue the transaction: ");
    }

    public void transactionPrompt()
    {
        Console.WriteLine("\nWhich transaction you go like carry out today: \n0: Check akant balance \t1: Withdraw funds \n2: Transfer funds");
    }

    public void depositPrompt()
    {
        Console.WriteLine("\nEnter how much you go like deposit: ");
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


    public void transferSuccessful(decimal transferredAmt, int recipient, decimal currentBalance)
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

    public void pinNaN()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nNa only number you fit use as pin");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void pinTooLong()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nThe highest way you fit enter na four numbers as your pin");
        Console.ForegroundColor = ConsoleColor.White;
    }


    public void pinTooShort()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nThe lowest way you fit enter na four numbers as your pin");
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
}