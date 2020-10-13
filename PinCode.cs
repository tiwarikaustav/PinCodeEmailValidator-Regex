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

        //Taking User Pin Code Input and storing in variable - 'pinCodeNum'
        public void EnterPinCode()
        {
            Console.WriteLine("Please enter Pin Code:");
            string pinCodeNum = Console.ReadLine();
            this.pinCodeNum = pinCodeNum;
        }
        //Matching the entered pin code with regex pattern by using Regex.IsMatch(a,b);
        public void IsValidatePinCode()
        {
            string pinCodeRegex = @"^[0-9]{3}[ ]*[0-9]{3}$";
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
