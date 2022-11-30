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
        Console.WriteLine("\nNnọọ na mmemme GENESYS BANK ATM");
    }

    public void enterPinPrompt()
    {
        Console.WriteLine("\nJiri pin '6653' nke ndabara ka ịga n'ihu: ");
    }

    public void transactionPrompt()
    {
        Console.WriteLine("\nKedu azụmahịa ị ga-achọ ime:" +
            " \n0 => lelee nguzozi akaụntụ gị " +
            "\t1 => Wepụ ego \n2 => Nyefee ego " +
            "\t\t3 => Gbanwee asụsụ \n4 => Zipu oge ikuku \t\t5 => Ụzọ ọpụpụ \n");
    }


    public void mainMenuPrompt()
    {
        Console.Write("Pịa 'Y' ka ịlaghachi na menu isi yana 'N' ka ịkwụsị mmemme: ");
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


    public void transferSuccessful(decimal transferredAmt, long recipient, decimal currentBalance)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nỌnụ ego ebufere: {transferredAmt} \nOnye nnata: {recipient} \nNtụle ugbu a: {currentBalance}\n");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void withdrawalSuccessful(decimal amount, decimal currentBalance)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nEwepụla ego {amount} nke ọma \nNtụle ugbu a: {currentBalance} ");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void rechargeSuccessful(decimal transferredAmt, long recipient, decimal currentBalance)
    {
        Console.ForegroundColor = ConsoleColor.Green;
        Console.WriteLine($"\nNkwalite oge ikuku: {transferredAmt} \nonye nnata: +234{recipient} \nNhazi ugbu a: {currentBalance}");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void pinNaN()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nPin nwere ike ịbụ naanị ọnụọgụ");
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
        Console.WriteLine("\nBiko tinye ndenye ziri ezi.\n");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void incorrectRecipient()
    {
        Console.ForegroundColor = ConsoleColor.Red;
        Console.WriteLine("\nTinye nọmba akaụntụ dị irè maka nnata");
        Console.ForegroundColor = ConsoleColor.White;
    }

    public void airtimeAmountPrompt()
    {
        Console.Write("\nTinye oge ikuku: ");
    }

    public void airtimeRecipientPrompt()
    {
        Console.Write("Tinye nọmba ekwentị nnata: ");
    }
}


