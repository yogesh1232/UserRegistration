using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        public void GivenFirstNameValid_ShouldReturnHappy()
        {
            bool expected = true;
            bool actual = User.ValidateFirstName();
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void GivenFirstNameValid_ShouldReturnSad()
        {
            bool expected = false;
            bool actual = User.ValidateFirstName();
            Assert.AreNotEqual(actual, expected);
        }
        [TestMethod]
        public void GivenLastNameValid_ShouldReturnHappy()
        {
            bool expected = true;
            bool actual = User.ValidateLastName();
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void GivenLastNameInvalid_ShouldReturnSad()
        {
            bool expected = false;
            bool actual = User.ValidateLastName();
            Assert.AreNotEqual(actual, expected);
        }
        [TestMethod]
        public void GivenEmailValid_ShouldReturnHappy()
        {
            bool expected = true;
            bool actual = User.ValidateEmail();
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void GivenEmailInvalid_ShouldReturnSad()
        {
            bool expected = false;
            bool actual = User.ValidateEmail();
            Assert.AreNotEqual(actual, expected);
        }
        [TestMethod]
        public void GivenMobileValid_ShouldReturnHappy()
        {
            bool expected = true;
            bool actual = User.ValidatePhone();
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void GivenMobileInvalid_ShouldReturnSad()
        {
            bool expected = false;
            bool actual = User.ValidatePhone();
            Assert.AreNotEqual(actual, expected);
        }
        [TestMethod]
        public void GivenPasswordValid_ShouldReturnHappy()
        {
            bool expected = true;
            bool actual = User.PasswordR1();
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void GivenPasswordInvalid_ShouldReturnSad()
        {
            bool expected = false;
            bool actual = User.PasswordR1();
            Assert.AreNotEqual(actual, expected);
        }
    }
}