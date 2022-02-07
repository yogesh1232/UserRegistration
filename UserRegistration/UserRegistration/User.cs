using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace UserRegistration
{
    public class User
    {
        public const string FIRST_NAME = "^[A-Z]{1}[a-z]{1,}$";
        // valid user first name

        public static string ValidateFirstName(string name)
        {
            Regex regex = new Regex(FIRST_NAME);
            try
            {
                if (regex.IsMatch(name))
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }
            catch (Exception)
            {
                throw new UserException(UserException.ExceptionType.NULL_EXCEPTION, "First name is not valid");
            }
        }

        public const string LAST_NAME = "^[A-Z]{1}[a-z]{1,}$";
        // valid user last name
        public static string ValidateLastName(string name)
        {
            Regex regex = new Regex(LAST_NAME);
            try
            {
                if (regex.IsMatch(name))
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }
            catch (Exception)
            {
                throw new UserException(UserException.ExceptionType.NULL_EXCEPTION, "Last name is not valid");
            }
        }

        public const string EMAIL = "^[a-zA-z]{3}([.]*[a-zA-Z])+[@][a-zA-z]+([.][a-z]{2,3})*$";
        // valid user email id
        public static string ValidateEmail(string email)
        {
            Regex regex = new Regex(EMAIL);
            try
            {
                if (regex.IsMatch(email))
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }
            catch (Exception)
            {
                throw new UserException(UserException.ExceptionType.NULL_EXCEPTION, "Email name is not valid");
            }
        }

        public const string MOBILE = "^([9][1])+[ ]+[0-9]{10}$";
        //valid mobile no
        public static string ValidatePhone(string number)
        {
            Regex regex = new Regex(MOBILE);
            try
            {
                if (regex.IsMatch(number))
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }
            catch (Exception)
            {
                throw new UserException(UserException.ExceptionType.NULL_EXCEPTION, "Phone Number is not valid");
            }
        }

        public const string PASSWORD_R1 = "^[a-zA-Z0-9]{8}";
        public static string ValidatePassword(string password)
        {
            Regex regex = new Regex(PASSWORD_R1);
            try
            {
                if (regex.IsMatch(password))
                {
                    return "true";
                }
                else
                {
                    return "false";
                }
            }
            catch (Exception)
            {
                throw new UserException(UserException.ExceptionType.NULL_EXCEPTION, "Password is not valid");
            }
        }

        public const string PASSWORD_R2 = "^(?=.*[a-z])(?=.*[A-Z]).{8,}$";
        // minimum one character should be upper case
        public static bool PasswordR2()
        {
            Regex regex = new Regex(PASSWORD_R2);
            return regex.IsMatch("akXyb302");
        }

        public const string PASSWORD_R3 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9]).{8,}$";
        // minimum one numeric value
        public static bool PasswordR3()
        {
            Regex regex = new Regex(PASSWORD_R3);
            return regex.IsMatch("akXybty2");
        }

        public const string PASSWORD_R4 = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[@#$%^&-+=()]).{8,}$";
        //Atleast one special character
        public static bool PasswordR4()
        {
            Regex regex = new Regex(PASSWORD_R4);
            return regex.IsMatch("akXs@bx3");
        }

        // valid the email id.
        public const string SAMPLE_EMAIL = "^[a-zA-z]{3}([+-_ .]*[a-zA-Z0-9]+)*[@][a-zA-z0-9]+(.[a-z]{2,3})*$";
        public static void ValidatingEmail()
        {
            string[] sample = { "abc@yahoo.com", "abc-100@yahoo.com", "abc.100@yahoo.com", "abc-100@abc.net", "abc.100@abc.com.au",
                                 "abc@1.com", "abc@gmail.com.com", "abc+100@gmail.com" ,"abc","abc@.com","abc123@gmail.a", "abc123@.com" ,
                                 "abc123@.com.com",".abc@abc.com","abc()*@gmail.com","abc@%*.com","abc.@gmail.com","abc@abc@gmail.com","abc@gmail.com.1a"};
            Regex regex = new Regex(SAMPLE_EMAIL);
            Console.WriteLine("Validates Email ID");
            Validate(sample, regex);
        }
        // printing email id status
        public static void Validate(string[] arr, Regex regex)
        {
            for (int i = 0; i < arr.Length; i++)
            {
                bool rs = regex.IsMatch(arr[i]);
                if (rs == true)
                    Console.WriteLine(arr[i] + "-->" + "Valid Email ID");
                else
                    Console.WriteLine(arr[i] + "-->" + "Invalid Email ID");
            }
        }
    }
}
