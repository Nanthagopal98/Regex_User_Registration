using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace Regex_User_Registration
{
    internal class RegularExpression
    {
        public void name(string name)
        {
            const string NAME = "^[A-Z]{1}[a-z]{2,}$";
                      
            if(Regex.IsMatch(name, NAME))
            {
                Console.WriteLine(name + " is a valid Name");
                return;
            }
            Console.WriteLine(name + " is a invalid Name");
            return;
        }
        public void email(string id)
        {
            const string mailId = "^[a-zA-z0-9]+[.]{0,1}[a-zA-z0-9]+([@]?)+[a-z]{1,15}[.]+(com|co)+((.in)*)$";
            if(Regex.IsMatch(id, mailId))
            {
                Console.WriteLine(id + " is a valid Email");
                return;
            }
            Console.WriteLine(id + " is a invalid Email");
            return;

        }
        
    }
}
