using System;
using System.Collections.Generic;
using System.Text;

namespace MarkSeemann.FizzBuzzKata
{
    public class Printer
    {
        public string GetOutput()
        {
            var result = string.Empty;
            for (var i = 1; i <= 100; i++)
                result = string.Format("{0}{1},", result, i % 3 == 0 ? "Fizz" : i % 5 == 0 ? "Buzz" : i.ToString());
            return result.Substring(0, result.Length -1);
        }
    }
}
