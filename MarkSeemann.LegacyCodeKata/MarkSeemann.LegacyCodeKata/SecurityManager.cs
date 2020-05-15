using System;
using System.Collections.Generic;
using System.Text;

namespace MarkSeemann.LegacyCodeKata
{
    public class SecurityManager
    {
        private readonly IDataPipe _pipe;
        private readonly IPasswordValidator _validator;

        public SecurityManager(IDataPipe pipe, IPasswordValidator validator)
        {
            _pipe = pipe;
            _validator = validator;
        }

        public void CreateUser()
        {
            _pipe.WriteLine("Enter a username");
            var username = _pipe.Readline();
            _pipe.WriteLine("Enter your full name");
            var fullName = _pipe.Readline();
            _pipe.WriteLine("Enter your password");
            var password = _pipe.Readline();
            _pipe.WriteLine("Re-enter your password");
            var confirmedPassword = _pipe.Readline();

            if (!_validator.Ok(_pipe, password, confirmedPassword))
                return;
            // Encrypt the password (just reverse it, should be secure)
            char[] array = password.ToCharArray();
            Array.Reverse(array);
            _pipe.WriteLine(String.Format("Saving Details for User ({0}, {1}, {2})\n",
            username,
            fullName,
            new string(array)));
        }
    }
}
