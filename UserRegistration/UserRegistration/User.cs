using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    class User
    {
        public const string FIRST_NAME = "^[A-Z]{1}[a-z]{1,}$";
        // valid user first name
        
        public static bool ValidateFirstName()
        {
            Regex regex = new Regex(FIRST_NAME);
            return regex.IsMatch("Yogesh");
        }

        public const string LAST_NAME = "^[A-Z]{1}[a-z]{1,}$";
        // valid user last name
        public static bool ValidateLastName()
        {
            Regex regex = new Regex(LAST_NAME);
            return regex.IsMatch("Kusakiya");
        }

        public const string EMAIL = "^[a-zA-z]{3}([.]*[a-zA-Z])+[@][a-zA-z]+([.][a-z]{2,3})*$";
        // valid user email id
        public static bool ValidateEmail()
        {
            Regex regex = new Regex(EMAIL);
            return regex.IsMatch("abc.xyz@bl.co.in");
        }

        public const string MOBILE = "^([9][1])+[ ]+[0-9]{10}$";
        //valid mobile no
        public static bool ValidatePhone()
        {
            Regex regex = new Regex(MOBILE);
            return regex.IsMatch("91 9907296689");
        }

        public const string PASSWORD_R1 = "^[a-zA-Z0-9]{8}";
        public static bool PasswordR1()
        {
            Regex regex = new Regex(PASSWORD_R1);
            return regex.IsMatch("Katvh120");
        }
    }
}
