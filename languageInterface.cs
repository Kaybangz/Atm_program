using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atm_program
{
    internal interface ILanguagePrompts
    {
        void welcomeMessage();

        void enterPinPrompt();

        void enterSavedPinPrompt();

        void transactionPrompt();

        void withdrawPrompt();

        void transferPrompt();

        void recipientPrompt();

    }

    internal interface ISuccessMessages
    {
        void pinSaved();

        void transferSuccessful(decimal transferredAmt, int recipient, decimal balance);

        void withdrawalSuccessful(decimal amount, decimal balance);
    }


    internal interface IErrorMessages
    {
        void pinNaN();

        void pinTooLong();

        void pinTooShort();

        void incorrectPin();

        void incorrectOptionSelect();

        void insufficientBalance();

        void invalidNumber();
    }

}

    

    