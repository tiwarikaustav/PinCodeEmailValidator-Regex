using System;

namespace PinCodeEmailValidator
{
    class Program
    {
        static void Main(string[] args)
        {
            PinCode pinCode = new PinCode();
            pinCode.EnterPinCode();
            pinCode.IsValidatePinCode();
        }
    }
}
