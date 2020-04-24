using MarkSeemann.FizzBuzzKata;
using System;
using Xunit;

namespace MarkSeemann.FizzBuzzKataTests
{
    public class PrinterTests
    {
        [Fact]
        public void Printer_Should_PrintNumbers_1_to_100_with_Fizz_For_Multiples_Of_3_and_Buzz_For_Multiples_Of_5()
        {
            var printer = new Printer();
            var expected = "1,2,Fizz,4,Buzz,Fizz,7,8,Fizz,Buzz,11,Fizz,13,14,Fizz,16,17,Fizz,19,Buzz,Fizz,22,23,Fizz,Buzz,26,Fizz,28,29,Fizz,31,32,Fizz,34,Buzz,Fizz,37,38,Fizz,Buzz,41,Fizz,43,44,Fizz,46,47,Fizz,49,Buzz,Fizz,52,53,Fizz,Buzz,56,Fizz,58,59,Fizz,61,62,Fizz,64,Buzz,Fizz,67,68,Fizz,Buzz,71,Fizz,73,74,Fizz,76,77,Fizz,79,Buzz,Fizz,82,83,Fizz,Buzz,86,Fizz,88,89,Fizz,91,92,Fizz,94,Buzz,Fizz,97,98,Fizz,Buzz";

            var actual = printer.GetOutput();

            Assert.Equal(expected, actual);
        }
    }
}
