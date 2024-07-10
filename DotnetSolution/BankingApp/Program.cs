using BankingApp;

//BankingApp.EventHandler.PayIncomeTax();
//register the function

/*Operation opn1 = new Operation(BankingApp.EventHandler.PayIncomeTax);
Operation opn2 = new Operation(BankingApp.EventHandler.BlockAccount);
Operation opn3 = new Operation(BankingApp.EventHandler.SendSMS);
Operation opn4 = new Operation(BankingApp.EventHandler.SendEmail);
Operation masterOpn = null;
masterOpn += opn1;
masterOpn += opn2;
masterOpn += opn3;
masterOpn += opn4;
masterOpn();
opn1();

MathEngine engine = new MathEngine();
ArithmaticOperation aopn1 = new ArithmaticOperation(engine.Addition);
ArithmaticOperation aopn2= new ArithmaticOperation(engine.Subtraction);
ArithmaticOperation masterMathOpen = null;
ArithmaticOperation masterMath = aopn1;
masterMath(20, 30);
//multicast delegates
masterMath += aopn2;
masterMath(45, 35);
masterMath -= aopn2;
masterMath(45, 35);*/
Account acct= new Account();
acct.balance = 5000;
//Event registration
acct.overBalance += BankingApp.EventHandler.PayIncomeTax;
acct.overBalance += BankingApp.EventHandler.SendSMS;
acct.underBalance += BankingApp.EventHandler.BlockAccount;

acct.Deposit(356000);
acct.Withdraw(500000);


