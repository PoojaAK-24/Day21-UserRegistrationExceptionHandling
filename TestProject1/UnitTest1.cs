using Day21_UserRegistrationExceptionHandling;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestProject1
{
    [TestClass]
    public class Tests
    {
        readonly Patterns patternsMatch = new Patterns();

        [TestMethod]
        public void GivenFirstName_ShouldThrow_UserRegistrationCustomException()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, patternsMatch.ValidateFirstName(null));
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Invalid FirstName", e.Message);
            }
        }

        [TestMethod]
        public void GivenLastName_ShouldThrow_UserRegistrationCustomException()
        {
            try
            {
                bool expected = true;
                Assert.AreEqual(expected, patternsMatch.ValidateLastName(null));
            }
            catch (UserRegistrationCustomException e)
            {
                Assert.AreEqual("Invalid LastName", e.Message);
            }
        }
    }
}