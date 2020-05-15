using System;
using System.Collections.Generic;
using System.Text;

namespace MarkSeemann.LegacyCodeKata
{
    public class SecurityManager
    {
        private readonly IInputSource _input;
        private readonly IOutputDestination _output;
        private readonly IPasswordValidator _validator;

        public SecurityManager(IInputSource input, IOutputDestination output, IPasswordValidator validator)
        {
            _input = input;
            _output = output;
            _validator = validator;
        }

        public void CreateUser()
        {
            var username = _input.Username;
            var fullName = _input.Fullname;
            var password = _input.Password;
            var confirmPassword = _input.PasswordConfirmation;
            //if (password != confirmPassword)
            //{
            //    _output.Output("The passwords don't match");
            //    return;
            //}
            //if (password.Length < 8)
            //{
            //    _output.Output("Password must be at least 8 characters in length");
            //    return;
            //}
            if (!_validator.Ok(_input, _output))
                return;
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
