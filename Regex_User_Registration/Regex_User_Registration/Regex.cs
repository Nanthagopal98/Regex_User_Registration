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
    }
}
