using System;

namespace PinCodeEmailValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            //Program to check validity of pin code and user email.
            //Step 1: Pin code object is created. Functions to take user entry and validate pin code are called.
            PinCode pinCode = new PinCode();
            pinCode.EnterPinCode();
            pinCode.IsValidatePinCode();

            //Step 2: Email instance is created. Functions to take user entry and validate email ar called.
            Email email = new Email();
            email.EnterEmail();
            email.IsValidEmail();
        }
    }
}
