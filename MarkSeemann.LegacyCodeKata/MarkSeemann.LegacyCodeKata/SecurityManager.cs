namespace MarkSeemann.LegacyCodeKata
{
    public class SecurityManager
    {
        private readonly IDataPipe _pipe;
        private readonly IPasswordValidator _validator;
        private readonly ICypher _cypher;

        public SecurityManager(IDataPipe pipe, IPasswordValidator validator, ICypher cypher)
        {
            _pipe = pipe;
            _validator = validator;
            _cypher = cypher;
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

            _pipe.WriteLine($"Saving Details for User ({username}, {fullName}, {_cypher.Encrypt(password)})\n");
        }
    }
}
