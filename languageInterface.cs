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

        void transactionPrompt();

        void mainMenuPrompt();

        void withdrawPrompt();

        void transferPrompt();

        void recipientPrompt();
       

        void airtimeAmountPrompt();

        void airtimeRecipientPrompt();
    }

    internal interface ISuccessMessages
    {
        void pinSaved();

        void transferSuccessful(decimal transferredAmt, long recipient, decimal balance);

        void withdrawalSuccessful(decimal amount, decimal balance);

        void rechargeSuccessful(decimal amount, long recipient, decimal balance);
    }


    internal interface IErrorMessages
    {
        void incorrectPin();

        void incorrectOptionSelect();

        void insufficientBalance();

        void invalidNumber();

        void incorrectRecipient();
    }

}

    

    