using Microsoft.VisualStudio.TestTools.UnitTesting;
using UserRegistration;

namespace UserRegistrationTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void GivenFirstNameValid_ShouldReturnHappy()
        {
            string expected = "true";
            string actual = User.ValidateFirstName("Yogesh");
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void GivenFirstNameValid_ShouldReturnSad()
        {
            string expected = "false";
            string actual = User.ValidateFirstName("2ogesh");
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void GivenLastNameValid_ShouldReturnHappy()
        {
            string expected = "true";
            string actual = User.ValidateLastName("Kusakiya");
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void GivenLastNameInvalid_ShouldReturnSad()
        {
            string expected = "false";
            string actual = User.ValidateLastName("kUsakia");
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void GivenEmailValid_ShouldReturnHappy()
        {
            string expected = "true";
            string actual = User.ValidateEmail("abc-100@yahoo.com");
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void GivenEmailInvalid_ShouldReturnSad()
        {
            string expected = "false";
            string actual = User.ValidateEmail("xyz_11@ya@gmail.com");
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void GivenMobileValid_ShouldReturnHappy()
        {
            string expected = "true";
            string actual = User.ValidatePhone("91 9952647812");
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void GivenMobileInvalid_ShouldReturnSad()
        {
            string expected = "false";
            string actual = User.ValidatePhone("100");
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void GivenPasswordValid_ShouldReturnHappy()
        {
            string expected = "true";
            string actual = User.ValidatePassword("Yit@6341");
            Assert.AreEqual(actual, expected);
        }
        [TestMethod]
        public void GivenPasswordInvalid_ShouldReturnSad()
        {
            string expected = "false";
            string actual = User.ValidatePassword("91 88012");
            Assert.AreEqual(actual, expected);
        }
    }
}