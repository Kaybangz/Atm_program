using System;

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

                                try
                                {
                                    decimal? amountToWithdraw = Convert.ToDecimal(Console.ReadLine());

                                    if (amountToWithdraw > _accountBalance)
                                    {
                                        eng.insufficientBalance();
                                        goto withdrawalPrompt;
                                    }
                                    else if (amountToWithdraw <= 0)
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
                                try
                                {
                                transferLabel:
                                    eng.transferPrompt();
                                    decimal? amountToTransfer = Convert.ToDecimal(Console.ReadLine());

                                    eng.recipientPrompt();
                                    long? recipient = Convert.ToInt64(Console.ReadLine());


                                    if (recipient?.ToString().Length != 10)
                                    {
                                        eng.incorrectRecipient();
                                        goto transferLabel;
                                    }
                                    else if (amountToTransfer <= 0 || amountToTransfer > _accountBalance)
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
                                try
                                {
                                airtimePromptLabel:
                                    eng.airtimeAmountPrompt();

                                    decimal amountToRecharge = Convert.ToDecimal(Console.ReadLine());

                                    eng.airtimeRecipientPrompt();

                                    long airtimeRecipientNumber = Convert.ToInt64(Console.ReadLine());


                                    if (amountToRecharge <= 0 || amountToRecharge > _accountBalance)
                                    {
                                        eng.insufficientBalance();
                                        goto airtimePromptLabel;
                                    }
                                    else if (airtimeRecipientNumber.ToString().Length >= 12 || airtimeRecipientNumber.ToString().Length < 11)
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
                    PidginLanguage pidg = new PidginLanguage();

                pinPromptLabelFromPidgin:
                    pidg.enterPinPrompt();


                    string? pinFromPidgin = Console.ReadLine();
                    int outedPinFromPidgin;

                    if (int.TryParse(pinFromPidgin, out outedPinFromPidgin) && outedPinFromPidgin == _defaultCardPin)
                    {
                    transactionLabel: pidg.transactionPrompt();

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
                                pidg.mainMenuPrompt();

                                gotoMainMenu = Console.ReadLine()?.ToLower();

                                if (gotoMainMenu != null && gotoMainMenu == "y")
                                {
                                    Console.Clear();
                                    goto transactionLabel;
                                }

                                break;
                            case "1":
                            withdrawalPrompt:
                                pidg.withdrawPrompt();

                                decimal? amountToWithdraw = Convert.ToDecimal(Console.ReadLine());

                                try
                                {
                                    if (amountToWithdraw > _accountBalance)
                                    {
                                        pidg.insufficientBalance();
                                        goto withdrawalPrompt;
                                    }
                                    else if (amountToWithdraw <= 0)
                                    {
                                        pidg.invalidNumber();
                                        goto withdrawalPrompt;
                                    }

                                    Withdraw((decimal)amountToWithdraw);
                                    Console.WriteLine("\n***********************************");
                                    pidg.withdrawalSuccessful((decimal)amountToWithdraw, _accountBalance);
                                    Console.WriteLine("***********************************\n");
                                }
                                catch
                                {
                                    pidg.invalidNumber();
                                }

                                pidg.mainMenuPrompt();

                                gotoMainMenu = Console.ReadLine()?.ToLower();

                                if (gotoMainMenu != null && gotoMainMenu == "y")
                                {
                                    Console.Clear();
                                    goto transactionLabel;
                                }
                                break;

                            case "2":
                                try
                                {
                                transferLabel:
                                    pidg.transferPrompt();
                                    decimal? amountToTransfer = Convert.ToDecimal(Console.ReadLine());

                                    pidg.recipientPrompt();
                                    long? recipient = Convert.ToInt64(Console.ReadLine());

                                    if (recipient?.ToString().Length != 10)
                                    {
                                        pidg.incorrectRecipient();
                                        goto transferLabel;
                                    }
                                    else if (amountToTransfer <= 0 || amountToTransfer > _accountBalance)
                                    {
                                        pidg.insufficientBalance();
                                        goto transferLabel;
                                    }

                                    Transfer((decimal)amountToTransfer);
                                    Console.WriteLine("\n***********************************");
                                    pidg.transferSuccessful((decimal)amountToTransfer, (long)recipient, _accountBalance);
                                    Console.WriteLine("***********************************\n");

                                }
                                catch
                                {
                                    pidg.invalidNumber();
                                }

                                pidg.mainMenuPrompt();

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
                                pidg.airtimeAmountPrompt();

                                decimal amountToRecharge = Convert.ToDecimal(Console.ReadLine());

                                pidg.airtimeRecipientPrompt();

                                long airtimeRecipientNumber = Convert.ToInt64(Console.ReadLine());


                                try
                                {
                                    if (amountToRecharge <= 0 || amountToRecharge > _accountBalance)
                                    {
                                        pidg.insufficientBalance();
                                        goto airtimePromptLabel;
                                    }
                                    else if (airtimeRecipientNumber.ToString().Length >= 12 || airtimeRecipientNumber.ToString().Length < 11)
                                    {
                                        pidg.incorrectRecipient();
                                        goto airtimePromptLabel;
                                    }

                                    Withdraw(amountToRecharge);


                                    Console.WriteLine("\n***********************************");
                                    pidg.rechargeSuccessful(amountToRecharge, airtimeRecipientNumber, _accountBalance);
                                    Console.WriteLine("\n***********************************");
                                }
                                catch
                                {
                                    pidg.invalidNumber();
                                }

                                pidg.mainMenuPrompt();

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
                                pidg.incorrectOptionSelect();
                                break;
                        }
                    }
                    else
                    {
                        pidg.incorrectPin();
                        goto pinPromptLabelFromPidgin;
                    }
                    break;


                case "2":
                    IgboLanguage igbo = new IgboLanguage();

                pinPromptLabelFromIgbo:
                    igbo.enterPinPrompt();


                    string? pinFromIgbo = Console.ReadLine();
                    int outedPinFromIgbo;

                    if (int.TryParse(pinFromIgbo, out outedPinFromIgbo) && outedPinFromIgbo == _defaultCardPin)
                    {
                    transactionLabel: igbo.transactionPrompt();

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
                                igbo.mainMenuPrompt();

                                gotoMainMenu = Console.ReadLine()?.ToLower();

                                if (gotoMainMenu != null && gotoMainMenu == "y")
                                {
                                    Console.Clear();
                                    goto transactionLabel;
                                }

                                break;
                            case "1":
                            withdrawalPrompt:
                                igbo.withdrawPrompt();

                                try
                                {
                                    decimal? amountToWithdraw = Convert.ToDecimal(Console.ReadLine());

                                    if (amountToWithdraw > _accountBalance)
                                    {
                                        igbo.insufficientBalance();
                                        goto withdrawalPrompt;
                                    }
                                    else if (amountToWithdraw <= 0)
                                    {
                                        igbo.invalidNumber();
                                        goto withdrawalPrompt;
                                    }

                                    Withdraw((decimal)amountToWithdraw);
                                    Console.WriteLine("\n***********************************");
                                    igbo.withdrawalSuccessful((decimal)amountToWithdraw, _accountBalance);
                                    Console.WriteLine("***********************************\n");
                                }
                                catch
                                {
                                    igbo.invalidNumber();
                                }

                                igbo.mainMenuPrompt();

                                gotoMainMenu = Console.ReadLine()?.ToLower();

                                if (gotoMainMenu != null && gotoMainMenu == "y")
                                {
                                    Console.Clear();
                                    goto transactionLabel;
                                }
                                break;

                            case "2":
                                try
                                {
                                transferLabel:
                                    igbo.transferPrompt();
                                    decimal? amountToTransfer = Convert.ToDecimal(Console.ReadLine());

                                    igbo.recipientPrompt();
                                    long? recipient = Convert.ToInt64(Console.ReadLine());

                                    if (recipient?.ToString().Length != 10)
                                    {
                                        igbo.incorrectRecipient();
                                        goto transferLabel;
                                    }
                                    else if (amountToTransfer <= 0 || amountToTransfer > _accountBalance)
                                    {
                                        igbo.insufficientBalance();
                                        goto transferLabel;
                                    }

                                    Transfer((decimal)amountToTransfer);
                                    Console.WriteLine("\n***********************************");
                                    igbo.transferSuccessful((decimal)amountToTransfer, (long)recipient, _accountBalance);
                                    Console.WriteLine("***********************************\n");

                                }
                                catch
                                {
                                    igbo.invalidNumber();
                                }

                                igbo.mainMenuPrompt();

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
                                igbo.airtimeAmountPrompt();

                                decimal amountToRecharge = Convert.ToDecimal(Console.ReadLine());

                                igbo.airtimeRecipientPrompt();

                                long airtimeRecipientNumber = Convert.ToInt64(Console.ReadLine());


                                try
                                {
                                    if (amountToRecharge <= 0 || amountToRecharge > _accountBalance)
                                    {
                                        igbo.insufficientBalance();
                                        goto airtimePromptLabel;
                                    }
                                    else if (airtimeRecipientNumber.ToString().Length >= 12 || airtimeRecipientNumber.ToString().Length < 11)
                                    {
                                        igbo.incorrectRecipient();
                                        goto airtimePromptLabel;
                                    }

                                    Withdraw(amountToRecharge);


                                    Console.WriteLine("\n***********************************");
                                    igbo.rechargeSuccessful(amountToRecharge, airtimeRecipientNumber, _accountBalance);
                                    Console.WriteLine("\n***********************************");
                                }
                                catch
                                {
                                    igbo.invalidNumber();
                                }

                                igbo.mainMenuPrompt();

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
                                igbo.incorrectOptionSelect();
                                break;
                        }
                    }
                    else
                    {
                        igbo.incorrectPin();
                        goto pinPromptLabelFromIgbo;
                    }
                    break;


                default:
                    Console.WriteLine("Invalid input... Please read and follow the prompt carefully.");
                    break;
            }




        }

    }

}

