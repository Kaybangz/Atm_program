using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm_program
{
    interface ILanguagePrompts
    {
        void welcomeMessage();

        void enterPinPrompt();

        void enterSavedPinPrompt();

        void transactionPrompt();

        void depositPrompt();

        void withdrawPrompt();

        void transferPrompt();

        void recipientPrompt();
        
    }

    interface ISuccessMessages
    {
        void pinSaved();

        void transferSuccessful(decimal transferredAmt, int recipient, decimal balance);

        void depositSuccessful(decimal amount, decimal balance);

        void withdrawalSuccessful(decimal amount, decimal balance);
    }


    interface IErrorMessages
    {
        void pinNaN();

        void pinTooLong();

        void pinTooShort();

        void incorrectPin();

        void incorrectOptionSelect();

        void insufficientBalance();

        void invalidNumber();
    }



    //CLASS FOR ENGLISH LANGUAGE
    public class EnglishLanguage: ILanguagePrompts, IErrorMessages, ISuccessMessages
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
            Console.WriteLine("\nWhat transaction would you like to carry out: \n0: Deposit funds \t1: Withdraw funds \n2: Transfer funds");
        }

        public void depositPrompt()
        {
            Console.WriteLine("\nEnter amount you would like to deposit: ");
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
            Console.ForegroundColor = ConsoleColor.Blue;
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
            Console.WriteLine("\nWhich transaction you go like carry out today: \n0: Deposit funds \t1: Withdraw funds \n2: Transfer funds");
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
            Console.WriteLine("\nEnter account number of person way you wan transfer the money give: ");
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
            Console.ForegroundColor = ConsoleColor.Blue;
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
            Console.WriteLine("\nKedu azụmahịa ị ga-achọ ime: \n0: Ego nkwụnye ego \t1: Wepụ ego \n2: Nyefee ego");
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
}
