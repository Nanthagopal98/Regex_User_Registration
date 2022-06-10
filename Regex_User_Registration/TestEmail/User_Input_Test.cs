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
            try
            {
                string name = "Nantha@";
                string Expected = regularExpression.FirstName(name);
                Assert.AreEqual(name, Expected);
            }
            catch(CustomExceptions e)
            {
                Assert.AreEqual("Invalid FirstName", e.Message);
            }
        }
        [Test]
        public void GivenLasttName_ReturnValidOrNot()
        {
            try
            {
                string name = "Shanmugam";
                string Expected = regularExpression.LastName(name);
                Assert.AreEqual(name, Expected);
            }
            catch (CustomExceptions e)
            {
                Assert.AreEqual("Invalid LastName", e.Message); 
            }

        }
        [Test]
        public void GivenEmailId_ReturnTrue()
        {
            try
            {
                string inputEmail = "s.nantha@gmail.com";                
                string result = (regularExpression.email(inputEmail));
                Assert.AreEqual("Valid", result);
            }
            catch(CustomExceptions e)
            {
                Assert.AreEqual("Invalid Email Id", e.Message);
            }
        }
        [Test]
        public void GivenMobileNumber_ReturnTrue()
        {
            try
            {
                string mobileNumber = "91 9842778899";
                Assert.IsTrue(regularExpression.ContactNumber(mobileNumber));
            }
            catch(CustomExceptions e)
            {
                Assert.AreEqual("Invalid Contact Number", e.Message);
            }
        }
        [Test]
        public void GivenPassword_ReturnTrue()
        {
            try
            {
                string password = "AbcdA@123Ac12";
                Assert.IsTrue(regularExpression.Password(password));
            }
            catch(CustomExceptions e)
            {
                Assert.AreEqual("Invalid Contact Number", e.Message);
            }
        }
        [Test]
        public void CheckUserInputEmailToEmailRegex()
        {           
            string[] inputId = System.IO.File.ReadAllLines(@"D:\Bridgelabz\.Net\Regex_User_Registration\Regex_User_Registration\TestEmail\Email_id_Valid.txt");
            foreach (string input in inputId)
            {
                string result = regularExpression.email(input);
                Assert.AreEqual("Valid", result);                
            }
        }
        [Test]
        public void CheckInvalidUserInputEmailToEmailRegex()
        {
            string[] inputId = System.IO.File.ReadAllLines(@"D:\Bridgelabz\.Net\Regex_User_Registration\Regex_User_Registration\TestEmail\Email_id_Invalid.txt");
            foreach (string input in inputId)
            {
                try
                {
                    string result = regularExpression.email(input);                   
                }
                catch(CustomExceptions e)
                {
                    Assert.AreEqual("Invalid Email Id", e.Message);
                }
                
            }
        }
    }
}
