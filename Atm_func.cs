using System;


namespace Atm_program
{
    public class Atm_func
    {
        protected decimal _accountBalance = 30000;


        public decimal Withdraw(decimal amountInput)
        {
            return _accountBalance -= amountInput;
        }


        public decimal Transfer(decimal amountInput)
        {
            return _accountBalance -= amountInput;
        }



        public void RunProgram()
        {

            Console.WriteLine("SELECT PREFERRED LANGUAGE: \n0: English \t1: Pidgin \n2: Igbo");

            string? userLangChoice = Console.ReadLine();


                switch (userLangChoice)
                {
                    case "0":
                        EnglishLanguage eng = new EnglishLanguage();

                        eng.welcomeMessage();
                        eng.enterPinPrompt();

                    int _userPin = Convert.ToInt32(Console.ReadLine());


                    if(_userPin.ToString().Length > 4)
                    {
                        eng.pinTooLong();
                        break;
                    }
                    else if(_userPin.ToString().Length < 4)
                    {
                        eng.pinTooShort();
                        break;
                    }
                    else if(_userPin.GetType() != typeof(int))
                    {
                        eng.pinNaN();
                        break;
                    }
                    else
                    {
                        eng.pinSaved();
                    }

                   
                    eng.enterSavedPinPrompt();

                    int userPin = Convert.ToInt32(Console.ReadLine());

                    if(userPin != _userPin)
                    {
                        eng.incorrectPin();
                        break;
                    }

                    eng.transactionPrompt();

                    string? transactionChoice = Console.ReadLine();

                    switch (transactionChoice)
                    {
                        case "0":
                            
                            break;


                        case "1":
                            eng.withdrawPrompt();

                            decimal amountToWithdraw = Convert.ToDecimal(Console.ReadLine());

                            if(_accountBalance <= 0 || amountToWithdraw > _accountBalance)
                            {
                                eng.insufficientBalance();
                                break;
                            }

                            Withdraw(amountToWithdraw);

                            eng.withdrawalSuccessful(amountToWithdraw, _accountBalance);
                            break;


                        case "2":
                            eng.transferPrompt();

                            decimal amountToTransfer = Convert.ToDecimal(Console.ReadLine());

                            eng.recipientPrompt();

                            int recipient = Convert.ToInt32(Console.ReadLine());

                            if (_accountBalance <= 0 || amountToTransfer > _accountBalance)
                            {
                                eng.insufficientBalance();
                                break;
                            }
                      
                            //Error handling for recipient

                            Transfer(amountToTransfer);

                            eng.transferSuccessful(amountToTransfer, recipient, _accountBalance);
                            break;


                        default:
                            eng.incorrectOptionSelect();
                            break;

                        }

                        break;


                    ///PIDGIN LANGUAGE SELECT
                    case "1":
                    PidginLanguage pidg = new PidginLanguage();
                    pidg.welcomeMessage();
                    pidg.enterPinPrompt();

                    int _userPin2 = Convert.ToInt32(Console.ReadLine());

                    if (_userPin2.ToString().Length > 4)
                    {
                        pidg.pinTooLong();
                        break;
                    }
                    else if (_userPin2.ToString().Length < 4)
                    {
                        pidg.pinTooShort();
                        break;
                    }
                    else if (_userPin2.GetType() != typeof(int))
                    {
                        pidg.pinNaN();
                        break;
                    }
                    else
                    {
                        pidg.pinSaved();
                    }


                    pidg.enterSavedPinPrompt();

                    int userPin2 = Convert.ToInt32(Console.ReadLine());

                    if (userPin2 != _userPin2)
                    {
                        pidg.incorrectPin();
                        break;
                    }

                    pidg.transactionPrompt();

                    string? transactionChoice2 = Console.ReadLine();

                    switch (transactionChoice2)
                    {
                        case "0":
                            pidg.depositPrompt();

                            decimal amountToDeposit = Convert.ToDecimal(Console.ReadLine());

                           

                            pidg.depositSuccessful(amountToDeposit, _accountBalance);
                            break;


                        case "1":
                            pidg.withdrawPrompt();

                            decimal amountToWithdraw = Convert.ToDecimal(Console.ReadLine());

                            if (_accountBalance <= 0 || amountToWithdraw > _accountBalance)
                            {
                                pidg.insufficientBalance();
                                break;
                            }

                            Withdraw(amountToWithdraw);

                            pidg.withdrawalSuccessful(amountToWithdraw, _accountBalance);
                            break;


                        case "2":
                            pidg.transferPrompt();

                            decimal amountToTransfer = Convert.ToDecimal(Console.ReadLine());

                            pidg.recipientPrompt();

                            int recipient = Convert.ToInt32(Console.ReadLine());

                            if (_accountBalance <= 0 || amountToTransfer > _accountBalance)
                            {
                                pidg.insufficientBalance();
                                break;
                            }

                            //Error handling for recipient

                            Transfer(amountToTransfer);

                            pidg.transferSuccessful(amountToTransfer, recipient, _accountBalance);
                            break;


                        default:
                            pidg.incorrectOptionSelect();
                            break;

                    }

                    break;

                    ///IGBO LANGUAGE SELECT
                    case "2":
                    IgboLanguage igbo = new IgboLanguage();
                    igbo.welcomeMessage();
                    igbo.enterPinPrompt();

                    int _userPin3 = Convert.ToInt32(Console.ReadLine());

                    if (_userPin3.ToString().Length > 4)
                    {
                        igbo.pinTooLong();
                        break;
                    }
                    else if (_userPin3.ToString().Length < 4)
                    {
                        igbo.pinTooShort();
                        break;
                    }
                    else if (_userPin3.GetType() != typeof(int))
                    {
                        igbo.pinNaN();
                        break;
                    }
                    else
                    {
                        igbo.pinSaved();
                    }


                    igbo.enterSavedPinPrompt();

                    int userPin3 = Convert.ToInt32(Console.ReadLine());

                    if (userPin3 != _userPin3)
                    {
                        igbo.incorrectPin();
                        break;
                    }

                    igbo.transactionPrompt();

                    string? transactionChoice3 = Console.ReadLine();

                    switch (transactionChoice3)
                    {
                        case "0":
                            igbo.depositPrompt();

                            decimal amountToDeposit = Convert.ToDecimal(Console.ReadLine());

                            igbo.depositSuccessful(amountToDeposit, _accountBalance);
                            break;


                        case "1":
                            igbo.withdrawPrompt();

                            decimal amountToWithdraw = Convert.ToDecimal(Console.ReadLine());

                            if (_accountBalance <= 0 || amountToWithdraw > _accountBalance)
                            {
                                igbo.insufficientBalance();
                                break;
                            }

                            Withdraw(amountToWithdraw);

                            igbo.withdrawalSuccessful(amountToWithdraw, _accountBalance);
                            break;


                        case "2":
                            igbo.transferPrompt();

                            decimal amountToTransfer = Convert.ToDecimal(Console.ReadLine());

                            igbo.recipientPrompt();

                            int recipient = Convert.ToInt32(Console.ReadLine());

                            if (_accountBalance <= 0 || amountToTransfer > _accountBalance)
                            {
                                igbo.insufficientBalance();
                                break;
                            }

                            //Error handling for recipient

                            Transfer(amountToTransfer);

                            igbo.transferSuccessful(amountToTransfer, recipient, _accountBalance);
                            break;


                        default:
                            igbo.incorrectOptionSelect();
                            break;

                    }

                    break;
    
                    default:
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Please read and follow the prompt carefully");
                        Console.ForegroundColor = ConsoleColor.White;
                        break;
                }
        }

    }

}
