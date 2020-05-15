using System;
using System.Collections.Generic;
using System.Text;

namespace MarkSeemann.LegacyCodeKata
{
    public interface IInputSource
    {
        public string Username { get; set; }
        public string Fullname { get; set; }
        public string Password { get; set; }
        public string PasswordConfirmation { get; set; }
        public void GetInput();
    }
}
