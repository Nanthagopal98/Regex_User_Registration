using System.Text.RegularExpressions;

namespace TestEmail
{
    public class Tests
    {
        [Test]
        public void CheckUserInputEmailToEmailRegex()
        {
            Regex_User_Registration.RegularExpression run = new Regex_User_Registration.RegularExpression();
            string[] inputId = System.IO.File.ReadAllLines(@"D:\Bridgelabz\.Net\Regex_User_Registration\Regex_User_Registration\TestEmail\Email_id_Valid.txt");
            foreach (string input in inputId)
            {
                Assert.IsTrue(run.email(input));                   
            }           
        }
        [Test]
        public void CheckInvalidUserInputEmailToEmailRegex()
        {
            Regex_User_Registration.RegularExpression run = new Regex_User_Registration.RegularExpression();
            string[] inputId = System.IO.File.ReadAllLines(@"D:\Bridgelabz\.Net\Regex_User_Registration\Regex_User_Registration\TestEmail\Email_id_Invalid.txt");
            foreach (string input in inputId)
            {
                Assert.IsFalse(run.email(input));
            }
        }
    }
}
