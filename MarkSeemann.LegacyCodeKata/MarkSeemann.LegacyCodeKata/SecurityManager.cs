using System;
using System.Collections.Generic;
using System.Text;

namespace MarkSeemann.LegacyCodeKata
{
    public class SecurityManager
    {
        private readonly IInputSource _input;
        private readonly IOutputDestination _output;

        public SecurityManager(IInputSource input, IOutputDestination output)
        {
            _input = input;
            _output = output;
        }

        public void CreateUser()
        {
            var username = _input.Username;
            var fullName = _input.Fullname;
            var password = _input.Password;
            var confirmPassword = _input.PasswordConfirmation;
            if (password != confirmPassword)
            {
                _output.Output("The passwords don't match");
                return;
            }
            if (password.Length < 8)
            {
                _output.Output("Password must be at least 8 characters in length");
                return;
            }
            // Encrypt the password (just reverse it, should be secure)
            char[] array = password.ToCharArray();
            Array.Reverse(array);
            _output.Output(String.Format("Saving Details for User ({0}, {1}, {2})\n",
            username,
            fullName,
            new string(array)));
        }
    }
}
