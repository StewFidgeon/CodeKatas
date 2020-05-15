using System;
using System.Collections.Generic;
using System.Text;

namespace MarkSeemann.LegacyCodeKata
{
    public class PasswordValidator : IPasswordValidator
    {
        public bool Ok(IInputSource input, IOutputDestination output)
        {
            if (input.Password != input.PasswordConfirmation)
            {
                output.Output("The passwords don't match");
                return false;
            }
            if (input.Password.Length < 8)
            {
                output.Output("Password must be at least 8 characters in length");
                return false;
            }
            return true;
        }
    }
}
