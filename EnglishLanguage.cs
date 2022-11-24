using Atm_program;
using System;


//CLASS FOR ENGLISH LANGUAGE
public class EnglishLanguage : ILanguagePrompts, IErrorMessages, ISuccessMessages
{
    public void welcomeMessage()
    {
        Console.WriteLine("\n**********Welcome to Caleb's ATM Program**********");
    }

    public void enterPinPrompt()
    {
        Console.WriteLine("\nPlease enter a four-digit numeric pin for your card: ");
    }

    public void enterSavedPinPrompt()
    {
        Console.WriteLine("\nPlease enter your pin to carry out a transaction: ");
    }

    public void transactionPrompt()
    {
        Console.WriteLine("\nWhat transaction would you like to carry out: \n0: Check account balance \t1: Withdraw funds \n2: Transfer funds");
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


    public void transferSuccessful(decimal transferredAmt, int recipient, decimal currentBalance)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nAmount transferred: {transferredAmt} \nRecipient: {recipient} \nCurrent Balance: {currentBalance}");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void depositSuccessful(decimal amount, decimal currentBalance)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nThe amount of {amount} has been deposited successfully \nCurrent balance: {currentBalance} ");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void withdrawalSuccessful(decimal amount, decimal currentBalance)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nThe amount of {amount} has been withdrawn successfully \nCurrent balance: {currentBalance} ");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void pinNaN()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nPin can only be numerals");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void pinTooLong()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nYou can only enter a maximum of four digits");
        Console.ForegroundColor = ConsoleColor.White;
    }


    public void pinTooShort()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nYou can only enter a minimum of four digits");
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
}
