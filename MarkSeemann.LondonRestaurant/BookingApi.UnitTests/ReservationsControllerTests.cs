﻿using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using Xunit;

namespace Ploeh.Samples.BookingApi.UnitTests
{
    public class ReservationsControllerTests
    {
        [Fact]
        public void PostInvalidDto()
        {
            //Arrange
            ReservationDto dto = new ReservationDto();
            var validator = new Mock<IValidator>();
            validator.Setup(v => v.Validate(dto)).Returns(It.IsAny<string>());

            var mapper = new Mock<IMapper>();
            mapper.Setup(map => map.Map(dto)).Returns(new Reservation());

            var maîtreD = new Mock<IMaîtreD>();
            maîtreD.Setup(maî => maî.TryAccept(new Reservation()));
            ReservationsController sut = new ReservationsController(validator.Object, mapper.Object, maîtreD.Object);

            //Act
            var actual = sut.Post(dto);

            //Assert
            var br = Assert.IsAssignableFrom<BadRequestObjectResult>(actual);

            var expected = sut.Response;
            Assert.Equal(expected, br.Value);
        }

        [Fact]
        public void PostValidDtoWhenEnoughCapacityExists()
        {
            //Arrange
            var expected = 1;
            var dto = new ReservationDto { Quantity = 10 };

            var validator = new Mock<IValidator>();
            validator.Setup(v => v.Validate(dto)).Returns(string.Empty);

            var mapper = new Mock<IMapper>();
            mapper.Setup(map => map.Map(dto)).Returns(It.IsAny<Reservation>());

            var md = new Mock<IMaîtreD>();
            md.Setup(m => m.TryAccept(It.IsAny<Reservation>())).Returns(expected);
            ReservationsController sut = new ReservationsController(validator.Object, mapper.Object, md.Object);

            //Act
            var actual = sut.Post(dto);

            //Assert
            var ok = Assert.IsAssignableFrom<OkObjectResult>(actual);
            Assert.Equal(expected, ok.Value);
        }

        [Fact]
        public void PostValidDtoWhenSoldOut()
        {
            //Arrange
            var dto = new ReservationDto { Date = "01/01/1970" };

            var validator = new Mock<IValidator>();
            validator.Setup(v => v.Validate(dto)).Returns(string.Empty);

            var mapper = new Mock<IMapper>();
            mapper.Setup(map => map.Map(dto)).Returns(It.IsAny<Reservation>());

            var md = new Mock<IMaîtreD>();
            md.Setup(m => m.TryAccept(It.IsAny<Reservation>())).Returns((int?)null);
            ReservationsController sut = new ReservationsController(validator.Object, mapper.Object, md.Object);

            //Act
            var actual = sut.Post(dto);

            //Assert
            var c = Assert.IsAssignableFrom<ObjectResult>(actual);
            var expected = 500;
            Assert.Equal(expected, c.StatusCode);
        }
    }
}
