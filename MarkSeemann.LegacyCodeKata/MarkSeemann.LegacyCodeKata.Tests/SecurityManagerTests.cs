using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace MarkSeemann.LegacyCodeKata.Tests
{
    public class SecurityManagerTests
    {
        private const string _username = "username";
        private const string _name = "user name";
        private const string _password = "password";
        private const string _confirmedPassword = "password";
        private List<string> _expected = new List<string> { "Enter a username", "Enter your full name", "Enter your password", "Re-enter your password" };

        [Fact]
        public void GivenAValidInput_UserIsCreated()
        {
            var pipe = new DataPipeFake(new List<string> { _username, _name, _password, _confirmedPassword });
            var validator = new PasswordValidator();
            _expected.Add("Saving Details for User (username, user name, drowssap)\n");
            var cypher = new Mock<ICypher>();
            cypher.Setup(c => c.Encrypt(It.IsAny<string>())).Returns("drowssap");

            var sm = new SecurityManager(pipe, validator, cypher.Object);
            sm.CreateUser();

            DoAssertions(pipe.Outputs, _expected);
        }

        [Fact]
        public void GivenAnUnconfirmedPasswordInput_UserIsNotCreated()
        {
            var wrong = "wrongpassword";
            var pipe = new DataPipeFake(new List<string> { _username, _name, _password, wrong });
            var validator = new PasswordValidator();
            _expected.Add("The passwords don't match");
            var cypher = new Mock<ICypher>();
            cypher.Setup(c => c.Encrypt(It.IsAny<string>())).Returns("drowssap");

            var sm = new SecurityManager(pipe, validator, cypher.Object);
            sm.CreateUser();

            DoAssertions(pipe.Outputs, _expected);
        }

        [Fact]
        public void GivenAnInvalidPasswordInput_UserIsNotCreated()
        {
            var shortPwd = "pass";
            var pipe = new DataPipeFake(new List<string> { _username, _name, shortPwd, shortPwd });
            var validator = new PasswordValidator();
            _expected.Add("Password must be at least 8 characters in length");
            var cypher = new Mock<ICypher>();
            cypher.Setup(c => c.Encrypt(It.IsAny<string>())).Returns("drowssap");

            var sm = new SecurityManager(pipe, validator, cypher.Object);
            sm.CreateUser();

            DoAssertions(pipe.Outputs, _expected);
        }

        private void DoAssertions(List<string> actual, List<string> expected)
        {
            Assert.Equal(expected.Count, actual.Count);
            for (int i = 0; i < expected.Count; i++)
                Assert.Equal(expected[i], actual[i]);
        }
    }
}
