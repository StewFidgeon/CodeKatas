using System;
using System.Collections.Generic;
using System.Text;

namespace MarkSeemann.LegacyCodeKata
{
    public class PasswordValidator : IPasswordValidator
    {
        public bool Ok(IDataPipe pipe, string password, string confirmation)
        {
            var success = true;
            if (password != confirmation)
            {
                pipe.WriteLine("The passwords don't match");
                success = false;
            }
            if (password.Length < 8)
            {
                pipe.WriteLine("Password must be at least 8 characters in length");
                success = false;
            }
            return success;
        }
    }
}
