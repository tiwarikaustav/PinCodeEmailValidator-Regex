using System;
using System.Collections.Generic;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Text.RegularExpressions;

namespace PinCodeEmailValidator
{
    class PinCode
    {
        string pinCodeNum;

        public void EnterPinCode()
        {
            Console.WriteLine("Please enter Pin Code:");
            string pinCodeNum = Console.ReadLine();
            this.pinCodeNum = pinCodeNum;
        }
        public void IsValidatePinCode()
        {
            string pinCodeRegex = @"[0-9]{6}$";
            if (Regex.IsMatch(pinCodeNum, pinCodeRegex))
            {
                Console.WriteLine("Pin Code is Validated. You are good to go!");
            }
            else
            {
                Console.WriteLine("Invalid Pin Code!");
            }
        }
        
    }
}
