using System;
using System.Linq.Expressions;

namespace Atm_program
{
    public class Atm_func
    {
        public string _accountName = "John Doe";
        public string _accountNumber = "3875264742";
        private static int _defaultCardPin = 6653;
        public static decimal _accountBalance = 30000;


        DateTime now = DateTime.Now;


        public decimal Withdraw(decimal amountInput)
        {
            return _accountBalance -= amountInput;
        }


        public decimal Transfer(decimal amountInput)
        {
            return _accountBalance -= amountInput;
        }


        public void RunAtmProgram()
        {

            Console.WriteLine("Please wait...");


            Console.Clear();

            languageOptionLabel:
            Console.WriteLine("Welcome to GENESYS BANK, please select a preferred language:" +
                "\n0 => English language " +
                "\n1 => Pidgin language " +
                "\n2 => Igbo language");

            String? languageOption = Console.ReadLine();

            switch (languageOption)
            {
                case "0":
                    EnglishLanguage eng = new EnglishLanguage();

                    string? gotoMainMenu;

                    pinPromptLabel:
                    eng.enterPinPrompt();

                    string? pin = Console.ReadLine();
                    int outedPin;

                    if (int.TryParse(pin, out outedPin) && outedPin == _defaultCardPin)
                    {
                    transactionLabel: eng.transactionPrompt();

                        string? transactionSelect = Console.ReadLine();

                        switch (transactionSelect)
                        {
                            case "0":
                                Console.WriteLine("\n***********************************");
                                Console.WriteLine($"Account name: {_accountName} " +
                                    $"\nAccount number: {_accountNumber}" +
                                    $"\nAvail balance: {_accountBalance}" +
                                    $"\nDate: {now.ToString("yyyy-mm-dd:hh:mm")}");
                                Console.WriteLine("***********************************\n");
                                eng.mainMenuPrompt();

                                gotoMainMenu = Console.ReadLine()?.ToLower();

                                if (gotoMainMenu != null && gotoMainMenu == "y")
                                {
                                    Console.Clear();
                                    goto transactionLabel;
                                }
                                
                                break;
                            case "1":
                            withdrawalPrompt:
                                eng.withdrawPrompt();

                                decimal? amountToWithdraw = Convert.ToDecimal(Console.ReadLine());

                                try
                                {
                                    if(amountToWithdraw > _accountBalance)
                                    {
                                        eng.insufficientBalance();
                                        goto withdrawalPrompt;
                                    }
                                    else if(amountToWithdraw <= 0)
                                    {
                                        eng.invalidNumber();
                                        goto withdrawalPrompt;
                                    }

                                    Withdraw((decimal)amountToWithdraw);
                                    Console.WriteLine("\n***********************************");
                                    eng.withdrawalSuccessful((decimal)amountToWithdraw, _accountBalance);
                                    Console.WriteLine("***********************************\n");
                                }
                                catch
                                {
                                    eng.invalidNumber();
                                }

                                eng.mainMenuPrompt();

                                gotoMainMenu = Console.ReadLine()?.ToLower();

                                if (gotoMainMenu != null && gotoMainMenu == "y")
                                {
                                    Console.Clear();
                                    goto transactionLabel;
                                }
                                break;

                            case "2":
                                transferLabel:
                                eng.transferPrompt();
                                decimal? amountToTransfer = Convert.ToDecimal(Console.ReadLine());

                                eng.recipientPrompt();
                                long? recipient = Convert.ToInt64(Console.ReadLine());

                                try
                                {
                                    if(recipient?.ToString().Length != 10)
                                    {
                                        eng.incorrectRecipient();
                                        goto transferLabel;
                                    }
                                    else if(amountToTransfer <= 0 || amountToTransfer > _accountBalance)
                                    {
                                        eng.insufficientBalance();
                                        goto transferLabel;
                                    }

                                    Transfer((decimal)amountToTransfer);
                                    Console.WriteLine("\n***********************************");
                                    eng.transferSuccessful((decimal)amountToTransfer, (long)recipient, _accountBalance);
                                    Console.WriteLine("***********************************\n");

                                }
                                catch
                                {
                                    eng.invalidNumber();
                                }

                                eng.mainMenuPrompt();

                                gotoMainMenu = Console.ReadLine()?.ToLower();

                                if (gotoMainMenu != null && gotoMainMenu == "y")
                                {
                                    Console.Clear();
                                    goto transactionLabel;
                                }

                                break;

                            case "3":
                                goto languageOptionLabel;
                            case "4":
                                airtimePromptLabel:
                                eng.airtimeAmountPrompt();

                                decimal amountToRecharge = Convert.ToDecimal(Console.ReadLine());

                                eng.airtimeRecipientPrompt();

                                long airtimeRecipientNumber = Convert.ToInt64(Console.ReadLine());


                                try
                                {
                                    if(amountToRecharge <= 0 || amountToRecharge > _accountBalance)
                                    {
                                        eng.insufficientBalance();
                                        goto airtimePromptLabel;
                                    }
                                    else if(airtimeRecipientNumber.ToString().Length >= 12 || airtimeRecipientNumber.ToString().Length < 11)
                                    {
                                        eng.incorrectRecipient();
                                        goto airtimePromptLabel;
                                    }

                                    Withdraw(amountToRecharge);


                                    Console.WriteLine("\n***********************************");
                                    eng.rechargeSuccessful(amountToRecharge, airtimeRecipientNumber, _accountBalance);
                                    Console.WriteLine("\n***********************************");
                                }
                                catch
                                {
                                    eng.invalidNumber();
                                }

                                eng.mainMenuPrompt();

                                gotoMainMenu = Console.ReadLine()?.ToLower();

                                if (gotoMainMenu != null && gotoMainMenu == "y")
                                {
                                    Console.Clear();
                                    goto transactionLabel;
                                }

                                break;
                            case "5":
                                Environment.Exit(0);
                                break;
                            default:
                                eng.incorrectOptionSelect();
                                break;
                        }
                    }
                    else
                    {
                        eng.incorrectPin();
                        goto pinPromptLabel;
                    }
                    break;


                case "1":
                    Console.WriteLine("Pidgin");
                    break;


                case "2":
                    Console.WriteLine("Igbo");
                    break;


                default:
                    Console.WriteLine("Invalid input... Please read and follow the prompt carefully.");
                    break;
            }




        }

    }

}

