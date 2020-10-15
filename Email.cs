﻿using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace PinCodeEmailValidator
{
    class Email
    {
        string eMail;
        /// <summary>
        /// Enters the email.
        /// </summary>
        public void EnterEmail()
        {
            Console.WriteLine("Enter Email for Validation:");
            string email = Console.ReadLine();
            this.eMail = email;
        }
        /// <summary>
        /// Determines whether [is valid email].
        /// </summary>
        public void IsValidEmail()
        {
            string eMailRegex = @"^[a-z\d\.-_]+@(bridgelabz)[\.]?[a-z]+$";
            if(Regex.IsMatch(eMail, eMailRegex))
            {
                Console.WriteLine("Email Validated.");
            }
            else
            {
                Console.WriteLine("Invalid Email!");
            }
        }
    }
}