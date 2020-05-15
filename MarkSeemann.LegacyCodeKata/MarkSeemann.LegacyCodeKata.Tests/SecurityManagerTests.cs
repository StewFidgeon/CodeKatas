using Moq;
using System;
using System.Collections.Generic;
using Xunit;

namespace MarkSeemann.LegacyCodeKata.Tests
{
    public class SecurityManagerTests
    {
        [Fact]
        public void GivenAnInputSource_UserIsCreated()
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

            Assert.Equal(expected.Count, spy.Outputs.Count);
            for (int i = 0; i < expected.Count; i++)
                Assert.Equal(expected[i], spy.Outputs[i]);
        }
    }
}
