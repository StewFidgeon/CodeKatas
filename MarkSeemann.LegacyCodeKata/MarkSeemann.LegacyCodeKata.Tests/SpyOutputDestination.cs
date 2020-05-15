using System;
using System.Collections.Generic;
using System.Text;

namespace MarkSeemann.LegacyCodeKata.Tests
{
    public class SpyOutputDestination : IOutputDestination
    {
        public SpyOutputDestination()
        {
            Outputs = new List<string>();
        }

        public List<string> Outputs { get; private set; }

        public void Output(string output)
        {
            Outputs.Add(output);
        }
    }
}
