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
                result = AdjustInteger(result, i);
            return result.Substring(0, result.Length -1);
        }

        private static string AdjustInteger(string result, int i)
        {
            string adjusted;
            if (i % 3 == 0)
            {
                adjusted = "Fizz";
                if (i % 5 == 0)
                    adjusted += "Buzz";
            }
            else
                adjusted = i.ToString();
            return string.Format("{0}{1},", result, adjusted);
        }
    }
}
