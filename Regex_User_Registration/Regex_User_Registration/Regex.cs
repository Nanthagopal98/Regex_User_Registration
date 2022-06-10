using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex_User_Registration
{
    public class RegularExpression
    {
        public string FirstName(string name)
        {
            const string NAME = "^[A-Z]{1}[a-z]{2,}$";
            try
            {
                if (Regex.IsMatch(name, NAME))
                {
                    Console.WriteLine(name + " is a valid Name");
                    return name;
                }
                else
                {
                    throw new Exception();
                }
                
            }
            catch
            {
                throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_FIRSTNAME, "Invalid FirstName");
            }           
        }
        public string LastName(string name)
        {
            const string NAME = "^[A-Z]{1}[a-z]{2,}$";
            try
            {
                if (Regex.IsMatch(name, NAME))
                {
                    Console.WriteLine(name + " is a valid Name");
                    return name;
                }
                else
                {
                    throw new Exception();
                }

            }
            catch
            {
                throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_FIRSTNAME, "Invalid LastName");
            }
        }
        public string email(string id)
        {
            const string mailId = "^[a-zA-z0-9]+([.+-]?[a-zA-z0-9]+)@[a-z0-9]+[.]?(com|co|net)+((.in|.au|.us)*)$";
            if(Regex.IsMatch(id, mailId))
            {
                Console.WriteLine(id + " is a valid Email");
                return "Valid";
            }
            else
            {
                Console.WriteLine(id + " is a invalid Email");              
                throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_EMAIL, "Invalid Email Id");
                
            }
          
        }
        public bool ContactNumber(string number)
        {
            const string numberRegex = "^(91 )[6-9]{1}[0-9]{9}$";
            if (Regex.IsMatch(number, numberRegex))
            {
                Console.WriteLine(number + " is a valid Number");
                return true;
            }
            else
            {
                Console.WriteLine(number + " is a invalid Number");
                throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_MOBILE_NUMBER, "Invalid Contact Number");
            }
        }
        public bool Password(string password)
        {
            const string passwordRegex = "^(?=[A-za-z0-9,]*[!#@$%^&][a-zA-Z0-9]*$)[]a-zA-Z0-9,!#@$%^&]+.{8,}";
            if (Regex.IsMatch(password, passwordRegex))
            {
                Console.WriteLine(password + " is a valid Password");
                return true;
            }
            else
            {
                Console.WriteLine(password + " is a invalid Password");
                throw new CustomExceptions(CustomExceptions.ExceptionType.INVALID_PASSWORD, "Invalid Password");
            }
        }        

    }
}
