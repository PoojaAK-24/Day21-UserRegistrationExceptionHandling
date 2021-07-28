using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace Day21_UserRegistrationExceptionHandling
{
    public class Patterns
    {
        public static string REGEX_FIRSTNAME = "^[A-Z]{1}[a-z]{2,}";
        public static string REGEX_LASTNAME = "[A-Z]{1}[a-z]{2,}";
        public bool ValidateFirstName(string firstName)
        {
            if (firstName == null)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionsType.Invalid_MESSAGE, "Invalid FirstName");
            }
            return Regex.IsMatch(firstName, REGEX_FIRSTNAME);
        }
        public bool ValidateLastName(string lastName)
        {
            if (lastName == null)
            {
                throw new UserRegistrationCustomException(UserRegistrationCustomException.ExceptionsType.Invalid_MESSAGE, "Invalid LastName");
            }
            return Regex.IsMatch(lastName, REGEX_LASTNAME);
        }
    }
}
