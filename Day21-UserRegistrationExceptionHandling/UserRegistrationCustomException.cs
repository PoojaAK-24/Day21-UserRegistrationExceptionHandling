using System;
using System.Collections.Generic;
using System.Text;

namespace Day21_UserRegistrationExceptionHandling
{
    public class UserRegistrationCustomException : Exception
    {
        public enum ExceptionsType
        {
            Invalid_MESSAGE,
        }
        public ExceptionsType type;
        public UserRegistrationCustomException(ExceptionsType Type, string message) : base(message)
        {
            this.type = Type;
        }
    }
}
