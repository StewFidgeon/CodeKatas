using MarkSeemann.FizzBuzzKata;
using System;
using Xunit;

namespace MarkSeemann.FizzBuzzKataTests
{
    public class PrinterTests
    {
        [Fact]
        public void Printer_Should_PrintNumbers_1_to_100_with_Fizz_For_Multiples_Of_3()
        {
            var printer = new Printer();
            var expected = "1,2,Fizz,4,5,Fizz,7,8,Fizz,10,11,Fizz,13,14,Fizz,16,17,Fizz,19,20,Fizz,22,23,Fizz,25,26,Fizz,28,29,Fizz,31,32,Fizz,34,35,Fizz,37,38,Fizz,40,41,Fizz,43,44,Fizz,46,47,Fizz,49,50,Fizz,52,53,Fizz,55,56,Fizz,58,59,Fizz,61,62,Fizz,64,65,Fizz,67,68,Fizz,70,71,Fizz,73,74,Fizz,76,77,Fizz,79,80,Fizz,82,83,Fizz,85,86,Fizz,88,89,Fizz,91,92,Fizz,94,95,Fizz,97,98,Fizz,100";

            var actual = printer.GetOutput();

            Assert.Equal(expected, actual);
        }
    }
}
