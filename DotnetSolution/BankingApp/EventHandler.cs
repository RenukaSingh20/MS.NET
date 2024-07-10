﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankingApp
{
    public delegate void Operation();
    public delegate void ArithmaticOperation(int num1, int num2);

    public class MathEngine
    {
        public int result;
        public void Addition(int num1, int num2)
        {
            result = num1 + num2;
        }
        public void Subtraction(int num1, int num2)
        {
            result = num1 - num2;
        }
    }

        public class EventHandler
        {
            public static void BlockAccount()
            {
                Console.WriteLine("Your account is blocked Temp...");
            }
            public static void PayIncomeTax()
            {
                Console.WriteLine("20% IncomeTax deducted");
            }
            public static void SendEmail()
            {
                Console.WriteLine("your email id");

            }
            public static void SendSMS()
            {
                Console.WriteLine("Your account details has been sent to sms");
            }
        }
    }


