using System.Text.RegularExpressions;
using Regex_User_Registration;

namespace TestUserInput
{
    public class Tests
    {
        RegularExpression regularExpression = new RegularExpression();
        [Test]
        public void GivenFirstName_ReturnValidOrNot()
        {           
            string name = "Nantha";
            string Expected = regularExpression.Name(name);
            Assert.AreEqual(name, Expected);
        }
        [Test]
        public void GivenLasttName_ReturnValidOrNot()
        {
            string name = "Shanmugam";
            string Expected = regularExpression.Name(name);
            Assert.AreEqual(name, Expected);
        }
        [Test]
        public void GivenEmailId_ReturnTrue()
        {
            string inputEmail = "s.nantha@gmail.com";                 
            Assert.IsTrue(regularExpression.email(inputEmail));            
        }
        [Test]
        public void GivenMobileNumber_ReturnTrue()
        {
            string mobileNumber = "91 9842778899";
            Assert.IsTrue(regularExpression.ContactNumber(mobileNumber));
        }
        [Test]
        public void GivenPassword_ReturnTrue()
        {
            string password = "AbcdA@123Ac12";
            Assert.IsTrue(regularExpression.Password(password));
        }
        [Test]
        public void CheckUserInputEmailToEmailRegex()
        {           
            string[] inputId = System.IO.File.ReadAllLines(@"D:\Bridgelabz\.Net\Regex_User_Registration\Regex_User_Registration\TestEmail\Email_id_Valid.txt");
            foreach (string input in inputId)
            {
                Assert.IsTrue(regularExpression.email(input));
            }
        }
        [Test]
        public void CheckInvalidUserInputEmailToEmailRegex()
        {
            string[] inputId = System.IO.File.ReadAllLines(@"D:\Bridgelabz\.Net\Regex_User_Registration\Regex_User_Registration\TestEmail\Email_id_Invalid.txt");
            foreach (string input in inputId)
            {
                Assert.IsFalse(regularExpression.email(input));
            }
        }
    }
}
