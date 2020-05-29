using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Xunit;

namespace Ploeh.Samples.BookingApi.UnitTests
{
    public class MaîtreDTests
    {
        [Fact]
        public void TryAcceptReturnsReservationIdInHappyPathScenario()
        {
            //Arrange
            Reservation reservation = new Reservation { Quantity = 10 };
            var expected = 1;
            var repo = new Mock<IReservationsRepository>();
            repo.Setup(r => r.ReadReservations(It.IsAny<DateTime>())).Returns(Enumerable.Empty<Reservation>());
            repo.Setup(r => r.Create(reservation)).Returns(expected);
            MaîtreD sut = new MaîtreD(20, repo.Object);

            //Act
            var actual = sut.TryAccept(reservation);

            //Assert
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void TryAcceptOnInsufficientCapacity()
        {
            Reservation reservation = new Reservation { Quantity = 21 };
            var id = 1;
            var repo = new Mock<IReservationsRepository>();
            repo.Setup(r => r.ReadReservations(It.IsAny<DateTime>())).Returns(Enumerable.Empty<Reservation>());
            repo.Setup(r => r.Create(reservation)).Returns(id);
            MaîtreD sut = new MaîtreD(20, repo.Object);

            int? expected = null;

            //Act
            var actual = sut.TryAccept(reservation);

            //Assert
            Assert.Equal(expected, actual);
        }
    }
}
