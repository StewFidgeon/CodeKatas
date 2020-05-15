using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace MarkSeemann.LegacyCodeKata.Tests
{
    public class SecurityManagerTests
    {
        [Fact]
        public void GivenAValidInput_UserIsCreated()
        {
            var source = new Mock<IInputSource>();
            source.Setup(s => s.GetInput());
            source.Setup(s => s.Username).Returns("username");
            source.Setup(s => s.Fullname).Returns("user name");
            source.Setup(s => s.Password).Returns("password");
            source.Setup(s => s.PasswordConfirmation).Returns("password");

            var spy = new SpyOutputDestination();

            var expected = new List<string> { "Saving Details for User (username, user name, drowssap)\n" };

            var sm = new SecurityManager(source.Object, spy);
            sm.CreateUser();

            DoAssertions(spy, expected);
        }

        [Fact]
        public void GivenAnUnconfirmedPasswordInput_UserIsNotCreated()
        {
            var source = new Mock<IInputSource>();
            source.Setup(s => s.GetInput());
            source.Setup(s => s.Username).Returns("username");
            source.Setup(s => s.Fullname).Returns("user name");
            source.Setup(s => s.Password).Returns("password");
            source.Setup(s => s.PasswordConfirmation).Returns("wrongpassword");

            var spy = new SpyOutputDestination();

            var expected = new List<string> { "The passwords don't match" };

            var sm = new SecurityManager(source.Object, spy);
            sm.CreateUser();

            DoAssertions(spy, expected);
        }

        [Fact]
        public void GivenAnInvalidPasswordInput_UserIsNotCreated()
        {
            var source = new Mock<IInputSource>();
            source.Setup(s => s.GetInput());
            source.Setup(s => s.Username).Returns("username");
            source.Setup(s => s.Fullname).Returns("user name");
            source.Setup(s => s.Password).Returns("pass");
            source.Setup(s => s.PasswordConfirmation).Returns("pass");

            var spy = new SpyOutputDestination();

            var expected = new List<string> { "Password must be at least 8 characters in length" };

            var sm = new SecurityManager(source.Object, spy);
            sm.CreateUser();

            DoAssertions(spy, expected);
        }

        private void DoAssertions(SpyOutputDestination spy, List<string> expected)
        {
            Assert.Equal(expected.Count, spy.Outputs.Count);
            for (int i = 0; i < expected.Count; i++)
                Assert.Equal(expected[i], spy.Outputs[i]);
        }
    }
}
