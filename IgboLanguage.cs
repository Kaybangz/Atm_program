using Atm_program;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//CLASS FOR IGBO LANGUAGE
public class IgboLanguage : ILanguagePrompts, IErrorMessages, ISuccessMessages
{
    public void welcomeMessage()
    {
        Console.WriteLine("\n**********Nnọọ na mmemme ATM nke Keleb**********");
    }

    public void enterPinPrompt()
    {
        Console.WriteLine("\nBiko tinye ntụtụ ọnụọgụ anọ maka kaadị gị: ");
    }

    public void enterSavedPinPrompt()
    {
        Console.WriteLine("\nBiko tinye ntụtụ gị: ");
    }

    public void transactionPrompt()
    {
        Console.WriteLine("\nKedu azụmahịa ị ga-achọ ime: \n0: lelee nguzozi akaụntụ gị \t1: Wepụ ego \n2: Nyefee ego");
    }

    public void depositPrompt()
    {
        Console.WriteLine("\nTinye ego ị ga-achọ itinye: ");
    }


    public void withdrawPrompt()
    {
        Console.WriteLine("\nTinye ego ị ga-achọ ịdọrọ: ");
    }

    public void transferPrompt()
    {
        Console.WriteLine("\nTinye ego ị ga-achọ ibufe: ");
    }

    public void recipientPrompt()
    {
        Console.WriteLine("\nTinye nọmba akaụntụ nke nnata: ");
    }

    public void pinSaved()
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine("\nA na-echekwa pin nke ọma!");
        Console.ForegroundColor = ConsoleColor.White;
    }


    public void transferSuccessful(decimal transferredAmt, int recipient, decimal currentBalance)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nỌnụ ego ebufere: {transferredAmt} \nOnye nnata: {recipient} \nNtụle ugbu a: {currentBalance}");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void depositSuccessful(decimal amount, decimal currentBalance)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nEgo {amount} etinyela ego nke ọma \nNtụle ugbu a: {currentBalance} ");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void withdrawalSuccessful(decimal amount, decimal currentBalance)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nEwepụla ego {amount} nke ọma \nNtụle ugbu a: {currentBalance} ");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void pinNaN()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nPin nwere ike ịbụ naanị ọnụọgụ");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void pinTooLong()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nỊ nwere ike itinye naanị ọnụọgụ anọ kacha");
        Console.ForegroundColor = ConsoleColor.White;
    }


    public void pinTooShort()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nỊ nwere ike itinye opekempe nke ọnụọgụ anọ");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void incorrectPin()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nNtụtụ ezighi ezi, biko tinye pin ziri ezi ka ịga n'ihu");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void incorrectOptionSelect()
    {
        Console.ForegroundColor = ConsoleColor.Blue;
        Console.WriteLine("\nBiko gụọ ma soro mkpali ahụ nke ọma");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void insufficientBalance()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nEgo ezughị oke, enweghị ike ịme azụmahịa.");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void invalidNumber()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nTinye ego bara uru.");
        Console.ForegroundColor = ConsoleColor.White;
    }
}


